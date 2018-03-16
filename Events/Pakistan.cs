using System;

namespace Events
{
    public class Pakistan
    {
        
        public Pakistan(IplEvent iplEvent)
        {
            iplEvent.Ipl += new invitation(Reply);

        }
        public void Reply(string message)
        {
            Console.WriteLine("Pak : I know we are not allowed, its a prank :(");
        }
    }
}