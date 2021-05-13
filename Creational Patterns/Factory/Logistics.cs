using design_patterns.Factory.ModeOfTransports;

namespace design_patterns.Factory
{
  abstract class Logistics {

    public abstract Transport createTransport();
       
    public string planDelivery() {
      return "Let's deliver";
    }
    
  }
}
