internal class Program
{
    static void Main(string[] args)
    {
        int a, b, c, min, max;
        Console.Write("a= ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c= ");
        c = Convert.ToInt32(Console.ReadLine());

        min = FindMin(a, b, c);
        max = FindMax(a, b, c);

        Console.WriteLine($"Минимальное число: {min}");
        Console.WriteLine($"Максимальное число: {max}");

        Console.WriteLine($"Число {a} {(IsEven(a) ? "четное" : "нечетное")}");
        Console.WriteLine($"Число {b} {(IsEven(b) ? "четное" : "нечетное")}");
        Console.WriteLine($"Число {c} {(IsEven(c) ? "четное" : "нечетное")}");

        Console.WriteLine($"Сумма чисел: {Sum(a, b, c)}");
        Console.WriteLine($"Произведение чисел: {Multiply(a, b, c)}");
    }

    static int FindMin(int x, int y, int z)
    {
        return x < y ? (x < z ? x : z) : (y < z ? y : z);
    }

    static int FindMax(int x, int y, int z)
    {
        return x > y ? (x > z ? x : z) : (y > z ? y : z);
    }

    static bool IsEven(int x)
    {
        return x % 2 == 0;
    }

    static int Sum(int x, int y, int z)
    {
        return x + y + z;
    }

    static int Multiply(int x, int y, int z)
    {
        return x * y * z;
    }
}
