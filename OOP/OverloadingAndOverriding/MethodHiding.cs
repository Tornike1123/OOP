using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.OOP.OverloadingAndOverriding
{
    public class MethodHiding
    {
        class Animal
        {
            public void Speak()
            {
                Console.WriteLine("Animal Speaks");
            }
        }
        class Dog : Animal
        {
            public new void Speak()//new კლავიში აღნიშნავს, რომ ეს მეთოდი სრულიად ახალია და არ უკავშირდება მშობელი კლასის მეთოდს. (ანუ არ მოხდება გადაწერეა override)
            {
                Console.WriteLine("Woof");
            }
        }

    class Program
    {
         static void Main(string[] args)
        {
          Animal myAnimal = new Dog();
          myAnimal.Speak();
        //output "Animal speaks"
        }
    }
    }
}