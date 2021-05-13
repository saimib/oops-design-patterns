using System;

namespace design_patterns.Facade
{
    class ThirdPartyFileCompressor {
      public void CompressFile() {
        Console.WriteLine("Compressed file from local filesystem");
      }
    }
}