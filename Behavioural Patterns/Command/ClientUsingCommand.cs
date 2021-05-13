using System;

namespace design_patterns.Command
{
    class ClientUsingCommand {
      public void doSomething() {

        Console.WriteLine("Command Pattern");
        Console.WriteLine("------------------------------------------------------");

        var application = new Application();

        // Customer Selects and Adds an Items to cart
        application.SelectItem("Phone");
        application.executeCommand(new AddItemCommand(application));

        // Customer Selects another Item and adds to the cart
        application.SelectItem("Charger");
        application.executeCommand(new AddItemCommand(application));

        // Customer Wants to delete an Item
        application.SelectItem("Phone");
        application.executeCommand(new DeleteItemCommand(application));

        // Customer Selects another Item and adds to the cart
        application.SelectItem("Cover");
        application.executeCommand(new AddItemCommand(application));

        // Customer wants to checkout 
        // This should be a single transaction
        application.executeCommand(new CheckoutCommand(application));
        // The transaction fails and we have to undo
        application.Undo();

        application.ShowCart();


        Console.WriteLine("------------------------------------------------------");
      }
    }
}