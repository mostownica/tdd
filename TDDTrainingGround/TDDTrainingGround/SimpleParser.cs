using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTrainingGround
{
    public class SimpleParser
    {
        public int ParseAndSum(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                throw new ArgumentNullException("argument needs to be provided");
            }

            int result;
            if (!Int32.TryParse(numbers, out result))
            {
                throw new ArgumentNullException("argument needs to be a number");
            }

            //int result = Int32.Parse(numbers);
            return result;            
        }

    }
}
