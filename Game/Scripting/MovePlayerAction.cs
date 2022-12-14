using Cowboy.Game.Casting;

namespace Cowboy.Game.Scripting
{
    public class MovePlayerAction : Action
    {
        public MovePlayerAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            // Get the Player object from the cast
            Player player1 = (Player)cast.GetFirstActor(Constants.PLAYER1_GROUP);

            // Retrieve the Body of the player
            Body body1 = player1.GetBody();

            // Get the current position and velocity of the player's Body
            Point position1 = body1.GetPosition();
            Point velocity1 = body1.GetVelocity();

            // Get the current x position of the player
            int x1 = position1.GetX();

            // Update the player's position by adding the velocity
            position1 = position1.Add(velocity1);

            // Check if the updated position is off the screen
            if (x1 < 0)
            {
                // If the player is off the left side of the screen, set their position to 0 on the x-axis
                position1 = new Point(0, position1.GetY());
            }
            else if (x1 > Constants.SCREEN_WIDTH - Constants.PLAYER_WIDTH)
            {
                // If the player is off the right side of the screen, set their position to the screen width minus the player's width on the x-axis
                position1 = new Point(Constants.SCREEN_WIDTH - Constants.PLAYER_WIDTH, 
                    position1.GetY());
            }

            // Set the updated position on the player's Body
            body1.SetPosition(position1);


            Player player2 = (Player)cast.GetFirstActor(Constants.PLAYER2_GROUP);
            Body body2 = player2.GetBody();
            Point position2 = body2.GetPosition();
            Point velocity2 = body2.GetVelocity();
            int x2 = position2.GetX();

            position2 = position2.Add(velocity2);
            if (x2 < 0)
            {
                position2 = new Point(0, position2.GetY());
            }
            else if (x2 > Constants.SCREEN_WIDTH - Constants.PLAYER_WIDTH)
            {
                position2 = new Point(Constants.SCREEN_WIDTH - Constants.PLAYER_WIDTH, 
                    position2.GetY());
            }

            body2.SetPosition(position2);



        }
    }
}