namespace Personen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aufabe

            //Erstelle ein Programm in dem ein User sein Namen eingeben kann
            //Erstelle zu dem eine Klasse "Person" mit den Feldern: Name, Alter & Beruf
            //Die Klasse hat zu dem auch zwei Methoden : <Begrüßung> mit {Name} + Vorstellung, <Info> mit {name} {alter} {Beruf} über das Objekt"Person"
            //Erstelle aus der Klasse Person zwei Objekte mit vordefinierten Felder
            //Erstelle ein Menü wo man auf jedes Objekt zugreifen kann und die Methode zugreiffen kann(Begrüßung und Info)
            Person person1 = new Person("Fritz", 39, "KFZ");
            Person person2 = new Person("Gustav", 44, "Arbeitslos");
            bool wiederholung = true;
            Console.WriteLine("Hallo User, Bitte gib dein Namen an:");
            string name = Console.ReadLine();
            Console.WriteLine("Bitte gib dein Alter an:");
            int alter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib dein Beruf an:");
            string beruf = Console.ReadLine();
            Person neu = new Person(name, alter, beruf);

            while (wiederholung)
            {
                Console.Clear();
                Console.WriteLine("Wähle aus den folgenden Menüpunkten:\n\t-> Begrüssung <-\n\t-> Vorstellung <-\n\t-> Beenden <-");
                string menü = Console.ReadLine().ToLower().Trim();
                if (menü == "begrüssung")
                {
                    bool wiederholen = true;
                    while (wiederholen)
                    {
                        Console.Clear();
                        Console.WriteLine($"Wähle eine Person aus:\n\n1.{person1.name}\n2.{person2.name}\n3.{neu.name}\nZurück");
                        string eingabe = Console.ReadLine();
                        if (eingabe == "1")
                        {
                            Console.Clear() ;
                            person1.Begrüssung();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            Console.ReadKey();
                        }
                        else if (eingabe == "2")
                        {
                            Console.Clear();
                            person2.Begrüssung();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            Console.ReadKey();
                        }
                        else if (eingabe == "3")
                        {
                            Console.Clear();
                            neu.Begrüssung();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            wiederholen = false;
                        }
                    }
                    Console.Clear() ;
                    Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                    Console.ReadKey();
                }
                else if (menü == "vorstellung")
                {
                    bool wiederholen = true;
                    while (wiederholen)
                    {
                        Console.Clear();
                        Console.WriteLine($"Wähle eine Person aus:\n\n-> 1.{person1.name} <-\n-> 2.{person2.name} <-\n-> 3.{neu.name} <-\n\nZurück");
                        string eingabe = Console.ReadLine();
                        if (eingabe == "1")
                        {
                            person1.info();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            Console.ReadKey();
                        }
                        else if (eingabe == "2")
                        {
                            person2.info();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            Console.ReadKey();
                        }
                        else if (eingabe == "3")
                        {
                            neu.info();
                            Console.WriteLine("\n\n\nDrücke eine belibige Taste zum fortfahren");
                            Console.ReadKey();
                        }
                        else
                        {
                            wiederholen = false;
                        }
                    }
                }
                else if (menü == "beenden")
                {
                    Console.WriteLine("Das Programm wird Beendet");
                    wiederholung = false;
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Error 404");
                    wiederholung = false;
                    Console.ReadKey();
                }
            }
        }
    }
}
