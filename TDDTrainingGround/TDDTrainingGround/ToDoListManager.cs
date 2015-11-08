using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTrainingGround
{
    public class ToDoListManager
    {
        List<ToDo> ToDoList = new List<ToDo>();
        public void Add(ToDo todo)
        {
            if (todo == null)
            {
                throw new ArgumentNullException("todo needs to be provided");                
            }
            if (ToDoList.Contains(todo))
            {
                throw new InvalidOperationException("there is already the same todo");
            }
            ToDoList.Add(todo);
        }
        public List<ToDo> GetAllThingsToDo()
        {
            return ToDoList;
        }

        public ToDo GetNextThingToDo()
        {
            List<ToDo> FirstToDoList = new List<ToDo>();
            foreach (ToDo todo in ToDoList)
            {
                if (todo.date > SystemTime.Now())
                {
                    FirstToDoList.Add(todo);
                }                
            }
            ToDo temp = null;
            DateTime time = DateTime.MaxValue;
            foreach (ToDo todo in FirstToDoList)
            {
                if (time > todo.date)
                {
                    temp = todo;
                    time = todo.date;
                }
            }
            return temp;
        }
        public List<ToDo> GetTodaysToDos()
        {
            List<ToDo> TodayToDoList = new List<ToDo>();
            foreach (ToDo todo in ToDoList)
            {
                if (todo.date.Today() == SystemTime.Now().Today())
                {
                    TodayToDoList.Add(todo);
                }
            }
            return TodayToDoList;
        }
        public List<ToDo> GetToDosFromDate(DateTime data)
        {
            List<ToDo> FromDateToDoList = new List<ToDo>();
            foreach (ToDo todo in ToDoList)
            {
                if (todo.date.Today()>= data)
                {
                    FromDateToDoList.Add(todo);
                }
            }
            return FromDateToDoList;
        }

    }
}
