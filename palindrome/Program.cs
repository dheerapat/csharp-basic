using System.Text;

static string Striping(string Str)
{
    Str = Str.ToLower();

    var NewStr = new StringBuilder();

    foreach (char C in Str)
    {
        if (!char.IsPunctuation(C) && !char.IsWhiteSpace(C))
        {
            NewStr.Append(C);
        }
    }

    return NewStr.ToString();
}

static (bool, int) IsPalindrome(string palindrome)
{
    var testStr = Striping(palindrome);

    var reverseStr = new StringBuilder();

    for (var i = testStr.Length - 1; i >= 0; i--)
    {
        reverseStr.Append(testStr[i]);
    }

    if (reverseStr.ToString() == testStr)
    {
        return (true, testStr.Length);
    }
    else
    {
        return (false, 0);
    }
}

Console.WriteLine("let's begin:");

var exit = false;

while (!exit)
{
    var palindrome = Console.ReadLine();

    if (palindrome == "exit")
    {
        exit = true;
    }
    else
    {
        var result = IsPalindrome(palindrome);
        Console.WriteLine("Palndrome: {0}, Length: {1}", result.Item1, result.Item2);
    }

}