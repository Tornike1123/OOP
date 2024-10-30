// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace OOP.AccessModificator
// {
//     public class InternalModificator
//      {
//         internal int number; // ცვლადის დონის internal მოდიფიკატორი

//         internal void Display() // მეთოდის დონის internal მოდიფიკატორი
//         {
//             Console.WriteLine("This is an internal method.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             InternalModificator obj = new InternalModificator();
//             obj.number = 42;
//             obj.Display();
//             Console.WriteLine("Number: " + obj.number);
//         }
//     }
// }