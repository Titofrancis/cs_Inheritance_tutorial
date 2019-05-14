using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("All animals Eat");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Bark();
            objDog.Eat();

            Console.WriteLine("//////////////////////////////////////////////////////");

            Cat objCat = new Cat();
            objCat.Meow();
            objCat.Eat();
        }
    }
}
