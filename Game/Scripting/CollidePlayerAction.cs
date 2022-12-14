using Cowboy.Game.Casting;
using Cowboy.Game.Services;

namespace Cowboy.Game.Scripting {
    public class CollidePlayerAction : Action
    {
        private AudioService _audioService;
        private PhysicsService _physicsService;
        
        public CollidePlayerAction(PhysicsService physicsService, AudioService audioService)
        {
            this._physicsService = physicsService;
            this._audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Bullet bullet1 = (Bullet)cast.GetFirstActor(Constants.BULLET1_GROUP);
            Player player1 = (Player)cast.GetFirstActor(Constants.PLAYER1_GROUP);
            Bullet bullet2 = (Bullet)cast.GetFirstActor(Constants.BULLET2_GROUP);
            Player player2 = (Player)cast.GetFirstActor(Constants.PLAYER2_GROUP);
            Body bullet1Body = bullet1.GetBody();
            Body player1Body = player1.GetBody();
            Body bullet2Body = bullet2.GetBody();
            Body player2Body = player2.GetBody();

            if (_physicsService.HasCollided(player1Body, bullet1Body))
            {
                bullet1.BounceX();
                Sound sound = new Sound(Constants.GUN_SOUND);
            }

            if (_physicsService.HasCollided(player2Body, bullet2Body))
            {
                bullet2.BounceX();
                Sound sound = new Sound(Constants.GUN_SOUND);
                
            }

            if (_physicsService.HasCollided(player1Body, bullet2Body))
            {
                callback.OnNext(Constants.TRY_AGAIN);

            }

            if (_physicsService.HasCollided(player2Body, bullet1Body))
            {
                callback.OnNext(Constants.TRY_AGAIN);

            }

            


        }

    }
}