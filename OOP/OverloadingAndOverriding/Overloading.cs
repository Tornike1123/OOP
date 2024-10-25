using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.OOP.OverloadingAndOverriding
{
    public class Overloading
    {
           // მეთოდი, რომელიც იღებს ორ int ტიპის არგუმენტს
    public int Add(int a, int b)
    {
        return a + b;
    }

    // მეთოდი, რომელიც იღებს ორ double ტიპის არგუმენტს
    public double Add(double a, double b)
    {
        return a + b;
    }
class Program
{
    static void Main(string[] args)
    {
        // Overloading-ის გამოყენება
        Overloading math = new Overloading();
        Console.WriteLine(math.Add(5, 10));       // 15
        Console.WriteLine(math.Add(5.5, 10.5));   // 16.0

    }
}
    }
}

//Overloading: ერთი და იგივე მეთოდის ბევრი ვერსია ერთ კლასში, განსხვავებული პარამეტრებით.