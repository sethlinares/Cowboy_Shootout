using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class ControlPlayerAction : Action
{
    // A service that can be used to query the current state of the keyboard.
    private KeyboardService _keyboardService;

    public ControlPlayerAction(KeyboardService keyboardService)
    {
        // Assign the provided keyboard service to the instance variable.
        this._keyboardService = keyboardService;
    }

    // This method is called to execute the action.
    public void Execute(Cast cast, Script script, ActionCallback callback)
    {
        // Get the first actor from the PLAYER2_GROUP group in the cast.
        // We assume that this actor is a Player object, so we cast it as such.
        Player player2 = (Player)cast.GetFirstActor(Constants.PLAYER2_GROUP);

        // If the up arrow key is pressed, tell the player to swing up.
        if (_keyboardService.IsKeyDown(Constants.UP))
        {
            player2.SwingUp();
        }
        // If the down arrow key is pressed, tell the player to swing down.
        else if (_keyboardService.IsKeyDown(Constants.DOWN))
        {
            player2.SwingDown();
        }
        // If neither key is pressed, tell the player to stop moving.
        else
        {
            player2.StopMoving();
        }

        // Get the first actor from the PLAYER1_GROUP group in the cast.
        // We assume that this actor is a Player object, so we cast it as such.
        Player player1 = (Player)cast.GetFirstActor(Constants.PLAYER1_GROUP);

            if (_keyboardService.IsKeyDown(Constants.W))
            {
                player1.SwingUp();
            }
            else if (_keyboardService.IsKeyDown(Constants.S))
            {
                player1.SwingDown();
            }
            else
            {
                player1.StopMoving();
            }


        }
    }
}