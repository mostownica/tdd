using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTrainingGround
{
    public class SimpleParser
    {

        public int Method(string numbers)
        {
            int num;
            try
            {
                num = Int32.Parse(numbers);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("argument needs to be provided");
            }
            catch (FormatException)
            {
                throw new FormatException("argument needs to be an int32");
            }
            catch (OverflowException)
            {
                throw new FormatException("argument needs to be an int32");
            }

            return num;

        }
        public int ParseAndSum(string numbers)
        {           
            
            if (!string.IsNullOrEmpty(numbers) && numbers.Contains(","))
            {
                int sum = 0;
                string[] table = numbers.Split(',');

                for (int i = 0; i < table.Length; i++)
                    {
                        sum += Method(table[i]);
                    }

                return sum;
            }

           return Method(numbers);                          
         
        }

    }
}
