using Inheritance;

Book b1 = new Book("War and Peace", "Leo", 825, 39.9m);
Magazine m1 = new Magazine("Playboy", "New York Times", 80, 4.9m);

Console.WriteLine($"{b1.Name}, {b1.Author}");
Console.WriteLine($"{m1.Name}, {m1.Publisher}");

// b1.Name = "";

Console.WriteLine(b1.GetDescription());
Console.WriteLine(b1.Price);
Console.WriteLine(m1.GetDescription());
Console.WriteLine(m1.Price);