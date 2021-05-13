using System;
namespace design_patterns.Singleton
{
    class ClientUsingSingleton
    {
        public void doSomething() {

          Console.WriteLine("Singleton Pattern");
          Console.WriteLine("------------------------------------------------");

          Database database = Database.getInstance();
          database.WriteData("Opening first connection");
          database.WriteData("Opening Second Connection");
          Console.WriteLine($"Number of open connections : {database.GetNumberOfConnections()}");

          Database databaseCopy = Database.getInstance();
          database.WriteData("Opening a new connection");
          Console.WriteLine($"Number of open connections : {database.GetNumberOfConnections()}");

          Console.WriteLine("------------------------------------------------");
        }
    }
}