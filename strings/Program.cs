string outStr;
string str1 = "The quick brown fox jumps over the lazy dog";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

Console.WriteLine(str1.Length);

Console.WriteLine(str1[14]);

foreach (char ch in str1)
{
    Console.Write(ch);
    if (ch == 'b') {
        Console.WriteLine();
        break;
    }
}

outStr = String.Concat(strs);
Console.WriteLine(outStr);

outStr = String.Join('.', strs);
Console.WriteLine(outStr);

int result = String.Compare(str2, "This is a string");
Console.WriteLine(result);

bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("the"));

outStr = str1.Replace("fox", "cat");
Console.WriteLine(outStr);
Console.WriteLine(outStr.IndexOf("fox"));