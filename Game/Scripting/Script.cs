using System;
using System.Collections.Generic;
namespace Cowboy.Game.Scripting {
    public class Script {
        private Dictionary<string, List<Action>> _actions = new Dictionary<string, List<Action>>();
        public Script() {
        }

        public void AddAction(string group, Action action)
        {
            if (!_actions.ContainsKey(group))
            {
                _actions[group] = new List<Action>();
            }

            if (!_actions[group].Contains(action))
            {
                _actions[group].Add(action);
            }
        }

        //Clears the actions in the given group.
        public void ClearActions(string group) {
            if (_actions.ContainsKey(group)) {
                _actions[group].Clear();
            }
        }

        //Clears all the actions in the script.
        public void ClearAllActions() {
            foreach (string group in _actions.Keys) {
                _actions[group].Clear();
            }
        }

        //Gets the actions in the given group. Returns an empty list if there aren't any.
        public List<Action> GetActions(string group) {
            if (_actions.ContainsKey(group)) {
                return _actions[group];
            }
            return new List<Action>();
        }

        //Removes the given action from the given group.
        public void RemoveAction(string group, Action action) {
            if (_actions.ContainsKey(group)) {
                _actions[group].Remove(action);
            }
        }


    }
    
}