﻿using System.Collections.Generic;

using Iterator.Iterator;


namespace Iterator.Aggregate
{
    public class NYPaper : INewspaper
    {
        private List<string> _reporters;
        public NYPaper()
        {
            _reporters = new List<string>
            {
                "John Mesh - NY",
                "Susanna Lee - NY",
                "Paul Randy - NY",
            };
        }

        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}