using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class StartDrawingAction : Action
    {
        private VideoService _videoService;
        
        public StartDrawingAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            _videoService.ClearBuffer();
        }
    }
}