namespace design_patterns.Factory.ModeOfTransports
{
  class Ship : Transport {
    public override string deliver() {
      return $"Delivered in Ship";
    }
  }
}
