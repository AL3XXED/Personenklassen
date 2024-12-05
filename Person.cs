using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Personen
{
    internal class Person
    {
        public string name;
        public int alter;
        public string beruf;
        public Person(string _name, int _alter, string _berufe) 
        {
            name = _name;
            alter = _alter;
            beruf = _berufe;
        }
        public void Begrüssung()
        {
            Console.WriteLine($"Willkomen {name}, Schön dich kennenzulernen.");
        }
        public void info()
        {
            Console.WriteLine($"Ich heiße {name}, bin {alter} Jahre alt und arbeite als {beruf}.");
        }
    }
}
