using System;
using System.Collections.Generic;
using design_patterns.Flyweight.New;

namespace design_patterns.Proxy
{
    class ClientUsingProxy  {

    public void doSomething() {
   
      Console.WriteLine("Proxy Pattern");
      Console.WriteLine("-------------------------------------------");

      IService service = new ServiceProxy(new Service());
      service.GetMoney();

      Console.WriteLine("-------------------------------------------");
    }
  }
}