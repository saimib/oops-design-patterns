namespace design_patterns.Factory.ModeOfTransports
{
  class Aeroplane : Transport {
    public override string deliver() {
      return $"Delivered in Aeroplane";
    }
  }
}
