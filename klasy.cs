using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Pracownik
    {
        public static int Count = 0;
        public string name;
        public int age;
        public int wage;

        public Pracownik(string _name, int _age, int _wage)
        {
            name = _name;
            age = _age;
            wage = _wage;
            Count++;
        }

        public void Print()
        {
            Console.WriteLine("Imie: " + name);
            if (age >= 65)
            {
                Console.WriteLine("Wiek: " + age + " Powinnien iść na emeryturę");
            }
            else
            {
                Console.WriteLine("Wiek: " + age);
            }
        }
        void Podwyzka()
        {
            Console.WriteLine(wage + " Chcę podwyżkę!");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Pracownik[] array = new Pracownik[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Podaj imię pracownika: ");
                string name = Console.ReadLine();
                Console.WriteLine("Podaj wiek pracownika: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj pensję pracownika: ");
                int wage = Convert.ToInt32(Console.ReadLine());
                Pracownik Pracownik = new Pracownik(name, age, wage);
                array[i] = Pracownik;
            }
            Console.ReadKey();
        }
    }
}