using System.Threading;

namespace DelegatesLambdaAndMore
{

    public delegate void TempChanged(double prev, double next);
    public class Machine
    {
        private double _currentTemp;
        private TempChanged _tempChange;

        public double CurrentTemp
        {
            get
            {
                return _currentTemp;
            }
            set
            {
                if (_currentTemp != value)
                {
                    var prev = _currentTemp;
                    _currentTemp = value;
                    OnTempChanged(prev, value);
                }
            }
        }

        public void TurnOn()
        {
            while (CurrentTemp < 100)
            {
                Thread.Sleep(1000);
                CurrentTemp++;
            }
        }

        public void RegisterTempWatcher(TempChanged watcher)
        {
            _tempChange += watcher;
        }

        private void OnTempChanged(double prev, double current)
        {
            if (_tempChange != null)
            {
                _tempChange(prev, current);
            }
        }

    }
}