namespace Properties
{
    class Book
    {
        private string _name;
        private string _author;
        private int _pagecount;

        public Book(string name, string author, int pagecount)
        {
            _name = name;
            _author = author;
            _pagecount = pagecount;
        }

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public string Author {
            get => _author;
            set => _author = value;
        }

        public int PageCount {
            get => _pagecount;
            set => _pagecount = value;
        }

        // this is read-only (only get)
        public string Description {
            get => $"{Name} by {Author}, {PageCount} page";
        }

        // auto-generated properties
        public string ISBN {
            get; set;
        }

        public decimal Price {
            get; set;
        }
    }
}