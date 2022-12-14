namespace Cowboy.Game.Casting {
    public class Point
    {
        // Point is a simple class that represents a point in 2D space
            private int _x;
            private int _y;

            // The constructor takes the x and y coordinates of the point
            public Point(int x, int y)
            {
                this._x = x;
                this._y = y;
            }

            // Add returns a new point that is the sum of this point and the given point
            public Point Add(Point other)
            {
                int x = this._x + other.GetX();
                int y = this._y + other.GetY();
                return new Point(x, y);
            }

            // Equals returns true if this point and the given point have the same coordinates
            public bool Equals(Point other)
            {
                return this._x == other.GetX() && this._y == other.GetY();
            }

            // GetX returns the x-coordinate of this point
            public int GetX()
            {
                return _x;
            }

            // GetY returns the y-coordinate of this point
            public int GetY()
            {
                return _y;
            }

            // Reverse returns a new point that has the same coordinates as this point,
            // but with the x-coordinate and y-coordinate reversed
            public Point Reverse()
            {
                int x = this._x * -1;
                int y = this._y * -1;
                return new Point(x, y);
            }

            // Scale returns a new point that has the same coordinates as this point,
            // but multiplied by the given factor
            public Point Scale(int factor)
            {
                int x = this._x * factor;
                int y = this._y * factor;
                return new Point(x, y);
            }

    }
}