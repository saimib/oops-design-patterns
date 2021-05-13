using System;

namespace design_patterns.Decorator
{
    class FacebookDecorator : BaseDecorator {

      public FacebookDecorator(INotifier notifier) : base(notifier)
      {
      }
      public override void sendMessage(string data) {
        base.sendMessage(data);
        Console.WriteLine($"{data} is sent using Facebook");
      }
    }
}