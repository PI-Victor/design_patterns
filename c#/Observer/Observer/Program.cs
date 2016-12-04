using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverPattern;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var gClooney = new GClooney("I love my new wife");
            var tSwift = new TSwift("1981 is now my favorite number");

            var firstFan = new Fan();
            var secondFan = new Fan();

            gClooney.AddFollower(firstFan);
            tSwift.AddFollower(secondFan);

            gClooney.Tweet = "My new wife didn't force me to tweet. ";
            gClooney.Tweet = "I love my new music";

            Console.Read();
        }
    }
}
