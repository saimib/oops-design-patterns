using design_patterns.Factory.ModeOfTransports;

namespace design_patterns.Factory
{
  class RoadLogistics : Logistics {
    public override Transport createTransport() {
      return new Truck("hello world");
    }
  }
}
