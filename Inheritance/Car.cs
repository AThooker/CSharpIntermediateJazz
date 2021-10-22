using System;

namespace Inheritance
{
    public class Car : Vehicle 
    {
        public Car(string registrationNum)
            :base(registrationNum)
        {
            Console.WriteLine("Car is being initialized with a reg number of {0}", registrationNum);
        }
    }
}
