using Cowboy.Game.Casting;
using System.Collections.Generic;

namespace Cowboy.Game.Casting {
    public class Cast
{
    // This dictionary maps a group name to a list of actors in that group.
    private Dictionary<string, List<Actor>> _actors = new Dictionary<string, List<Actor>>();


    public Cast()
    {
    }

    // Adds an actor to the specified group in the cast.
    public void AddActor(string group, Actor actor)
    {
        // If the group doesn't exist in the dictionary, create an empty list of actors for it.
        if (!_actors.ContainsKey(group))
        {
            _actors[group] = new List<Actor>();
        }

        // If the actor doesn't already exist in the group, add them to the list.
        if (!_actors[group].Contains(actor))
        {
            _actors[group].Add(actor);
        }
    }

    // Clears the list of actors for the specified group.
    public void ClearActors(string group)
    {
        if (_actors.ContainsKey(group))
        {
            _actors[group] = new List<Actor>();
        }
    }

    // Clears the list of actors for all groups.
    public void ClearAllActors()
    {
        // Iterate over all group names in the dictionary.
        foreach(string group in _actors.Keys)
        {
            // Clear the list of actors for the current group.
            _actors[group] = new List<Actor>();
        }
    }


        public List<Actor> GetActors(string group)
        {
            List<Actor> results = new List<Actor>();
            if (_actors.ContainsKey(group))
            {
                results.AddRange(_actors[group]);
            }
            return results;
        }


        public List<Actor> GetAllActors()
        {
            List<Actor> results = new List<Actor>();
            foreach (List<Actor> result in _actors.Values)
            {
                results.AddRange(result);
            }
            return results;
        }

        public Actor GetFirstActor(string group)
        {
            Actor result = null;
            if (_actors.ContainsKey(group))
            {
                if (_actors[group].Count > 0)
                {
                    result = _actors[group][0];
                }
            }
            return result;
        }





        public void RemoveActor(string group, Actor actor)
        {
            if (_actors.ContainsKey(group))
            {
                _actors[group].Remove(actor);
            }
        }

    }
}