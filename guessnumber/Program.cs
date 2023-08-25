int theNumber = new Random().Next(20);

Console.WriteLine("let's guess the number between 0-20");
Console.WriteLine("type -1 to exit");

string input = "";

while (input != "-1") {
    int num;
    input = Console.ReadLine();

    if (input == "-1") {
        Console.WriteLine($"it is {theNumber}");
        break;
    }

    if (Int32.TryParse(input, out num)) {
        if (num == theNumber) {
            Console.WriteLine("correct!");
            input = "-1";
        } else {
            Console.WriteLine("{0}", num > theNumber ? "lower": "higher");
        }
    } else {
        Console.WriteLine("please enter a number only");
    }

}