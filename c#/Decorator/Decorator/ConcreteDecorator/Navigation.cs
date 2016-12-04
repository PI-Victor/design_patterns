﻿using Decorator.Component;
using Decorator.Decorator;


namespace Decorator.ConcreteDecorator
{
    class Navigation : CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";

        public override double GetCarPrice() => _car.GetCarPrice() + 5000;
    }
}