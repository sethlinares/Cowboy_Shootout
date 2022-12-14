using System.Collections.Generic;
using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class CheckOverAction : Action
    {
        public CheckOverAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Player player1 = (Player)cast.GetFirstActor(Constants.PLAYER1_GROUP);
            Player player2 = (Player)cast.GetFirstActor(Constants.PLAYER2_GROUP);
            if (player1.GetLives() == 0 || player2.GetLives() == 0)
          
            {
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);
                stats.AddRound();
                callback.OnNext(Constants.NEXT_ROUND);

            }
        }
    }
}