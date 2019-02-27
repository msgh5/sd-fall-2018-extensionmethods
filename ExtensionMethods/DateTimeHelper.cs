using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DateTimeHelper
    {
        public static bool IsInBetween(DateTime givenDate,
            DateTime startDate, DateTime endDate)
        {
            var isInBetween = false;

            if (givenDate.Date >= startDate.Date &&
                givenDate <= endDate.Date)
            {
                isInBetween = true;
            }

            return isInBetween;
        }
    }
}
