using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;

namespace AtlantaTechnical
{
    internal class Calculator
    {
        public void Execute()
        {
            decimal totalPrice = 0;

            //Sample data
            Dictionary<string,decimal> result = new Dictionary<string,decimal>();
            result.Add("Cakes", Convert.ToDecimal(0.50));
            result.Add("A loaf of bread", Convert.ToDecimal(1.50));
            result.Add("An artisan loaf", Convert.ToDecimal(2.50));
           
            foreach (var key in result)
            {
               Console.WriteLine("Item name : " + key.Key);
               totalPrice += key.Value;
            }
            Console.WriteLine("Total Cost : " + totalPrice);
        }
    }
}
