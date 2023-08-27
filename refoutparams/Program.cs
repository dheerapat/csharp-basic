using System.Reflection.Metadata.Ecma335;

class Program
{
    static void TestFunc1(int arg1)
    {
        arg1 += 10;
        Console.WriteLine($"{arg1}");
    }

    static void TestFunc2(ref int arg1)
    {
        arg1 += 10;
        Console.WriteLine($"{arg1}");
    }

    static void PlusTime(int arg1, int arg2, out int sum, out int product) {
        sum = arg1 + arg2;
        product = arg1 * arg2;
    }

    static void Main(string[] args)
    {
        int val1 = 10;
        int val2 = 20;

        // this function doesn't change val1 externally
        TestFunc1(val1);
        Console.WriteLine($"{val1}");

        // this function change val1 externally
        TestFunc2(ref val1);
        Console.WriteLine($"{val1}");

        int a, b;
        PlusTime(val1, val2, out a, out b);
        Console.WriteLine("{0} {1}", a, b);
    }
}