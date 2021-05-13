using System;

namespace design_patterns.Strategy
{
    class WalkingStrategy: IStrategy {
      public void BuildRoute(string startingPoint, string destination){
        Console.WriteLine($"Get to {destination} from {startingPoint} by Walking using this route");
      }
    }
}