using System;
using System.Collections.Generic;

namespace design_patterns.Visitor
{
  class ClientUsingVisitor {
    public void doSomething() {

      Console.WriteLine("Visitor Pattern");
      Console.WriteLine("--------------------------------------------------------");

      var nodes = new List<INode>();
      nodes.Add(new Road());
      nodes.Add(new House());
      nodes.Add(new PublicPlaces());

      var visitor = new XMLExportVisitor();
      foreach (var item in nodes)
      {
          item.accept(visitor);
      }

      Console.WriteLine("--------------------------------------------------------");
    }  
  }
}