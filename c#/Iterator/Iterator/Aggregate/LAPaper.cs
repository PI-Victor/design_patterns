using Iterator.Iterator;

namespace Iterator.Aggregate
{
    // ConcreteAggregate
    public class LAPaper : INewspaper
    {
        private string[] _reporters;
        public LAPaper()
        {
            _reporters = new[]
            {
                "Ronald Smith - LA",
                "Danny Glover - LA",
                "Yolanda Adams - LA",
            };
        }

        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}