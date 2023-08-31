using Fraction;


class Program{

    static void Main(){
        Fraction f = new Fraction(40, 85);
        Console.WriteLine();
        f.Reduction();
        f.ShowFraction();
        Console.WriteLine();
        Console.WriteLine($"The sum of the numerator and denominator of the fraction : {f.Add()} ");
        Console.WriteLine($"The difference between the numerator and denominator of a fraction: {f.Substraction()} ");
        Console.WriteLine($"The product of the numerator and denominator of a fraction: {f.Mult()} ");
        Console.WriteLine($"The ratio of the numerator and denominator of the fraction: {f.Divide()} ");
        
        
    }
}


