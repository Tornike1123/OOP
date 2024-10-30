// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace OOP.AccessModificator
// {
//     class ProtectedModificator // Base class (მშობელი კლასი)
//     {
//         protected int number;
//         protected void display(){
//             Console.WriteLine("Protected method in BaseClass.");
//         }
//     }

//     class DerivedClass : ProtectedModificator
//     {
//         public void showDisplay()
//         {
//              // number ცვლადზე და Display() მეთოდზე წვდომა გვაქვს, რადგან ისინი protected არიან
//             number = 10;
//             display();
//             Console.WriteLine("number:" + number);
//         }
//     }

//      class Program
//     {
//         static void Main(string[] args)
//         {
//             DerivedClass derived = new DerivedClass();
//             derived.showDisplay(); // გამოიძახებს display() მეთოდს და number ცვლადს
//         }
//     }
// }