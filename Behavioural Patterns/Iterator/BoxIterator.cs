using System.Collections.Generic;

namespace design_patterns.Iterator
{
  class BoxIterator : IIterator
  {
    private List<string> _collection;
    private List<string>.Enumerator _enumerator;
    private bool _hasMore;

    public BoxIterator(List<string> collection)
    {
        _collection = collection;
        _enumerator = _collection.GetEnumerator();
        _hasMore = _enumerator.MoveNext();
    }
    public string GetNext()
    {
      var currentItem = _enumerator.Current;
      _hasMore = _enumerator.MoveNext();
      return currentItem;
    }

    public bool HasMore()
    {
      return _hasMore;
    }
  }
}