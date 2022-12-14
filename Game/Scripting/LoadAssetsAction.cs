using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class LoadAssetsAction : Action
    {
        private AudioService _audioService;
        private VideoService _videoService;
        
        public LoadAssetsAction(AudioService audioService, VideoService videoService)
        {
            this._audioService = audioService;
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            _audioService.LoadSounds("Assets/Sounds");
            _videoService.LoadFonts("Assets/Fonts");
            _videoService.LoadImages("Assets/Images");
        }
    }
}