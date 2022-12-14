using Cowboy.Game.Casting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Scripting
{
    public class ChangeSceneAction : Action
    {
        private KeyboardService _keyboardService;
        private string _nextScene;

        public ChangeSceneAction(KeyboardService keyboardService, string nextScene)
        {
            this._keyboardService = keyboardService;
            this._nextScene = nextScene;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            if (_keyboardService.IsKeyPressed(Constants.ENTER))
            {
                callback.OnNext(_nextScene);
            }
        }
    }
}