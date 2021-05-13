
namespace design_patterns.prototype
{
  abstract class Shape {
    public int x;
    public int y;
    public string color;

    protected Shape() {

    }

    protected Shape(Shape source) {
      this.x = source.x;
      this.y = source.y;
      this.color = source.color;
    }

    public abstract Shape clone();

    public abstract string WhoAmI();
  }  
}