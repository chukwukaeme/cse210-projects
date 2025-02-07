
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random = new Random();

        // Constructor: Initializes the scripture with reference and text
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        // Hide a given number of random words
        public void HideRandomWords(int numberToHide)
        {
            List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

            if (visibleWords.Count > 0)
            {
                for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
                {
                    int index = _random.Next(visibleWords.Count);
                    visibleWords[index].Hide();
                    visibleWords.RemoveAt(index); // Remove from list to avoid selecting again
                }
            }
        }

        // Get scripture display text with hidden words
        public string GetDisplayText()
        {
            string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
            return $"{_reference.GetDisplayText()} {scriptureText}";
        }

        // Check if all words are hidden
        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }

