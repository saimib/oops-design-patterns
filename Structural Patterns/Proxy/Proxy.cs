using System;

namespace design_patterns.Proxy
{
  class ServiceProxy : IService
  {
    private IService _service;

    public ServiceProxy(IService service)
    {
        _service = service;
    }
    public void GetMoney()
    {
      if(checkAccess())
        Console.WriteLine("I've got the money");
    }

    private bool checkAccess() {
      Console.WriteLine("Checking Access to the Account");
      return true;
    }
  }
}