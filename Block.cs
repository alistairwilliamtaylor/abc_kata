    class Block 
    {
        public Block(char letter1, char letter2)
        {
            FirstLetter = letter1;
            SecondLetter = letter2;
        }

        private char FirstLetter;
        private char SecondLetter;

        public bool HasLetter(char letter)
        {
            return FirstLetter == letter || SecondLetter == letter ? true : false;
        }
    };