namespace Events
{
    public  delegate void invitation(string message);
    public class IplEvent
    {
        public event invitation Ipl;



        public void OnIpl()
        {
            if (Ipl != null)
            {
                Ipl("Inviting you to join our premier league ");

            }
        }

    }
}