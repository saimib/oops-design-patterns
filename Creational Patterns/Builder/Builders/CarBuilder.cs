using design_patterns.Builder.Products;

namespace design_patterns.Builder.Builders
{
  class CarBuilder : IBuilder
  {
    private Car _car;

    public CarBuilder()
    {
        this._car = new Car();
    }
    public void reset()
    {
      this._car = new Car();
    }

    public void setEngine()
    {
      this._car.NumberOfEngines = 2;
    }

    public void setGPS()
    {
      this._car.TypeOfGPS = "Not working";
    }

    public void setSeats()
    {
      this._car.NumberOfSeats = 4;
    }

    public void setTripComputer()
    {
      this._car.TypeOfComputer = "It's a Macbook";
    }

    public Car getResult() {
      return this._car;
    }
  }
}