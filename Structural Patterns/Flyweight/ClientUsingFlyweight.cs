using System;
using System.Collections.Generic;
using design_patterns.Flyweight.New;

namespace design_patterns.Flyweight
{
    class ClientUsingFlyweight  {

    public void doSomething() {
      
      Console.WriteLine("Flyweight Pattern");
      Console.WriteLine("-------------------------------------------");

      var spritePath = @"./Structural Patterns/Flyweight/sprite.jpg";

      var game = new Game(spritePath);
      var particlesInGame = 10; //Change it to a million to bomb your RAM.

      for (int i = 0; i < particlesInGame; i++)
      {
          game.AddParticle();
      }

      game.Draw();

      Console.WriteLine("-------------------------------------------");
    }
  }
}