using System;

namespace design_patterns.Mediator
{
    class ClientUsingMediator {
      public void doSomething() {

        Console.WriteLine("Mediator Pattern");
        Console.WriteLine("------------------------------------------------------");

        var dialog = new Dialog();
        dialog.EnterTextAndSubmit();

        Console.WriteLine("------------------------------------------------------");
      }
    }
}