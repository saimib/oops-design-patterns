using System;
using System.Collections.Generic;
using design_patterns.Flyweight.New;

namespace design_patterns.Chain_of_responsibility
{
    class ClientUsingChainOfResponsibility  {

    public void doSomething() {
      
      Console.WriteLine("ClientUsingChainOfResponsibility Pattern");
      Console.WriteLine("-------------------------------------------");

      var authenticationHandler = new AuthenticationHandler();
      var authorizationHandler = new AuthorizationHandler();
      var requestValidationHandler = new RequestValidationHandler();
      var requestHandler = new RequestHandler();

      authenticationHandler.setNext(authorizationHandler);
      authorizationHandler.setNext(requestValidationHandler);
      requestValidationHandler.setNext(requestHandler);

      authenticationHandler.handle("Hello World");

      Console.WriteLine("-------------------------------------------");
    }
  }
}