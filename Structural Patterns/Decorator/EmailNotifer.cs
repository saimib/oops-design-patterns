using System;

namespace design_patterns.Decorator
{
    class EmailNotifer : INotifier {
      public void sendMessage(string data) {
        Console.WriteLine($"{data} sent using EMail");
      }
    }
}