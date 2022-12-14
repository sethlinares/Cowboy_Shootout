using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class CollideBordersAction : Action
    {
        private AudioService _audioService;
        private PhysicsService _physicsService;
        
        public CollideBordersAction(PhysicsService physicsService, AudioService audioService)
        {
            this._physicsService = physicsService;
            this._audioService = audioService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Player player1 = (Player)cast.GetFirstActor(Constants.PLAYER1_GROUP);

            Player player2 = (Player)cast.GetFirstActor(Constants.PLAYER2_GROUP);

            Body body1 = player1.GetBody();
            Body body2 = player2.GetBody();


            Bullet bullet1 = (Bullet)cast.GetFirstActor(Constants.BULLET1_GROUP);
            

            Bullet bullet2 = (Bullet)cast.GetFirstActor(Constants.BULLET2_GROUP);

            HandleCollision(bullet1, cast, callback);
            HandleCollision(bullet2, cast, callback);

            
            if (_physicsService.HasCollided(body2, bullet1.GetBody()))
            {
                player2.RemoveLife();
                if (player2.GetLives() > 0)
                {
                    callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    callback.OnNext(Constants.GAME_OVER);
                    Sound sound = new Sound(Constants.OVER_SOUND);
                    _audioService.PlaySound(sound);
                }
            }

            if (_physicsService.HasCollided(body1, bullet2.GetBody()))
            {
                player1.RemoveLife();
                if (player1.GetLives() > 0)
                {
                    callback.OnNext(Constants.TRY_AGAIN);
                }
                else
                {
                    callback.OnNext(Constants.GAME_OVER);
                    Sound sound = new Sound(Constants.OVER_SOUND);
                    _audioService.PlaySound(sound);
                }
            }


            

            

            
        }

        private void HandleCollision(Bullet bullet, Cast cast, ActionCallback callback) {
            Sound gunSound = new Sound(Constants.GUN_SOUND);
            Sound overSound = new Sound(Constants.OVER_SOUND);
            Body body = bullet.GetBody();
            Point position = body.GetPosition();
            int x = position.GetX();
            int y = position.GetY();
            if (x < Constants.FIELD_LEFT)
            {
                bullet.BounceX();
                _audioService.PlaySound(gunSound);
            }
            
            else if (x >= Constants.FIELD_RIGHT - Constants.BULLET_WIDTH)
            {
                bullet.BounceX();
                _audioService.PlaySound(gunSound);
            }

            if (y < Constants.FIELD_TOP)
            {
                bullet.BounceY();
                _audioService.PlaySound(gunSound);
            }
            else if (y >= Constants.FIELD_BOTTOM - Constants.BULLET_WIDTH)
            {
                bullet.BounceY();
                _audioService.PlaySound(gunSound);   
                
            }

            



            

        }
    }
}
