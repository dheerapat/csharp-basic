// function that return float value
float MilesToKm(float miles) {
    float result = miles * 1.6f;
    return result;
}

Console.WriteLine($"the result is {MilesToKm(8.0f)} km");

void PrintWithPrefix(string theStr) {
    Console.WriteLine($"::> {theStr}");
}

PrintWithPrefix("hello");