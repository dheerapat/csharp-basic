using System.Text;

int jumpCount = 10;
string[] animals = {"goats", "cats", "pigs"};

StringBuilder sb = new StringBuilder("Initial string. ", 200);

Console.WriteLine($"capacity: {sb.Capacity}; length: {sb.Length}");

sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog. ");
sb.AppendLine();

sb.AppendFormat("He did this {0} time", jumpCount);
sb.AppendLine();

sb.Append("He also jumped over ");
sb.AppendJoin(", ", animals);

sb.Replace("fox", "cat");

sb.Insert(0, "This is the ");

Console.WriteLine($"capacity: {sb.Capacity}; length: {sb.Length}");
Console.WriteLine(sb.ToString());