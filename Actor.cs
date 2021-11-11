using System;
using System.Collections.Generic;
using System.Text;
using Akka.Actor;

namespace project_example_1
{
    class Actor : ReceiveActor
    {
        public Actor()
        {
            Receive<Message>(x => Console.WriteLine("Actor received message: {0}",x.Poruka));
        }
    }
}
