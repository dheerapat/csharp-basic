namespace StringRep
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get;set; }
        public int PageCount { get; }

        public Book(string name, string author, int page) {
            Name = name;
            Author = author;
            PageCount = page;
        }

        // every class has public virtual ToString() function
        public override string ToString()
        {
            return $"Book: {Name} by {Author}";
        }

        // overloading ToString()
        public string ToString(char format) {
            if (format == 'B') {
                return $"{Name}:{Author}";
            }
            if (format == 'F') {
                return $"Book: {Name} by {Author}, {PageCount} pages";
            }
            return ToString();
        }
    }
}