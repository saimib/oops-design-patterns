using System;

namespace design_patterns.Iterator
{
    class ClientUsingIterator {
      public void doSomething() {

        Console.WriteLine("Iterator Pattern");
        Console.WriteLine("------------------------------------------------------");

        var collection = new BoxCollection();

        for (int i = 0; i < 10; i++)
        {
            collection.Add(i.ToString());
        }

        var iterator = collection.GetIterator();

        while(iterator.HasMore()){
          Console.WriteLine($"The current item inside the collection is {iterator.GetNext()}");
        }

        Console.WriteLine("------------------------------------------------------");
      }
    }
}