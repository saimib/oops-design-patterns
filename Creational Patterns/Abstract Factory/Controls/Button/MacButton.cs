using System;

namespace design_patterns.Abstract_Factory.Controls
{
    class MacButton: Button {
      public override void Click() {
        Console.WriteLine("Mac button clicked");
      }
    }
}