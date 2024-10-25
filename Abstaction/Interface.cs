// using System;

// namespace OOP.Abstraction
// {
//     public interface Interface //Interface ეს უბრალოდ სახელია
//     {
//         void Start();
//         void Stop();
//         void Fly();
//     }
//     // Bicycle კლასი, რომელიც ახორციელებს Interface-ის იმპლემენტაციას
//     public class Bicycle : Interface
//     {
//         public void Start()
//         {
//             Console.WriteLine("Bicycle started.");
//         }

//         public void Stop()
//         {
//             Console.WriteLine("Bicycle stopped.");
//         }
        
//         public void Fly()
//         {
//             Console.WriteLine("Bicycle Cannot fly.");
//         }

//     }
//     // Helicopter კლასი, რომელიც ახორციელებს Interface-ის იმპლემენტაციას
    
//     public class Helicopter : Interface
//     {
//         public void Start()
//         {
//             Console.WriteLine("Helicopter started.");
//         }

//         public void Stop()
//         {
//             Console.WriteLine("Helicopter stopped.");
//         }
        
//         public void Fly()
//         {
//             Console.WriteLine("Helicopter Can fly.");
//         }

//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Bicycle ობიექტის შექმნა და ინტერფეისით მისი მოხმობა
//             Interface myBicycle = new Bicycle();
//             myBicycle.Start();
//             myBicycle.Stop();
//             myBicycle.Fly();

//             // Helicopter ობიექტის შექმნა და ინტერფეისით მისი მოხმობა\
//             Interface myHelicopter = new Helicopter();  
//             myHelicopter.Start();
//             myHelicopter.Stop();
//             myHelicopter.Fly();

//             Console.ReadLine(); // შეაჩერებს პროგრამის დახურვას


//         }
//     }
// }
