using System;

namespace design_patterns.Observer {
  class Inventory: ISubscriber {
    public void update(string context)
    {
      Console.WriteLine($"I got notified about Inventory - {context}");
    }
  }
}