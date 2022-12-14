using System;
using System.Collections.Generic;

namespace Cowboy.Game.Casting {
    public class Animation
    {
        private TimeSpan _delay;
        private List<string> _images;
        private int _rate;
        private int _index;
        private int _frame;
        private DateTime _startTime;
        public Animation(List<string> images, int rate, int delay)
        {
            this._images = images;
            this._rate = rate;
            this._delay = new TimeSpan(0, 0, delay);
            this._index = 0;
            this._frame = 0;
            this._startTime = DateTime.Now;
        }

        //The GetDelay method returns the delay in seconds of the animation.
        public int GetDelay()
        {
            return _delay.Seconds;
        }

        //The GetImages method returns the list of images in the animation.
        public List<string> GetImages()
        {
            return _images;
        }


        public int GetRate()
        {
            return _rate;
        }

        //The NextImage method returns the next image in the animation. If the delay time has passed, 
        //the frame is incremented and the index of the image list is updated. If the index reaches the end of the list, the start time is reset.
        public Image NextImage()
        {
            string filename = _images[_index];
            Image image = new Image(filename);

            DateTime currentTime = DateTime.Now;
            TimeSpan elapsedTime = currentTime.Subtract(_startTime);

            if (elapsedTime > _delay)
            {
                _frame++; 
                if (_frame >= _rate)
                {
                    _index = (_index + 1) % _images.Count;
                    _frame = 0;
                }
                filename = _images[_index];
                image = new Image(filename);

                if (_index >= _images.Count - 1)
                {
                    _startTime = currentTime;
                }
            }

            return image; 
        }
    }
}