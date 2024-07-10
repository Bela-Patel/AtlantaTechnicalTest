using System;

namespace AtlantaTechnical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call method of display numbers
            //var obj = new DisplayNumbers();
            //obj.Execute();

            // Call method of display items and total cost 
            var obj = new Calculator();
            obj.Execute();
        }
    }
}
