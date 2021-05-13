using System;

namespace design_patterns.Observer {
  class Delivery: ISubscriber {
    public void update(string context)
    {
      Console.WriteLine($"I got notified about Deliver - {context}");
    }
  }
}