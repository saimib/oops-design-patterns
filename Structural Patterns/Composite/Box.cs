using System.Collections.Generic;

namespace design_patterns.Composite
{
    class Box : IComponent {

    private List<IComponent> _children = new List<IComponent>();
    public int getTotal()
    {
      var price = 0;
      foreach (var item in _children)
      {
          price += item.getTotal();
      }
      return price;
    }

    public void add(IComponent component){
      this._children.Add(component);
    }

    public void remove(IComponent component){
      this._children.Remove(component);
    }

    public List<IComponent> getChildren(){
      return _children;
    }
  }
}