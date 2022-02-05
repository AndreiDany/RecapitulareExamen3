using System;

namespace RecapitulareExamen3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Andrei","Daniel");
            Console.WriteLine(person.Nume);
            person.Nume = "Dani";
            person.Print();
            Person.Print1("Hello!");

        }
    }
}
