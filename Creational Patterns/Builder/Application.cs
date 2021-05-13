using design_patterns.Builder.Products;
using System;

namespace design_patterns.Builder.Builders
{
  class Application
  {
    public void createCarAndManual() {
      var director = new Director();
      CarBuilder builder = new CarBuilder();
      CarManualBuilder manualBuilder = new CarManualBuilder();

      director.makeCar(builder);
      director.makeCarManual(manualBuilder);
      Car car = builder.getResult();
      CarManual carManual = manualBuilder.getResult();

      Console.WriteLine(car.TypeOfComputer);
      Console.WriteLine(carManual.ComputerDescription);
    }
  }
}