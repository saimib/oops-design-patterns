using System;

namespace design_patterns.Facade
{
    class ThirdPartyFileHandler {
      public void ReadFile() {
        Console.WriteLine("Read file from local filesystem");
      }
    }
}