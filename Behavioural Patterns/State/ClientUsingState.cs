using System;
using System.Collections.Generic;

namespace design_patterns.State {
  class ClientUsingState {
    public void doSomething() {

      Console.WriteLine("State Pattern");
      Console.WriteLine("--------------------------------------------------------");

      //Create a New Draft Document
      var document = new Document();
      document.Render();

      //The initial draft is ready for review
      document.ChangeState(new Moderation());
      document.Render();

      //Review Complete , Pulish the document
      document.ChangeState(new Published());
      document.Render();

      //Published document is expired
      document.ChangeState(new Draft());
      document.Render();

      Console.WriteLine("--------------------------------------------------------");
    }  
  }
}