using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class DrawPlayerAction : Action
    {
        private VideoService _videoService;
        
        public DrawPlayerAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Player player1 = (Player)cast.GetFirstActor(Constants.PLAYER1_GROUP);
            Body body1 = player1.GetBody();

            if (player1.IsDebug())
            {
                Rectangle rectangle1 = body1.GetRectangle();
                Point size1 = rectangle1.GetSize();
                Point pos1 = rectangle1.GetPosition();
                _videoService.DrawRectangle(size1, pos1, Constants.PURPLE, false);
            }

            Animation animation1 = player1.GetAnimation();
            Image image1 = animation1.NextImage();
            Point position1 = body1.GetPosition();
            _videoService.DrawImage(image1, position1);

            Player player2 = (Player)cast.GetFirstActor(Constants.PLAYER2_GROUP);
            Body body2 = player2.GetBody();

            if (player2.IsDebug())
            {
                Rectangle rectangle2 = body2.GetRectangle();
                Point size2 = rectangle2.GetSize();
                Point pos2 = rectangle2.GetPosition();
                _videoService.DrawRectangle(size2, pos2, Constants.PURPLE, false);
            }

            Animation animation2 = player2.GetAnimation();
            Image image2 = animation2.NextImage();
            Point position2 = body2.GetPosition();
            _videoService.DrawImage(image2, position2);
        }
    }
}