using System;
using System.Collections.Generic;

namespace design_patterns.Composite
{
    class ClientUsingComposite  {

    public void doSomething() {
      var mainbox = new Box();
      var boxone = new Box();
      var boxtwo = new Box();

      var cellphone = new Product();
      var charger = new Product();

      boxone.add(cellphone);
      boxtwo.add(charger);

      mainbox.add(boxone);
      mainbox.add(boxtwo);

      Console.WriteLine(mainbox.getTotal());
    }
  }
}