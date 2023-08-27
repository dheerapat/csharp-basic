using Properties;

Book b1 = new Book("Machu Pichu", "John Doe", 234);

Console.WriteLine(b1.Name);
Console.WriteLine(b1.Description);

b1.ISBN = "1234567890";
b1.Price = 99.99m;

Console.WriteLine(b1.ISBN);
Console.WriteLine(b1.Price);

b1.Name = "Alumbrah";
b1.Author = "Mohammad";
b1.PageCount = 345;

Console.WriteLine(b1.Description);