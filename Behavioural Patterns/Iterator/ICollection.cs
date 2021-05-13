namespace design_patterns.Iterator
{
    interface ICollection {
      IIterator GetIterator();
    }
}