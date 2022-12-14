using System.Collections.Generic;
using Cowboy.Game.Casting;
using Cowboy.Game.Scripting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Directing
{

    public class Director : ActionCallback
    {
        private Cast _cast;
        private Script _script;
        private SceneManager _sceneManager;
        private VideoService _videoService;
        
    
        public Director(VideoService videoService)
        {
            this._videoService = videoService;
            this._cast = new Cast();
            this._script = new Script();
            this._sceneManager = new SceneManager();
        }


        public void OnNext(string scene)
        {
            _sceneManager.PrepareScene(scene, _cast, _script);
        }

        public void StartGame()
        {
            OnNext(Constants.NEW_GAME);
            ExecuteActions(Constants.INITIALIZE);
            ExecuteActions(Constants.LOAD);
            while (_videoService.IsWindowOpen())
            {
                ExecuteActions(Constants.INPUT);
                ExecuteActions(Constants.UPDATE);
                ExecuteActions(Constants.OUTPUT);
            }
            ExecuteActions(Constants.UNLOAD);
            ExecuteActions(Constants.RELEASE);
        }



        private void ExecuteActions(string group)
{
            List<Scripting.Action> actions = _script.GetActions(group);
            for (int i = 0; i < actions.Count; i++)
            {
                Scripting.Action action = actions[i];
                action.Execute(_cast, _script, this);
            }
}
    }
}