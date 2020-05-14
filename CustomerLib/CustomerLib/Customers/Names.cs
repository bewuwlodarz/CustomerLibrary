using System;
using System.Collections.Generic;
using System.Text;

namespace BWlo.Helpers.Customers
{
    public class Names
    {
       
       


        public static List<string> GenerateList(int n)
        {
            List<string> NameList = new List<string>();


            for (var i = 1; i <= n; i++)
            {
                var name = Helpers.Customers.Helper.MakeUniqueCustomerName(NameList);
                NameList.Add(name);
            }
            return NameList;
        }

       public static List<string> MakeEmail(List<string> customerName)
        {
            List<string> EmailList = new List<string>();
            foreach (var n in customerName)
            {
                EmailList.Add($"contact@{n.ToLower()}.com");
            }
            return EmailList;

        }



    }
    public class Dates
    {
        private static Random _rand = new Random();
        public static List<DateTime> OrderDate(int n)
        {
            List<DateTime> OrderDates = new List<DateTime>();
            for(var i=1;i<=n; i++)
            {
                OrderDates.Add(Helpers.Customers.Helper.GetRandomOrderPlaced());
            }
            return OrderDates;
        }

        

    }

}

