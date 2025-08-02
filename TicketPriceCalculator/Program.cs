using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
        {
            Console.WriteLine("Invalid age.");
            return;
        }
        Console.Write("Enter ticket base price (e.g. 100.00): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal basePrice) || basePrice <= 0)
        {
            Console.WriteLine("Invalid price.");
            return;
        }

        decimal finalPrice;
         if (age <= 12) finalPrice = basePrice - 7;
        else if (age >= 65) finalPrice = basePrice - 7;
        else finalPrice = basePrice;

        Console.WriteLine($"Final ticket price: GHC {finalPrice:F2}");
    }
}
