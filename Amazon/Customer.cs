
using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var calc = new RateCalc();
            var rating = calc.Calculate();
            Console.WriteLine("changed");
        }

    }
}
