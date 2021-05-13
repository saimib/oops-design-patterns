using System;

namespace design_patterns.Facade
{
    class ThirdPartyFileEncryption {
      public void EncryptFile() {
        Console.WriteLine("Encrypted file from local filesystem");
      }
    }
}