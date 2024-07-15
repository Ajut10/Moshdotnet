using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduction(string to)
        {
            Console.WriteLine("Hi {0}, I'm {1}",to,Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.Name = "Ajut";
            //person.Introduction("Mosh");

            //var person = new Person();
            var p = Person.Parse("fass");
            p.Introduction("Mosh");
        }
    }
}
