
    public class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor
        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        // Hide the word by marking it as hidden
        public void Hide()
        {
            _isHidden = true;
        }

        // Show the word by marking it as visible
        public void Show()
        {
            _isHidden = false;
        }

        // Check if the word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Get display text: Hidden words show as underscores
        public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }
