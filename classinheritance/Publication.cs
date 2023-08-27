namespace Inheritance
{
    class Publication
    {
        private string _name;

        public Publication(string name, int pagecount, decimal price) {
            _name = name;
            PageCount = pagecount;
            Price = price;
        }

        public int PageCount {
            get; set;
        }

        public decimal Price {
            get; set;
        }

        public string Name {
            get { return _name; }

            set {
                if (value == "") {
                    throw new ArgumentException("name can't be blank");
                }
                _name = value;
            }
        }

        // this can be overwritten by sub-classes
        public virtual string GetDescription() {
            return $"{Name}, {PageCount} page";
        }
    }
}