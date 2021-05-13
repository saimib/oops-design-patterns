using System;

namespace design_patterns.Strategy
{
    class Navigator {
      private IStrategy _routeStrategy;
      public Navigator(IStrategy strategy)
      {
          _routeStrategy = strategy;
      }
      public void SetStrategy(IStrategy strategy) {
        _routeStrategy = strategy;
      }
      public void BuildRoute(string startingPoint, string destination){
        _routeStrategy.BuildRoute(startingPoint, destination);
      }
    }
}