namespace Cowboy.Game.Casting {
    public class Rectangle
    {
        private Point _position;
        private Point _size;
        

        public Rectangle(Point position, Point size)
        {
            this._position = position;
            this._size = size;
        }


        public Point GetPosition()
        {
            return _position;
        }


        public Point GetSize()
        {
            return _size;
        }
    }
}