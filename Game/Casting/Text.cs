namespace Cowboy.Game.Casting {
    public class Text {

        //initialize string for value, string for font file, an int for size, and a color for color
        private string value_;
        private string fontFile_;
        private int size_;
        private int alignment_;
        private Color color_;
        //constructor
        public Text(string value, string font, int size, int alignment_, Color color) {
            this.value_ = value;
            this.fontFile_ = font;
            this.size_ = size;
            this.alignment_ = alignment_;
            this.color_ = color;
        }

        //get and set methods
        public string GetValue() {
            return value_;
        }
        public void SetValue(string value) {
            this.value_ = value;
        }
        public string GetFontFile() {
            return fontFile_;
        }
        public int GetSize() {
            return size_;
        }
        public Color GetColor() {
            return color_;
        }
        public int GetAlignment() {
            return alignment_;
        }

    }
}