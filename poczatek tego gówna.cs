using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Pracownik
    {
        public string name = Console.ReadLine();
        public int age = Convert.ToInt32(Console.ReadLine());
        public float wage = Convert.ToSingle(Console.ReadLine());
        public void wiek()
        {
            if(age >= 65)
            {
                Console.WriteLine("Powinnien przejść na emeryturę.");
            }
        }
        public void podwyzka()
        {
            Console.WriteLine("Chcę podwyżkę! " + wage);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}