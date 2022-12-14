using Cowboy.Game.Services;
using Cowboy.Game.Scripting;
namespace Cowboy.Game.Casting {
    //Player class that has the following attributes: Position, Velocity, health, ammo, and score.
    public class Player : Stats
    {
            // Private fields for the Body and Animation of the player
        private Body _body;
        private Animation _animation;
        
        // Constructor to initialize the Body and Animation of the player
        public Player(Body body, Animation animation)
        {
            this._body = body;
            this._animation = animation;
        }

        // Method to get the Animation of the player
        public Animation GetAnimation()
        {
            return _animation;
        }

        // Method to get the Body of the player
        public Body GetBody()
        {
            return _body;
        }

        // Method to move the player to the next position
        public void MoveNext()
        {
            // Get the current position and velocity of the player's Body
            Point position = _body.GetPosition();
            Point velocity = _body.GetVelocity();

            // Calculate the next position by adding the velocity to the current position
            Point newPosition = position.Add(velocity);

            // Set the new position on the player's Body
            _body.SetPosition(newPosition);
        }

        // Method to make the player swing up
        public void SwingUp()
        {
            // Create a new velocity for the player to move upwards
            Point velocity = new Point(0, -Constants.PLAYER_VELOCITY);
            
            // Set the new velocity on the player's Body
            _body.SetVelocity(velocity);
        }


        public void SwingDown()
        {
            Point velocity = new Point(0 , Constants.PLAYER_VELOCITY);
            _body.SetVelocity(velocity);
        }


        public void StopMoving()
        {
            Point velocity = new Point(0, 0);
            _body.SetVelocity(velocity);
        }
        
    }
}