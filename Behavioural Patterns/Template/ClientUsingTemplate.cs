using System;

namespace design_patterns.Template {
  class ClientUsingTemplate {
    public void doSomething() {

      Console.WriteLine("Template Pattern");
      Console.WriteLine("--------------------------------------------------------");

      var pdfdataMiner = new PDFDataMiner();
      pdfdataMiner.Mine("path");

      var textdataMiner = new TextDataMiner();
      textdataMiner.Mine("path");

      Console.WriteLine("--------------------------------------------------------");
    }  
  }
}