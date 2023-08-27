using Defining;

Book b1 = new Book("War and Peace", "Leo Tolstory", 825);
Book b2 = new Book("The Odyssee", "Homer", 1025);

Console.WriteLine(b1.GetDescription());
Console.WriteLine(b2.GetDescription());

// this is not going to work
// b1._name = "something else";