(int a, int b) tuple1 = (5, 10);
var tuple2 = ("some txt", 10.5f);

tuple1.b = 20;
tuple2.Item1 = "new text";

Console.WriteLine($"{tuple1.a}, {tuple1.b}");
Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}");

static (int, int) PlusTime(int a, int b) {
    return (a + b, a * b);
}

var result = PlusTime(6, 12);

Console.WriteLine($"{result.Item1}, {result.Item2}");