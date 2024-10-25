// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace OOP.OOP.OverloadingAndOverriding
// {
//     public class Overriding
//     {
//         // მშობელი კლასი
// class Animal
// {
//     public virtual void Speak() //virtual: შვილ კლასს შეუძლია გადააწეროს
//     {
//         Console.WriteLine("Animal speaks");
//     }
// }

// // შვილი კლასი
// class Dog : Animal
// {
//     public override void Speak() //override: აღნიშნავს, რომ ეს მეთოდი გადააწერს Animal კლასში არსებულ Speak მეთოდს. ეს საჭიროებს, რომ Animal კლასში Speak მეთოდი იყოს virtual.
//     {
//         Console.WriteLine("Woof");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         // Overriding-ის გამოყენება
//         Animal myAnimal = new Dog();
//         myAnimal.Speak(); // Woof
//     }
// }

//     }
// }

// //Overriding: მშობელი კლასის მეთოდის ცვლილება შვილი კლასში.