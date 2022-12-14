namespace Cowboy.Game.Casting {
    public class Image {
        private string filename_;
        private double scale_;
        private int rotation_;

        //constructor
        public Image(string filename, double scale = 1.0, int rotation = 0) {
            this.filename_ = filename;
            this.scale_ = scale;
            this.rotation_ = rotation;
        }

        public string GetFilename() {
            return filename_;
        }


        public double GetScale() {
            return scale_;
        }

        public int GetRotation() {
            return rotation_;
        }

  
        public void SetScale(double scale) {
            this.scale_ = scale;
        }
        public void SetRotation(int rotation) {
            this.rotation_ = rotation;
        }
        
       
    }
}