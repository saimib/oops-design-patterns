namespace design_patterns.prototype
{
  class Rectangle : Shape
  {

    private int width;
    private int height;

    public Rectangle(int _height, int _width) {
      this.height = _height;
      this.width = _width;
    }
    Rectangle(Rectangle source) : base(source) {
      this.width = source.width;
      this.height = source.height;
    }
    public override Shape clone()
    {
      return new Rectangle(this);
    }
    public override string WhoAmI()
    {
      return $"I am a rectangle, I am {this.height} tall and {this.width} wide at the position {this.x},{this.y}";
    }
  }
}