using design_patterns.Abstract_Factory.Controls;

namespace design_patterns.Abstract_Factory.Factories
{
  class MacFactory : IGUIFactory
  {
    public Button createButton()
    {
      return new MacButton();
    }

    public Checkbox createCheckbox()
    {
      return new MacCheckBox();
    }
  }
}