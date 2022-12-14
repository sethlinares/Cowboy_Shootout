using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class UnloadAssetsAction : Action
    {
        private AudioService _audioService;
        private VideoService _videoService;
        
        public UnloadAssetsAction(AudioService audioService, VideoService videoService)
        {
            this._audioService = audioService;
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            _audioService.UnloadSounds();
            _videoService.UnloadFonts();
            _videoService.UnloadImages();
        }
    }
}