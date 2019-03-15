using System;
namespace Lyser.ViewModels
{
    public class Global
    {
        public double Age { get; set; }

        private static Global _instance = null;

        private Global()
        {
        }

        static internal Global Instance()
        {
            if (_instance == null)
            {
                _instance = new Global();
            }

            return _instance;
        }
    }
}
