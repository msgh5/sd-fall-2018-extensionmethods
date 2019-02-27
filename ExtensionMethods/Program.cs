using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenDate = DateTime.Now;
            var startDate = new DateTime(2019, 01, 01);
            var endDate = new DateTime(2019, 05, 01);

            //Extension method
            var isInBetween = 
                givenDate.IsInBetween(startDate, endDate);

            //Helper static class
            var isInBetween2 = DateTimeHelper.IsInBetween(
                givenDate, startDate, endDate);
            

            Console.WriteLine(isInBetween);
            Console.WriteLine(isInBetween2);
            Console.ReadLine();
        }
    }
}
