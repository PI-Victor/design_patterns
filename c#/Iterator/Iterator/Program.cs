using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Iterator.Iterator;
using Iterator.Aggregate;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            INewspaper nyt = new NYPaper();
            INewspaper lat = new LAPaper();

            IIterator nypIterator = nyt.CreateIterator();
            IIterator lapIterator = lat.CreateIterator();

            Console.WriteLine("-----  NYPaper");
            PrintReporters(nypIterator);

            Console.WriteLine("-----  LAPaper");
            PrintReporters(lapIterator);

            Console.ReadLine();
        }

        static void PrintReporters(IIterator iterator)
        {
            iterator.First();
            while(!iterator.isDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    } 
}
