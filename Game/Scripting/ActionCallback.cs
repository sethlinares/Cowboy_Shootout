namespace Cowboy.Game.Scripting {
    public interface ActionCallback {
        //void method Called when we need to transition from one scene to the next.
        void OnNext(string sceneName);
    }
}