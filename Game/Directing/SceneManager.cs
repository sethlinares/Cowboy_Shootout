using System;
using System.Collections.Generic;
using System.IO;
using Cowboy.Game.Casting;
using Cowboy.Game.Scripting;
using Cowboy.Game.Services;


namespace Cowboy.Game.Directing
{
    public class SceneManager
    {
        public static AudioService AudioService = new RaylibAudioService();
        public static KeyboardService KeyboardService = new RaylibKeyboardService();
        public static MouseService MouseService = new RaylibMouseService();
        public static PhysicsService PhysicsService = new RaylibPhysicsService();
        public static VideoService VideoService = new RaylibVideoService(Constants.GAME_NAME,
            Constants.SCREEN_WIDTH, Constants.SCREEN_HEIGHT, Constants.BLUE);

        public SceneManager()
        {
        }

        public void PrepareScene(string scene, Cast cast, Script script)
        {
            if (scene == Constants.NEW_GAME)
            {
                PrepareNewGame(cast, script);
            }
            else if (scene == Constants.NEXT_ROUND)
            {
                PrepareNextRound(cast, script);
            }
            else if (scene == Constants.TRY_AGAIN)
            {
                PrepareTryAgain(cast, script);
            }
            else if (scene == Constants.IN_PLAY)
            {
                PrepareInPlay(cast, script);
            }
            else if (scene == Constants.GAME_OVER)
            {
                PrepareGameOver(cast, script);
            }
        }

        private void PrepareNewGame(Cast cast, Script script)
        {
            AddStats(cast);
            
            AddBullet(cast); 
            AddPlayer(cast); 
            AddDialog(cast, Constants.ENTER_TO_START);

            script.ClearAllActions();
            AddInitActions(script);
            AddLoadActions(script);

            ChangeSceneAction a = new ChangeSceneAction(KeyboardService, Constants.NEXT_ROUND);
            script.AddAction(Constants.INPUT, a);

            AddOutputActions(script);
            AddUnloadActions(script);
            AddReleaseActions(script);
        }

        private void ActivateBullet(Cast cast)
        {
            Bullet bullet1 = (Bullet)cast.GetFirstActor(Constants.BULLET1_GROUP);
            bullet1.Release();
            Bullet bullet2 = (Bullet)cast.GetFirstActor(Constants.BULLET2_GROUP);
            bullet2.Release();
        }

        private void PrepareNextRound(Cast cast, Script script)
        {
            AddBullet(cast); 
            AddPlayer(cast); 
            AddDialog(cast, Constants.PREP_TO_LAUNCH);

            script.ClearAllActions();

            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);

            AddOutputActions(script);

            PlaySoundAction sa = new PlaySoundAction(AudioService, Constants.WELCOME_SOUND);
            script.AddAction(Constants.OUTPUT, sa);
        }

        private void PrepareTryAgain(Cast cast, Script script)
        {
            AddBullet(cast);
            AddPlayer(cast);
            AddDialog(cast, Constants.PREP_TO_LAUNCH);

            script.ClearAllActions();
            
            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.IN_PLAY, 2, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);
            
            AddUpdateActions(script);
            AddOutputActions(script);
        }

        private void PrepareInPlay(Cast cast, Script script)
        {
            ActivateBullet(cast);
            cast.ClearActors(Constants.DIALOG_GROUP);

            script.ClearAllActions();

            ControlPlayerAction action = new ControlPlayerAction(KeyboardService);
            
            script.AddAction(Constants.INPUT, action);

            AddUpdateActions(script);    
            AddOutputActions(script);
        
        }

        private void PrepareGameOver(Cast cast, Script script)
        {
            AddBullet(cast);
            AddPlayer(cast);
            AddDialog(cast, Constants.WAS_GOOD_GAME);

            script.ClearAllActions();

            TimedChangeSceneAction ta = new TimedChangeSceneAction(Constants.NEW_GAME, 5, DateTime.Now);
            script.AddAction(Constants.INPUT, ta);

            AddOutputActions(script);
        }

        
        private void AddBullet(Cast cast)
        {
            cast.ClearActors(Constants.BULLET1_GROUP);
            cast.ClearActors(Constants.BULLET2_GROUP);
        
            int x1 = Constants.PLAYER_WIDTH - 1; //Might be too close to person, unsure. 
            int y1 = Constants.CENTER_Y - Constants.BULLET_HEIGHT / 2; 

            int x2 = Constants.SCREEN_WIDTH - Constants.PLAYER_WIDTH - 30;
            int y2 = Constants.CENTER_Y - Constants.BULLET_HEIGHT / 2;
        
            Point position1 = new Point(x1, y1);
            Point size1 = new Point(Constants.BULLET_WIDTH, Constants.BULLET_HEIGHT);
            Point velocity1 = new Point(0, 0);

            Point position2 = new Point(x2, y2);
            Point size2 = new Point(Constants.BULLET_WIDTH, Constants.BULLET_HEIGHT);
            Point velocity2 = new Point(0, 0);
        
            Body body1 = new Body(position1, size1, velocity1);
            Image image1 = new Image(Constants.BULLET1_IMAGE);
            Bullet bullet1 = new Bullet(body1, image1, false);

            Body body2 = new Body(position2, size2, velocity2);
            Image image2 = new Image(Constants.BULLET2_IMAGE);
            Bullet bullet2 = new Bullet(body2, image2, false);
        
            cast.AddActor(Constants.BULLET1_GROUP, bullet1);
            cast.AddActor(Constants.BULLET2_GROUP, bullet2);

        }

        private void AddDialog(Cast cast, string message)
        {
            cast.ClearActors(Constants.DIALOG_GROUP);

            Text text = new Text(message, Constants.FONT_FILE, Constants.FONT_SIZE, 
                Constants.ALIGN_CENTER, Constants.WHITE);
            Point position = new Point(Constants.CENTER_X, Constants.CENTER_Y);

            Label label = new Label(text, position);
            cast.AddActor(Constants.DIALOG_GROUP, label);   
        }



        
        
        private void AddPlayer(Cast cast)
        {
            cast.ClearActors(Constants.PLAYER1_GROUP);
            cast.ClearActors(Constants.PLAYER2_GROUP);
        
            int x1 = 0;  
            int y1 = Constants.CENTER_Y - Constants.PLAYER_HEIGHT / 2;      
            int x2 = Constants.SCREEN_WIDTH - Constants.PLAYER_WIDTH - 1;          
            int y2 = Constants.CENTER_Y - Constants.PLAYER_HEIGHT / 2;        
        
            Point position1 = new Point(x1, y1);
            Point size1 = new Point(Constants.PLAYER_WIDTH, Constants.PLAYER_HEIGHT);
            Point velocity1 = new Point(0, 0);

            Point position2 = new Point(x2, y2);
            Point size2 = new Point(Constants.PLAYER_WIDTH, Constants.PLAYER_HEIGHT);
            Point velocity2 = new Point(0, 0);
        
            Body body1 = new Body(position1, size1, velocity1);
            Animation animation1 = new Animation(Constants.PLAYER1_IMAGES, Constants.PLAYER_RATE, 0);
            Player player1 = new Player(body1, animation1);

            Body body2 = new Body(position2, size2, velocity2);
            Animation animation2 = new Animation(Constants.PLAYER2_IMAGES, Constants.PLAYER_RATE, 0);
            Player player2 = new Player(body2, animation2);
        
            cast.AddActor(Constants.PLAYER1_GROUP, player1);
            cast.AddActor(Constants.PLAYER2_GROUP, player2);
        }

        

        private void AddStats(Cast cast)
        {
            cast.ClearActors(Constants.STATS_GROUP);
            Stats stats = new Stats();
            cast.AddActor(Constants.STATS_GROUP, stats);
        }


        private void AddInitActions(Script script)
        {
            script.AddAction(Constants.INITIALIZE, new InitializeDevicesAction(AudioService, VideoService));
        }

        private void AddLoadActions(Script script)
        {
            script.AddAction(Constants.LOAD, new LoadAssetsAction(AudioService, VideoService));
        }

        private void AddOutputActions(Script script)
        {
            script.AddAction(Constants.OUTPUT, new StartDrawingAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawBulletAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawPlayerAction(VideoService));
            script.AddAction(Constants.OUTPUT, new DrawDialogAction(VideoService));
            script.AddAction(Constants.OUTPUT, new EndDrawingAction(VideoService));
        }

        private void AddUnloadActions(Script script)
        {
            script.AddAction(Constants.UNLOAD, new UnloadAssetsAction(AudioService, VideoService));
        }

        private void AddReleaseActions(Script script)
        {
            script.AddAction(Constants.RELEASE, new ReleaseDevicesAction(AudioService, VideoService));
        }

        private void AddUpdateActions(Script script)
        {
            script.AddAction(Constants.UPDATE, new MoveBulletAction());
            script.AddAction(Constants.UPDATE, new MovePlayerAction());
            script.AddAction(Constants.UPDATE, new CollideBordersAction(PhysicsService, AudioService));
            script.AddAction(Constants.UPDATE, new CollidePlayerAction(PhysicsService, AudioService));
            script.AddAction(Constants.UPDATE, new CheckOverAction());     
        }
    }
}