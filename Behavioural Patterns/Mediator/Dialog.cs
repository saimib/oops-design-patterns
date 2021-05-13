using System;

namespace design_patterns.Mediator
{
  class Dialog : IMediator
  {
    private Button _button;
    private TextBox _textBox;

    public Dialog()
    {
        _button = new Button(this);
        _textBox = new TextBox(this);
    }

    public void EnterTextAndSubmit(){
      _button.Click();
      _textBox.Click();
    }
    public void Notify(Component component, string action)
    {
      if (component.GetType() == typeof(Button)){
        Console.WriteLine($"There is a button click - {action}");
      }
      if (component.GetType() == typeof(TextBox)){
        Console.WriteLine($"There is a Text box click - {action}");
      }
    }
  }
}