using StringRep;

int x = 1000;
Console.WriteLine(x.ToString());

Object a = new object();
Console.WriteLine(a.ToString());

Book b1 = new Book("War and Peace", "Leo", 826);
Console.WriteLine(b1.ToString());
Console.WriteLine(b1);
Console.WriteLine(b1.ToString('B'));
Console.WriteLine(b1.ToString('F'));