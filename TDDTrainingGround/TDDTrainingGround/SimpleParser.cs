﻿using System;
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
            if (numbers==null)
            {
                throw new ArgumentNullException("argument needs to be provided");
            }
            return 0;            
        }

    }
}
