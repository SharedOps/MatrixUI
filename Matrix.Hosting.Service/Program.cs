using System;
using Akka.Actor;


namespace Matrix.Hosting.Service
{
    class Program
    {
        private static ActorSystem _actorSystem;

        static void Main(string[] args)
        {

            _actorSystem = ActorSystem.Create("MatrixUIActorSystem");

            Console.ReadLine();

            _actorSystem.Terminate();

        }
    }
}
