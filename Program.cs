// using System;
using Cowboy.Game.Directing;
using Cowboy.Game.Services;

namespace Cowboy
{
    public class Program
    {     
            static void Main(string[] args)
        {
            Director director = new Director(SceneManager.VideoService);
            director.StartGame();

            // Console.WriteLine("Test");
            // Console.ReadLine();
        }
    }
}
