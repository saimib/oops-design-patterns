using System;

namespace design_patterns.Decorator
{
    class SlackDecorator : BaseDecorator {

      public SlackDecorator(INotifier notifier) : base(notifier)
      {
      }
      public override void sendMessage(string data) {
        base.sendMessage(data);
        Console.WriteLine($"{data} is sent using Slack");
      }
    }
}