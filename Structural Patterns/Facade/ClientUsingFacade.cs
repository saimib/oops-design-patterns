using System;
using System.Collections.Generic;

namespace design_patterns.Facade
{
    class ClientUsingFacade  {

    public void doSomething() {
      
      Console.WriteLine("Facade Pattern");
      Console.WriteLine("-------------------------------------------");

      var facade = new FileHandlerFacade(
        new ThirdPartyFileCompressor(),
        new ThirdPartyFileEncryption(),
        new ThirdPartyFileHandler()
      );
      facade.ProcessFile();

      Console.WriteLine("-------------------------------------------");
    }
  }
}