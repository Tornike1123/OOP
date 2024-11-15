// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace OOP.Generics
// {
//     public class GenericsExample
//     {
//         public class DataHolder<T>
//         {
//             private T data;

//             public void SetData(T value)
//             {
//                 data = value;
//             }

//             public T GetData()
//             {
//                 return data;
//             }
//         }

//         public static void Main(string[] args)
//         {
//             var intHolder = new DataHolder<int>();
//             intHolder.SetData(100);
//             Console.WriteLine(intHolder.GetData()); // 100

//             var stringHolder = new DataHolder<string>();
//             stringHolder.SetData("Hello, World!");
//             Console.WriteLine(stringHolder.GetData()); // Hello, World!
//         }
//     }
// }

//Type-independent (ტიპზე დამოუკიდებელი) კოდი C#-ში არის პროგრამირების მიდგომა, რომელიც გვაძლევს საშუალებას, შევქმნათ უნივერსალური ლოგიკა, რომელიც მუშაობს ნებისმიერ მონაცემთა ტიპთან. Generics არის სწორედ ის მექანიზმი, რომელიც ამის საშუალებას იძლევა.


