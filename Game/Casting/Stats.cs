namespace Cowboy.Game.Casting {
    public class Stats : Actor
    {
        private int _round;
        private int _lives;
        private int _score;

        
        public Stats(int round = 1, int lives = 3, int score = 0, bool debug = false) : base(debug)
        {
            this._round = round;
            this._lives = lives;
            this._score = score;
        }


        public void AddRound()
        {
            _round++;
        }

        
        public void AddLife()
        {
            _lives++;
        }

        
        public void AddPoints(int points)
        {
            _score += points;
        }

      
        public int GetRound()
        {
            return _round;
        }

       
        public int GetLives()
        {
            return _lives;
        }

      
        public int GetScore()
        {
            return _score;
        }

       
        public void RemoveLife()
        {
            _lives--;
            if (_lives <= 0)
            {
                _lives = 0;
            }
        }
        
    }
}