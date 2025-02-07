
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        // Default constructor (Needed for constructor chaining)
        public Reference()
        {
            _book = "";
            _chapter = 0;
            _verse = 0;
            _endVerse = 0;
        }

        // Constructor for a single verse (calls multi-verse constructor)
        public Reference(string book, int chapter, int verse) 
            : this(book, chapter, verse, verse) // Calls the next constructor
        {
        }

        // Constructor for a range of verses
        public Reference(string book, int chapter, int startVerse, int endVerse) 
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            return _verse == _endVerse ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
