using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Events
{


    class Program
    {
        static void Main(string[] args)
        {
            //AvengersEvent avengersEvent = new AvengersEvent();
            //Loki loki = new Loki(avengersEvent);
            //IronMan ironMan = new IronMan(avengersEvent);
            //Hulk hulk = new Hulk(avengersEvent);




            //bool flag = true;
            //while (flag)
            //{
            //    Console.Write("enter villain : ");
            //    string v = Console.ReadLine();

            //    if (v != "exit")
            //    {
            //        avengersEvent.OnTask(v);
            //        Console.WriteLine("------------------------------");
            //    }

            //    else
            //        flag = false;
            //}




            //IplEvent iplEvent = new IplEvent();
            //Australia australis = new Australia(iplEvent);
            //Pakistan pakistan = new Pakistan(iplEvent);

            //iplEvent.OnIpl();


            Delegates delegates = new Delegates();
            Console.WriteLine(delegates.d1(2, 3));
            Console.WriteLine(delegates.a1(2));
            delegates.a2("hello", 2);
            Console.WriteLine(delegates.d2(2, 4));




            Employee e1 = new Employee("vamshi", "01");
            Employee e2 = new Employee("krishna", "02");

            delegates.Add(e1);
            delegates.Add(e2);


            delegates.Find();


            Console.ReadKey();

        }


    }
}
