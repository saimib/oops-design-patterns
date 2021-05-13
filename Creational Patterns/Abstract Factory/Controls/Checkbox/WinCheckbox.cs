using System;

namespace design_patterns.Abstract_Factory.Controls
{
    class WinCheckbox: Checkbox {
      public override void Checked() {
        Console.WriteLine("Windows checkbox checked");
      }
    }
}