using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07Exercises1
{
    class Animal
    {
        private string strCountry;
        public string Country
        {
            get { return strCountry; }
        }
        public Animal(string strCountry)
        {
            this.strCountry = strCountry;
        }
    }
    class Cat : Animal
    {
        public string strSpecies;
        private int intNumber;
        public int Number //e
        {
            get { return intNumber; }
        }
        public Cat(string strSpecies, int intNumber, string strCountry) : base(strCountry)
        {
            this.strSpecies = strSpecies;
            this.intNumber = intNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat objCat;
            Console.WriteLine("Enter the Country: ");
            string Country = Console.ReadLine();
            Console.WriteLine("Enter the Species: ");
            string Species = Console.ReadLine();
            Console.WriteLine("Enter the Number: ");
            int Number = int.Parse(Console.ReadLine());
            objCat = new Cat(Species, Number, Country);
            Console.WriteLine("Country: {0}\nSpecies: {1}\nNumber: "+ objCat.Number, objCat.strSpecies, objCat.Country);
            Console.ReadKey();
        }
    }
}
