using design_patterns.Adapter.Business;
using design_patterns.Adapter.Sql;
using System;

namespace design_patterns.Adapter {

  class ClientUsingAdapter {
    public void doSomething() {

      Console.WriteLine("Adapter Pattern");
      Console.WriteLine("-------------------------------------------");

      IDriver driver = new Driver();
      IDataSource dataSource = new DataSourceAdapter(driver);

      var truck = new Truck(dataSource);
      truck.deliver();

      Console.WriteLine("-------------------------------------------");
    }
  }

}