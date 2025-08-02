using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter side lengths of a triangle:");
        Console.Write("Side A: ");
        if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0) { Console.WriteLine("Invalid!"); return; }
        Console.Write("Side B: ");
        if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0) { Console.WriteLine("Invalid!"); return; }
        Console.Write("Side C: ");
        if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0) { Console.WriteLine("Invalid!"); return; }

      
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Not a triangle.");
            return;
        } 

        if (a == b && b == c)              Console.WriteLine("Equilateral triangle");
        else if (a == b || b == c || a == c) Console.WriteLine("Isosceles triangle");
        else                                 Console.WriteLine("Scalene triangle");
    }
}
