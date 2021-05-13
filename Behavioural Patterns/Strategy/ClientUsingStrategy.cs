using System;
using System.Collections.Generic;

namespace design_patterns.Strategy {
  class ClientUsingStrategy {
    public void doSomething() {

      Console.WriteLine("Strategy Pattern");
      Console.WriteLine("--------------------------------------------------------");

      var navigator = new Navigator(new WalkingStrategy());
      navigator.BuildRoute("Zoho", "Picadelli");

      navigator.SetStrategy(new RoadStrategy());
      navigator.BuildRoute("London", "Manchester");

      navigator.SetStrategy(new PublicTransportStrategy());
      navigator.BuildRoute("London", "Edinbourough");

      Console.WriteLine("--------------------------------------------------------");
    }  
  }
}