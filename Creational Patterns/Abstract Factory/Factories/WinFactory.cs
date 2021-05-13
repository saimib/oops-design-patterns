using design_patterns.Abstract_Factory.Controls;

namespace design_patterns.Abstract_Factory.Factories
{
  class WinFactory : IGUIFactory
  {
    public Button createButton()
    {
      return new WinButton();
    }

    public Checkbox createCheckbox()
    {
      return new WinCheckbox();
    }
  }
}