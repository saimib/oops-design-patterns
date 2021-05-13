using design_patterns.Factory.ModeOfTransports;

namespace design_patterns.Factory
{
  class SeaLogistics : Logistics{
    public override Transport createTransport() {
      return new Ship();
    }
  }
}
