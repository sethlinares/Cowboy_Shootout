using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class DrawBulletAction : Action
    {
        private VideoService _videoService;
        
        public DrawBulletAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
{
    // Get the first Bullet object with the group Constants.BULLET1_GROUP
    Bullet bullet1 = (Bullet)cast.GetFirstActor(Constants.BULLET1_GROUP);
    // Get the body of the Bullet
    Body body1 = bullet1.GetBody();

    // Get the first Bullet object with the group Constants.BULLET2_GROUP
    Bullet bullet2 = (Bullet)cast.GetFirstActor(Constants.BULLET2_GROUP);
    // Get the body of the Bullet
    Body body2 = bullet2.GetBody();

    // If the Bullet is in debug mode
    if (bullet1.IsDebug())
    {
        // Get the Rectangle object of the body
        Rectangle rectangle = body1.GetRectangle();
        // Get the size of the rectangle
        Point size = rectangle.GetSize();
        // Get the position of the rectangle
        Point pos = rectangle.GetPosition();
        // Draw a rectangle on the _videoService object
        _videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
    }

    // If the Bullet is in debug mode
    if (bullet2.IsDebug())
    {
        // Get the Rectangle object of the body
        Rectangle rectangle = body2.GetRectangle();
        // Get the size of the rectangle
        Point size = rectangle.GetSize();
        // Get the position of the rectangle
        Point pos = rectangle.GetPosition();
        // Draw a rectangle on the _videoService object
        _videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
    }


            Image image1 = bullet1.GetImage();
            Point position1 = body1.GetPosition();
            _videoService.DrawImage(image1, position1);
            Image image2 = bullet2.GetImage();
            Point position2 = body2.GetPosition();
            _videoService.DrawImage(image2, position2);
        }
    }
}