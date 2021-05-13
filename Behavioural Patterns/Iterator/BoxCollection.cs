using System.Collections.Generic;

namespace design_patterns.Iterator
{
  class BoxCollection : ICollection
  {
    private List<string> _collection = new List<string>();
    public IIterator GetIterator()
    {
      return new BoxIterator(_collection);
    }
    public void Add(string item) {
      _collection.Add(item);
    }
  }
}