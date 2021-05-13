using System;
using System.Collections.Generic;

namespace design_patterns.Decorator
{
    class ClientUsingDecorator  {

    public void doSomething() {
      
      var message = "hello world";

      var emailNotifer = new EmailNotifer();
      var facebookNotifer = new FacebookDecorator(emailNotifer);
      var slackNotifier = new SlackDecorator(facebookNotifer);

      slackNotifier.sendMessage(message);
    }
  }
}