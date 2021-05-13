using design_patterns.Abstract_Factory.Controls;
using design_patterns.Abstract_Factory.Factories;

namespace design_patterns.Abstract_Factory
{
    class Application {
      private IGUIFactory _factory;
      private Button _button;
      private Checkbox _checkbox;

      public Application(IGUIFactory factory)
      {
          this._factory = factory;
      }

      public void CreateUI() {
        this._button = this._factory.createButton();
        this._checkbox = this._factory.createCheckbox();
      }

      public void Paint() {
        this._button.Click();
        this._checkbox.Checked();
      }
    }
}