using System;
using BWlo.Helpers.Customers;

namespace ConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var names = Names.GenerateList(100);
            var emails = Names.MakeEmail(names);
            var dates = Dates.OrderDate(100);
            foreach(var n in emails)
            {
                
                Console.WriteLine(n);
            }
            foreach(var d in dates)
            {
                Console.WriteLine("Ordered: " + d);
                Console.WriteLine("Completed: " + Helper.GetRandomOrderCompleted(d));
            }
            Console.ReadLine();
           
        }
    }
}
