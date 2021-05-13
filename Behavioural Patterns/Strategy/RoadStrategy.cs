using System;

namespace design_patterns.Strategy
{
    class RoadStrategy: IStrategy {
      public void BuildRoute(string startingPoint, string destination){
        Console.WriteLine($"Get to {destination} from {startingPoint} by Road using this route");
      }
    }
}