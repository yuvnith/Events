using System;

namespace Events
{
    public class Australia 
    {

        public Australia(IplEvent iplEvent)
        {
            iplEvent.Ipl += new invitation(Reply);
        }



        public void Reply(string message)
        {
            Console.WriteLine("Australia : always ready mate !!");
        }
    }
}