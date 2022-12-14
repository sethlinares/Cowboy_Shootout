using Cowboy.Game.Casting;
namespace Cowboy.Game.Scripting {
    public interface Action {
        void Execute(Cast cast, Script script, ActionCallback callback);
    }
}