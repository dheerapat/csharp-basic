using System.Globalization;

string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

int targetNum = 0;
try {
    targetNum = int.Parse(numStr1);
    Console.WriteLine(targetNum);

    // work only floating point with .00
    targetNum = int.Parse(numStr2, NumberStyles.Float);
    Console.WriteLine(targetNum);

    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);

    targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);

    Console.WriteLine($"{bool.Parse("TRUE")}");
    Console.WriteLine($"{float.Parse("3.1468"):F2}");

} catch (Exception e) {
    Console.WriteLine(e.Message);
}

bool succeed = false;
succeed = Int32.TryParse(numStr1, out targetNum);
if (succeed) {
    Console.WriteLine(targetNum);
}