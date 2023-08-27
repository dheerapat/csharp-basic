void PrintWithPrefix(string theStr, string prefix = "") {
    Console.WriteLine($"{prefix} {theStr}");
}

PrintWithPrefix("Hello");
PrintWithPrefix("Hello", "this is a test:");

PrintWithPrefix(prefix: "Booo", theStr: "Bahhhh");