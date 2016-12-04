namespace Iterator.Iterator
{
    public interface IIterator
    {
        void First();                       // Sets current element to the first element
        string Next();                      // Advances current to next element
        bool isDone();                      // Check if end of collection
        string CurrentItem();               // Returns the current element
    }
}