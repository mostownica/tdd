using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDTrainingGround
{
    public static class DateTimeExtensions
    {
        public static DateTime Today(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }
    }
}
