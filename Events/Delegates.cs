using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Events
{
    public delegate int Del1(int a,int b);
    
    public class Delegates
    {
        public int a = 2, b = 3;
        public Del1 d1 = ( a, b)=> a+b;


        public Func<int,int> a1  = (a) => a+10;


        public Action<string, int> a2 = (b1, b2) => Console.WriteLine(b1 + b2 + "");


        public Del1 d2 = (a, b) =>
        {
            int c = a + b;
            Console.WriteLine(c);
            return c;
        };


        List<Employee> list = new List<Employee>();

        public void Add(Employee e)
        {
            list.Add(e);
        }

        public static bool Search(Employee e)
        {
            if (e.Name == "vamshi")
                return true;
            else
            {
                return false;
            }
         
        }

        public Predicate<Employee> searchPredicate = new Predicate<Employee>(Search);


        public void Find()
        {
           Employee eee =  list.Find(searchPredicate);
        }

        public static int Add(int a, int b)
        {
            return a + b;

            

        }
    }

    public class Employee
    {

        public Employee(string name , string id )
        {
            Name = name;
            Id = id;

        }




        public string Name { get; set; }
        public string Id { get; set; }
    }
}