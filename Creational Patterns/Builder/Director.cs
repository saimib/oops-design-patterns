using design_patterns.Builder.Products;

namespace design_patterns.Builder.Builders
{
  class Director
  {
    public void makeCar(IBuilder builder)
    {
      builder.setEngine();
      builder.setGPS();
      builder.setSeats();
      builder.setTripComputer();
    }

    public void makeCarManual(IBuilder builder)
    {
      builder.setGPS();
      builder.setSeats();
      builder.setEngine();
      builder.setTripComputer();
    }
  }
}