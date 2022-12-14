namespace Cowboy.Game.Casting {
    public class Body
    {
        // Private fields to store the position, size, and velocity of the Body.
        private Point _position;
        private Point _size;
        private Point _velocity;

        // Constructor that initializes the Body's position, size, and velocity.
        public Body(Point position, Point size, Point velocity)
        {
            this._position = position;
            this._size = size;
            this._velocity = velocity;
        }

        // Getter for the position of the Body.
        public Point GetPosition()
        {
            return _position;
        }

        // Returns a Rectangle object that represents the dimensions of the Body.
        public Rectangle GetRectangle()
        {
            return new Rectangle(_position, _size);
        }

        // Getter for the size of the Body.
        public Point GetSize()
        {
            return _size;
        }

        // Getter for the velocity of the Body.
        public Point GetVelocity()
        {
            return _velocity;
        }

        // Setter for the position of the Body.
        public void SetPosition(Point position)
        {
            this._position = position;
        }

        // Setter for the size of the Body.
        public void SetSize(Point size)
        {
            this._size = size;
        }

        // Setter for the velocity of the Body.
        public void SetVelocity(Point velocity)
        {
            this._velocity = velocity;
        }
    }
}
