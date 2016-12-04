using System;


namespace ObserverPattern
{
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: " + 
                $"{celebrity.Tweet}");
        }
    }
}