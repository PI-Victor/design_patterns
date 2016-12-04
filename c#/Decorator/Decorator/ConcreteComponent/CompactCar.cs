using System;
using Decorator.Component;


namespace Decorator.ConcreteComponent
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 10000.00;
        
    }
}