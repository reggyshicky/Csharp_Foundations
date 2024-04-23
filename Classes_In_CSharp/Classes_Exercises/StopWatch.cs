namespace Classes_Exercises
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;
        public DateTime start()
        {
            //Start
            if (_isRunning == false)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
                return _startTime;
            }
            else
            {
                throw new InvalidOperationException("The watch is still running, you can't start the watch twice");
            }
        }
        public DateTime stop()
        {
            //stop
            if (_isRunning == true)
            {
                _stopTime = DateTime.Now;
                _isRunning = false;
                return _stopTime;
            }
            else
            {
                throw new InvalidOperationException("The watch is not running you cannot stop it");
            }
        }

        public TimeSpan GetDuration(DateTime startTime, DateTime stopTime)
        {
            return stopTime - startTime;
        }

    }
}
