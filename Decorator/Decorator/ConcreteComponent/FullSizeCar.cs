using System;
using Decorator.Component;


namespace Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class FullSizeCar: Car
    {
        public FullSizeCar()
        {

        }

        public override string GetDescription() => Description;
        public override double GetCarPrice() => 30000.00;
    }
}