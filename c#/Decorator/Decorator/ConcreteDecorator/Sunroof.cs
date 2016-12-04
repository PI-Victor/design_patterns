using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 3400;
    }
}
