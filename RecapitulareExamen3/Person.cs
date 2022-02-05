using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapitulareExamen3
{
    public class Person
    {
        public Person(string Nume, string Prenume)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
        }
          
        public string Nume;
        public string Prenume;
        public string nume {
            get { return this.Nume; }
            set { this.Nume = value ?? "Andrei"; }
        }
        
        public string prenume
        {
            get { return this.Prenume; }
            set { this.Prenume = value ?? "Daniel"; }
        }

        public void Print()
        {
            Console.WriteLine($"{this.nume} {this.prenume}");
        }

        public static void Print1(string text)
        {
            Console.WriteLine(text);
        }
    }
}
