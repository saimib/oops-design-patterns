using System;

namespace design_patterns.Facade
{
    class FileHandlerFacade {

      private ThirdPartyFileCompressor _compressor;
      private ThirdPartyFileEncryption _encryption;
      private ThirdPartyFileHandler _fileHandler;

      public FileHandlerFacade(
        ThirdPartyFileCompressor compressor, 
        ThirdPartyFileEncryption encryption, 
        ThirdPartyFileHandler fileHandler)
      {
          _compressor = compressor;
          _encryption = encryption;
          _fileHandler = fileHandler;
      }
      public void ProcessFile() {
        _fileHandler.ReadFile();
        _compressor.CompressFile();
        _encryption.EncryptFile();
      }
    }
}