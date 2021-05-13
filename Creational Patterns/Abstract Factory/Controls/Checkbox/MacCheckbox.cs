using System;

namespace design_patterns.Abstract_Factory.Controls
{
    class MacCheckBox: Checkbox {
      public override void Checked() {
        Console.WriteLine("Mac checkbox checked");
      }
    }
}