namespace Modifier
{
    class Book
    {
        // this is bad practice
        public string _name;
        protected string _author;
        private int _pagecount;

        public Book(string name, string author, int pagecount)
        {
            _name = name;
            _author = author;
            _pagecount = pagecount;
        }

        public string GetDescription() {
            return $"{_name} by {_author}";
        }

        public string GetName() {
            return _name;
        }

        // this is more best practice
        public void SetName(string name) {
            _name = name;
        }

        public void SetAuthor(string author) {
            _author = author;
        }

        public void SetPageCount(int pagecount) {
            _pagecount = pagecount;
        }
    }
}