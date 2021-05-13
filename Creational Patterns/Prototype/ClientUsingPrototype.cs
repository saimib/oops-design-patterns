using System;
using System.Collections.Generic;

namespace design_patterns.prototype
{
    class ClientUsingPrototype
    {
        public void doSomething(){

          Console.WriteLine("ProtoType Pattern");
          Console.WriteLine("----------------------------------------------------");
          
          var shapes = new List<Shape>();

          Shape circle = new Circle(10);
          circle.x = 10;
          circle.y = 10;

          shapes.Add(circle);

          Shape anotherCircle = circle.clone();
          shapes.Add(anotherCircle);

          Shape rectangle = new Rectangle(10,10);
          rectangle.x = 20;
          rectangle.y = 20;
          shapes.Add(rectangle);


          var shapesCopy = new List<Shape>();
          
          shapes.ForEach(item => {
              shapesCopy.Add(item.clone());
          });

          shapesCopy.ForEach(item => {
              Console.WriteLine(item.WhoAmI());
          });

          Console.WriteLine("----------------------------------------------------");
        }
    }
}