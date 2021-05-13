namespace design_patterns.Bridge.New
{
    abstract class Shape {

      private Color _color;
      private string _shape;
      protected Shape(Color color, string shape)
      {
          _shape = shape;
          _color = color;
      }
      public string getShape() {
        return _shape;
      }
      public string getColor() {
        return _color.getColor();
      }
    }
}