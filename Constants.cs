using System.Collections.Generic;
using Cowboy.Game.Casting;
using Cowboy.Game.Scripting;

namespace Cowboy {
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Cowboy Showdown";
        public static string GAME_VERSION = "1.0.0";
        public static string GAME_AUTHOR = "Seth Linares and Jared Linares";
        public static string GAME_DESCRIPTION = "Cowboy Showdown is a game where you play as a cowboy and try to shoot the other cowboy.";
        public static int FRAME_RATE = 60;


        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 32;
        public static int STATS_FONT_SIZE = 20;

        // SOUND
        public static string GUN_SOUND = "Assets/Sounds/gun-sound-effects.wav";
        

        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string OVER_SOUND = "Assets/Sounds/over.wav";


        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);
        public static Color RED = new Color(255, 0, 0);
        public static Color GREEN = new Color(0, 255, 0);
        public static Color BLUE = new Color(0, 0, 255);



        // KEYS
        public static string UP = "up";
        public static string DOWN = "down";
        public static string W = "w";
        public static string S = "s";
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_ROUND = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        //ROUNDS
        // public static string ROUND_FILE = "Assets/Data/round-{0:000}.txt";
        public static int BASE_ROUNDS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_LIVES = 3;
        public static int MAXIMUM_LIVES = 3;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string ROUND_GROUP = "round";
        public static string PLAYER1_LIVES_GROUP = "lives";
        public static string PLAYER2_LIVES_GROUP = "lives";
        public static string PLAYER1_SCORE_GROUP = "score";
        public static string PLAYER2_SCORE_GROUP = "score";
        public static string ROUND_FORMAT = "ROUND: {0}";
        public static string LIVES_FORMAT = "LIVES: {0}";
        public static string SCORE_FORMAT = "SCORE: {0}";

        // BALL
        public static string BULLET1_GROUP = "bullet1";
        public static string BULLET1_IMAGE = "Assets/Images/Bullet1.png";

        public static string BULLET2_GROUP = "bullet2";
        public static string BULLET2_IMAGE = "Assets/Images/Bullet2.png";
        public static int BULLET_WIDTH = 28;
        public static int BULLET_HEIGHT = 28;
        public static int BULLET_VELOCITY = 6;

        // RACKET
        public static string PLAYER1_GROUP = "player1";
        
        public static List<string> PLAYER1_IMAGES
            = new List<string>() {
                "Assets/Images/player1_aim.png"
            };

        public static string PLAYER2_GROUP = "player2";
        
        public static List<string> PLAYER2_IMAGES
            = new List<string>() {
                "Assets/Images/player2_aim.png"
            };

        public static int PLAYER_WIDTH = 100;
        public static int PLAYER_HEIGHT = 200;
        public static int PLAYER_RATE = 6;
        public static int PLAYER_VELOCITY = 9;

                // BACKGROUND
        // public static string BACKGROUND_IMAGE = "Assets/Images/background.png";

        // BRICK
        // public static string BRICK_GROUP = "bricks";
        
        // public static Dictionary<string, List<string>> BRICK_IMAGES
        //     = new Dictionary<string, List<string>>() {
        //         { "b", new List<string>() {
        //             "Assets/Images/010.png",
        //             "Assets/Images/011.png",
        //             "Assets/Images/012.png",
        //             "Assets/Images/013.png",
        //             "Assets/Images/014.png",
        //             "Assets/Images/015.png",
        //             "Assets/Images/016.png",
        //             "Assets/Images/017.png",
        //             "Assets/Images/018.png"
        //         } },
        //         { "g", new List<string>() {
        //             "Assets/Images/020.png",
        //             "Assets/Images/021.png",
        //             "Assets/Images/022.png",
        //             "Assets/Images/023.png",
        //             "Assets/Images/024.png",
        //             "Assets/Images/025.png",
        //             "Assets/Images/026.png",
        //             "Assets/Images/027.png",
        //             "Assets/Images/028.png"
        //         } },
        //         { "p", new List<string>() {
        //             "Assets/Images/030.png",
        //             "Assets/Images/031.png",
        //             "Assets/Images/032.png",
        //             "Assets/Images/033.png",
        //             "Assets/Images/034.png",
        //             "Assets/Images/035.png",
        //             "Assets/Images/036.png",
        //             "Assets/Images/037.png",
        //             "Assets/Images/038.png"
        //         } },
        //         { "y", new List<string>() {
        //             "Assets/Images/040.png",
        //             "Assets/Images/041.png",
        //             "Assets/Images/042.png",
        //             "Assets/Images/043.png",
        //             "Assets/Images/044.png",
        //             "Assets/Images/045.png",
        //             "Assets/Images/046.png",
        //             "Assets/Images/047.png",
        //             "Assets/Images/048.png"
        //         } }
        // };

        // public static int BRICK_WIDTH = 80;
        // public static int BRICK_HEIGHT = 28;
        // public static double BRICK_DELAY = 0.5;
        // public static int BRICK_RATE = 4;
        // public static int BRICK_POINTS = 50;

        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARING TO LAUNCH";
        public static string WAS_GOOD_GAME = "GAME OVER";

    }

}