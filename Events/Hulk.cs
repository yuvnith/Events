using System;

namespace Events
{
    public class Hulk
    {
        public Hulk(AvengersEvent avengersEvent)
        {
            avengersEvent.Task += new Avengers(Reply);
        }


        public void Reply(string target)
        {
            Console.WriteLine("Hulk is ready to smash !!");
        }
    }
}