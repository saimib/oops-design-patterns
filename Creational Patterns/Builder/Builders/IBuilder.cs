namespace design_patterns.Builder.Builders
{
    interface IBuilder {
      void reset();
      void setSeats();
      void setEngine();
      void setTripComputer();
      void setGPS();
    }
}