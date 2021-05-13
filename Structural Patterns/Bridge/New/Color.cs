namespace design_patterns.Bridge.New
{
    abstract class Color {

      private string _color;
      protected Color(string color)
      {
          _color = color;
      }
      public string getColor() {
        return _color;
      }
    }
}