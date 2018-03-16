using System;
using System.Security.Cryptography.X509Certificates;

namespace Events
{
    public class IronMan
    {
        public IronMan(AvengersEvent avengersEvent)
        {
            avengersEvent.Task +=Decision;
        }


        public void Decision(string target)
        {
            Console.WriteLine("IronMan : Its time to party !!");
        }
    }
}


            