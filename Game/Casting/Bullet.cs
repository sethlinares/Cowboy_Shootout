using System;
using System.Collections.Generic;
namespace Cowboy.Game.Casting {
        public class Bullet : Actor {
        // Field to store a static Random object for generating random numbers.
        private static Random _random = new Random();

        // Private fields to store the Body and Image objects that represent the Bullet.
        private Body _body;
        private Image _image;

        // Constructor that initializes the Bullet's Body and Image objects, as well as a debug flag.
        public Bullet(Body body, Image image, bool debug = false) : base(debug)
        {
            this._body = body;
            this._image = image;
        }

        // Method to change the velocity of the Bullet so that it bounces off of an object on the x-axis.
        public void BounceX()
        {
            // Get the Bullet's current velocity.
            Point velocity = _body.GetVelocity();
            // Generate a random number between 0.8 and 1.2.
            double rn = (_random.NextDouble() * (1.2 - 0.8) + 0.8);
            // Invert the x-component of the velocity.
            double vx = velocity.GetX() * -1;
            // Use the y-component of the velocity as is.
            double vy = velocity.GetY();
            // Create a new Point object with the inverted x-component and the original y-component of the velocity.
            Point newVelocity = new Point((int)vx, (int)vy);
            _body.SetVelocity(newVelocity);
        }


        public void BounceY()
        {
            Point velocity = _body.GetVelocity();
            double rn = (_random.NextDouble() * (1.2 - 0.8) + 0.8);
            double vx = velocity.GetX();
            double vy = velocity.GetY() * -1;
            Point newVelocity = new Point((int)vx, (int)vy);
            _body.SetVelocity(newVelocity);
        }
        

        public Body GetBody()
        {
            return _body;
        }


        public Image GetImage()
        {
            return _image;
        }


        public void Release()
        {
            Point velocity = _body.GetVelocity();
            List<int> velocities = new List<int> {Constants.BULLET_VELOCITY, Constants.BULLET_VELOCITY};
            int index = _random.Next(velocities.Count);
            double vx = velocities[index];
            double vy = -Constants.BULLET_VELOCITY;
            Point newVelocity = new Point((int)vx, (int)vy);
            _body.SetVelocity(newVelocity);
        }
    }
}