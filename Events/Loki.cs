using System;

namespace Events
{
    public class Loki
    {
        public Loki(AvengersEvent avengersEvent)
        {
            avengersEvent.Task += new Avengers(Answer);
        }


        public void Answer(string target)
        {
            Console.Write("Loki : ");
            if(target =="thanos")
                Console.WriteLine("sorry cannot be a part of the team !!");
            else
                Console.WriteLine("Ready to betray you");
        }
    }
}