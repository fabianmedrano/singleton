using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class GameSettings
    {
        private static GameSettings instance;
        public int Difficultty { get; set; }
        public int SoundVolume { get; set; }
        public int ScreenResolution { get; set; }

        private GameSettings() { 
            Difficultty = 4;
            SoundVolume = 9;
            ScreenResolution = 1028;
        }
        public static GameSettings Instance
        {
            get { if (instance == null) { 
                   instance = new GameSettings();   
                }
            return instance;
            }
        }
    }
}
