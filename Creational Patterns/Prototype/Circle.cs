namespace design_patterns.prototype
{
  class Circle : Shape
  {
    private int radius;

    public Circle(int _radius) {
      this.radius = _radius;
      
    }
    public Circle(Circle source) : base(source) {
      this.radius = source.radius;
    }
    public override Shape clone()
    {
      return new Circle(this);
    }

    public override string WhoAmI()
    {
      return $"I am a circle, my radius is {this.radius} at the position {this.x},{this.y}";
    }
  }
}