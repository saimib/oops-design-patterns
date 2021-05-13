using System;
using System.Collections.Generic;

namespace design_patterns.Observer {
  class ClientUsingObserver {
    public void doSomething() {

      Console.WriteLine("Observer Pattern");
      Console.WriteLine("--------------------------------------------------------");

      var publisher = new Publisher();
      publisher.Subscribe(new Delivery());
      publisher.Subscribe(new Inventory());
      publisher.UpdateState("hello world");

      Console.WriteLine("--------------------------------------------------------");
    }  
  }
}