using design_patterns.Builder.Products;
using System;

namespace design_patterns.Builder.Builders
{
  class ClientUsingBuilder
  {
    public void doSomething() {

      Console.WriteLine("Builder Pattern");
      Console.WriteLine("---------------------------------------------------");

      var application = new Application();
      application.createCarAndManual();

      Console.WriteLine("-----------------------------------------------");
    }
  }
}