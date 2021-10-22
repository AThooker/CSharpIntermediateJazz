using System;

namespace Exercises
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;
        public void Start()
        {
            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            _stopTime = DateTime.Now;
            _running = false;
        }
        public double GetTime()
        {
            return (_stopTime - _startTime).TotalSeconds;
        }
    }
}
