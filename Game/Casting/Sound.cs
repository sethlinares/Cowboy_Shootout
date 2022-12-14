using Cowboy.Game.Casting;
namespace Cowboy.Game.Casting {

    public class Sound {
        //filename of sound
        private string filename_;
        private int volume_;
        private bool repeated_;


        public Sound(string filename, int volume = 1, bool repeated = false) {
            this.filename_ = filename;
            this.volume_ = volume;
            this.repeated_ = repeated;
        }

        public string GetFilename() {
            return filename_;
        }
        public int GetVolume() {
            return volume_;
        }

        public bool IsRepeated() {
            return repeated_;
        }

        
    }
}