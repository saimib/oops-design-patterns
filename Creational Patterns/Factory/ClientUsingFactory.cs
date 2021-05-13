using System;
using design_patterns.Factory.ModeOfTransports;

namespace design_patterns.Factory
{
    class ClientUsingFactory {
      public void doSomething(){

        Console.WriteLine("Factory Method");
        Console.WriteLine("-----------------------------------------------");

        Transport transport = null;
        var configuration = "Road";

        Logistics logistics = null;

        if (configuration == "Road") {
            logistics = new RoadLogistics();
        } else {
            logistics = new SeaLogistics();
        }

        transport = logistics.createTransport();

        Console.WriteLine(logistics.planDelivery());

        Console.WriteLine(transport.deliver());

        Console.WriteLine("-----------------------------------------------");
      }
    }
}