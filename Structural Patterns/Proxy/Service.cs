using System;

namespace design_patterns.Proxy
{
  class Service : IService
  {
    public void GetMoney()
    {
      Console.WriteLine("I've got the money");
    }
  }
}