using System.Collections.Generic;

namespace design_patterns.Memento
{
  class Backup : IMemento{
    private List<string> _cart;

    public Backup(List<string> cart)
    {
        _cart = cart;
    }
    public void getName()
    {
      throw new System.NotImplementedException();
    }

    public void getSnapshotDate()
    {
      throw new System.NotImplementedException();
    }

    public List<string> getState() {
      return _cart;
    }
  }
}