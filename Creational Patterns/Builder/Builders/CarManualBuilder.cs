using design_patterns.Builder.Products;

namespace design_patterns.Builder.Builders
{
  class CarManualBuilder : IBuilder
  {
    private CarManual _carManual;

    public CarManualBuilder()
    {
        this._carManual = new CarManual();
    }
    public void reset()
    {
      this._carManual = new CarManual();
    }

    public void setEngine()
    {
      this._carManual.EngineDescription = "V8 Engine";
    }

    public void setGPS()
    {
      this._carManual.GPSDescription = "Not working";
    }

    public void setSeats()
    {
      this._carManual.SeatDescription = "Comfy seats";
    }

    public void setTripComputer()
    {
      this._carManual.ComputerDescription = "This Macbook has the new M1 chip";
    }

    public CarManual getResult() {
      return this._carManual;
    }
  }
}