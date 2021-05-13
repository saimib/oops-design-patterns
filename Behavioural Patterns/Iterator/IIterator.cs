namespace design_patterns.Iterator
{
    interface IIterator {
      string GetNext();
      bool HasMore();
    }
}