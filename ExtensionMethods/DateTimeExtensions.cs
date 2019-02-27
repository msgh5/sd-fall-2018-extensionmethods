using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {
        //For a method to qualify as a extension method it needs:
        //1 - Be static and be inside a static class.
        //2 - Use the this keyword in the first parameter which should be the type that you want to extend.
        //Extension methods are useful for extending classes that we don't have access to the source code.
        public static bool IsInBetween(this DateTime givenDate, 
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
