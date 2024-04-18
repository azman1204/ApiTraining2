using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListDemo
    {
        // constructor
        public ListDemo() 
        {
            List<Person> list = new List<Person>();
            list.Add(new Person("John", 45));
            list.Add(new Person("Abu", 42));
            list.Add(new Person("Ali", 40));
            foreach (Person person in list)
            {
                Console.WriteLine($"name = {person.name}, age = {person.age}");
            }
        }
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }   
    }
}
