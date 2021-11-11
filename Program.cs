using System;
using Akka.Actor;

namespace project_example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("System1");
            var actor1 = system.ActorOf<Actor>("Actor1");
            var actor2 = system.ActorOf<Actor>("Actor2");

            actor1.Tell(new Message("Hello 1!"));
            actor2.Tell(new Message("Hello 2!"));


            Console.ReadLine();
        }
    }
}
