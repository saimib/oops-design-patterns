using System;

namespace design_patterns.Strategy
{
    class PublicTransportStrategy: IStrategy {
      public void BuildRoute(string startingPoint, string destination){
        Console.WriteLine($"Get to {destination} from {startingPoint} by Public Transport using this route");
      }
    }
}