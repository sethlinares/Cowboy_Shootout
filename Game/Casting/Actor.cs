
namespace Cowboy.Game.Casting
{

    public class Actor
    {
        private bool _debug;
        

        public Actor(bool debug)
        {
            this._debug = debug;
        }

        public bool IsDebug()
        {
            return _debug;
        }
    }
}