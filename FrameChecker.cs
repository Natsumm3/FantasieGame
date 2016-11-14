using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace FantasyGame
{
    class FrameChecker
    {
        public static Clock clock = new Clock();

        public static int frameRate;

        public static bool CheckFrame()
        {
            if(clock.ElapsedTime.AsSeconds() > (float) 1/frameRate)
            {
                clock.Restart();
                return true;
            }
            return false;
        }
    }
}
