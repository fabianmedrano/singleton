using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameSettings.Instance.Difficultty = 3;
            GameSettings.Instance.SoundVolume = 1;
            GameSettings.Instance.ScreenResolution = 720;
        }
    }
}
