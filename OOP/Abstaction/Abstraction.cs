// using System;

// namespace AbstractionExample
// {
//     // აბსტრაქტული კლასი Vehicle
//     public abstract class Vehicle
//     {
//         public abstract void StartEngine(); // აბსტრაქტული მეთოდი (განუსაზღვრელი)
//         public abstract void Fly(); // აბსტრაქტული მეთოდი (განუსაზღვრელი)

//         public void StopEngine() // უკვე განსაზღვრული მეთოდი ჩვეულებრივი ანუ(არააბსტრაქტული- ეს მაგალითისთვის)
//         {
//             Console.WriteLine("Car Engine stopped.");
//         }
//     }

//     public class Car : Vehicle
//     {
//         public override void StartEngine() //override საშუალებას გვაძლევს, შევცვალოთ მშობელ კლასში განსაზღვრული ლოგიკა მემკვიდრე კლასის საჭიროებისამებრ.(abstract-კლასისთვის)
//         {
//             Console.WriteLine("Car engine started.");
//         }
//         public override void Fly() //override .(abstract-კლასისთვის)
//         {
//             Console.WriteLine("Car Cannot Fly.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Vehicle myCar = new Car();
//             myCar.StartEngine();
//             myCar.StopEngine();
//             myCar.Fly();
//             Console.ReadLine(); // შეაჩერებს პროგრამის დახურვას
//         }
//     }
// }

