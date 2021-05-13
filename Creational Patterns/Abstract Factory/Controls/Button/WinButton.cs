using System;

namespace design_patterns.Abstract_Factory.Controls
{
    class WinButton: Button {
      public override void Click() {
        Console.WriteLine("Windows button clicked");
      }
    }
}