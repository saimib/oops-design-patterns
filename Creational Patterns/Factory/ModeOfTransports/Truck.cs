namespace design_patterns.Factory.ModeOfTransports
{
  class Truck : Transport {

    public Truck(string name)
    {
        
    }
    public override string deliver() {
      return $"Delivered in truck";
    }
  }
}