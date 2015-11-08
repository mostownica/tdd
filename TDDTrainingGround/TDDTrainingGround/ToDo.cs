using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTrainingGround
{
    public class ToDo
    {
        public string activity;
        public DateTime date;

        public ToDo(string act, DateTime da)
        {
            activity = act;
            date = da;
        }

        public ToDo(string act)
        {
            activity = act;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            ToDo obiekt = obj as ToDo;
            if (obiekt == null)
            {
                return false;
            }
            return obiekt.activity.Equals(this.activity) && obiekt.date.Equals(this.date);
        }
    }
}
