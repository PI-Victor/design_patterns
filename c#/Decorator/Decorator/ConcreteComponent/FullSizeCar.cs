using System;
using Decorator.Component;


namespace Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class FullSizeCar: Car
    {
        public FullSizeCar()
        {
            Description = "Sedan";
        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 45000.00;
    }
}