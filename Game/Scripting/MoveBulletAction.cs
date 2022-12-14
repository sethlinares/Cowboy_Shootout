using Cowboy.Game.Casting;
namespace Cowboy.Game.Scripting
{
    public class MoveBulletAction : Action
    {
        public MoveBulletAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Bullet bullet1 = (Bullet)cast.GetFirstActor(Constants.BULLET1_GROUP);
            Body body1 = bullet1.GetBody();
            Point position1 = body1.GetPosition();
            Point velocity1 = body1.GetVelocity();
            position1 = position1.Add(velocity1);
            body1.SetPosition(position1);

            Bullet bullet2 = (Bullet)cast.GetFirstActor(Constants.BULLET2_GROUP);
            Body body2 = bullet2.GetBody();
            Point position2 = body2.GetPosition();
            Point velocity2 = body2.GetVelocity();
            position2 = position2.Add(velocity2);
            body2.SetPosition(position2);
        }
    }
}