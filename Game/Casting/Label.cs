using System.Net.Http.Headers;
using System.Reflection.Emit;
namespace Cowboy.Game.Casting {
    public class Label : Actor
    {
        private Text _text;
        private Point _position;


        public Label(Text text, Point position) : base(false)
        {
            this._text = text;
            this._position = position;
        }


        public Text GetText()
        {
            return _text;
        }


        public Point GetPosition()
        {
            return _position;
        }
    }
}