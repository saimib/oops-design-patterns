using System;
using design_patterns.Bridge.New;
using design_patterns.Bridge.Old;

namespace design_patterns.Bridge
{
    class ClientUsingBridge {
      public void doSomething() {

        Console.WriteLine("Bridge Pattern");
        Console.WriteLine("-------------------------------------------");

        var oldcircle = new RedCircle();
        Console.WriteLine($"The Color is {oldcircle.getColor()} and the Shape is {oldcircle.getShape()} from smelly code");

        var color = new Red();
        var newcircle = new Circle(color);
        Console.WriteLine($"The Color is {newcircle.getColor()} and the Shape is {newcircle.getShape()} from clean code");

        Console.WriteLine("-------------------------------------------");
      }
    }
}