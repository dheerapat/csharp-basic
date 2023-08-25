string make = "Mercedes-Benz";
string model = "G Class";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

Console.WriteLine($"This is a {year} {make} {model}, with {miles:N2} miles and cost {price:C2}");
Console.WriteLine($"This is a {year} {make} {model}, with {{{miles * 1.6:N2}}} km and cost {price:C2}");