using design_patterns.Abstract_Factory.Controls;

namespace design_patterns.Abstract_Factory.Factories
{
  interface IGUIFactory {
    Button createButton();
    Checkbox createCheckbox();
  }
}