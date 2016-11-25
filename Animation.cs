using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;

namespace fantasieGame
{
    class Animation
    {
        public int offsetTop;
        public int offsetLeft;
        public int frameNum;

        public Animation(int offsetTop, int offsetLeft, int frameNum)
        {
            this.offsetLeft = offsetLeft;
            this.offsetTop = offsetTop;
            this.frameNum = frameNum;
        }
    }
}
