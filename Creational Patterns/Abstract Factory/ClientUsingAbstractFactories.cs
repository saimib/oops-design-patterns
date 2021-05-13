using System;
using design_patterns.Abstract_Factory.Controls;
using design_patterns.Abstract_Factory.Factories;

namespace design_patterns.Abstract_Factory
{
    class ClientUsingAbstractFactories {
      
      public void doSomething() {

        Console.WriteLine("Abstract Factory Pattern");
        Console.WriteLine("-----------------------------------------------------");

        var windowsApplication = new Application(new WinFactory());
        windowsApplication.CreateUI();
        windowsApplication.Paint();
        var macApplication = new Application(new MacFactory());
        macApplication.CreateUI();
        macApplication.Paint();

        Console.WriteLine("-----------------------------------------------");
      }
    }
}