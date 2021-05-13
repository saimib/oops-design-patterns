namespace design_patterns.Bridge.Old
{
    abstract class Shape {

      private string _color;
      private string _shape;
      protected Shape(string shape, string color)
      {
          _shape = shape;
          _color = color;
      }
      public string getShape() {
        return _shape;
      }
      public string getColor() {
        return _color;
      }
    }
}