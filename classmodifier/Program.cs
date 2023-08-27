using Modifier;

Book b1 = new Book("The Odyssy", "Homer", 1234);

b1._name = "1001 Night";

Console.WriteLine(b1.GetDescription());

b1.SetName("Tenet");
b1.SetAuthor("Nolan");
b1.SetPageCount(678);

Console.WriteLine(b1.GetDescription());