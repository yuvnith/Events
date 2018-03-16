using System;

namespace Events
{
    public delegate void Avengers(string operation);
    public class AvengersEvent
    {
        private string _name;
        public string Name { get; set; }
        public event Avengers Task;


        public void OnTask(string _name)
        {

            if (Task != null)
            {
                Task(_name);
            }
        }
         
    }
}