using System;
namespace prjTimerPro.Custom
{
    public class cTimerLogic
    {
        private int _Sec;
        private int _Min;
        private int _Hours;

        public cTimerLogic()
        {
            Reset();
        }

        public void Reset()
        {
            _Sec = 0;
            _Min = 0;
            _Hours = 0;
        }

        public void SecTickCounter()
        {
            _Sec++;
            if (_Sec == 60)
            {
                _Min++;
                _Sec = 0;
            }
            if (_Min==60)
            {
                _Hours++;
                _Min = 0;
            }
        }

        public string GetFormatedString()
        {
            return _Hours.ToString().PadLeft(2, '0') + ":" +
                         _Min.ToString().PadLeft(2, '0') + ":" +
                         _Sec.ToString().PadLeft(2, '0');
        }
    }
}
