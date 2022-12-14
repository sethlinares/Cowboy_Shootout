using Raylib_cs;
using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class EndDrawingAction : Action
    {
        private VideoService _videoService;
        
        public EndDrawingAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            _videoService.FlushBuffer();
        }
    }
}