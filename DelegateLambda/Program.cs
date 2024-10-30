namespace DelegateLambda
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<Person> people = new List<Person> {
             new Person{Name ="Kamil",Surname ="Zamanov",Age = 90},
             new Person{Name="Miriyusif",Surname="Kazimov",Age=45},
             new Person{Name="Humay",Surname="Rahimova",Age=2},
             new Person{Name="Said",Surname="Yunuslu",Age=11},
             new Person{Name="Arzu",Surname="Bayramli",Age=20}

            };
            List<Person> IsKamilHere = people.FindAll(p => p.Name == "Kamil");
            Console.WriteLine("Kamil adinda telebe varmi?");
            if (IsKamilHere.Count > 0)
            {
                foreach (var person in IsKamilHere)
                {
                    Console.WriteLine($"Movcuddur:{person.Name}  {person.Surname}");
                }
            }
            else
            {
                Console.WriteLine("Bu adda telebe yoxdur");
            }
            List<Person> EndsWith = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            Console.WriteLine("\nSoyadi ov ve ya ova ile biten telebeler:");
            if (EndsWith.Count > 0)
            {
                foreach (var person1 in EndsWith)
                {
                    Console.WriteLine($"{person1.Name} {person1.Surname}");
                }
            }
            else
            {
                Console.WriteLine("Bu cur soyad movcud deyil");
            }
            List<Person> Findtwenties = people.FindAll(p => p.Age > 20);
            Console.WriteLine("\nYasi 20den boyuk olanlar:");
            if (Findtwenties.Count > 0)
            {
                foreach (Person human in Findtwenties)
                {
                    Console.WriteLine($"{human.Name}");
                }
            }
            else
            {
                Console.WriteLine("Bu yaslarda telebe yoxdur");
            }
        }
    }
}
