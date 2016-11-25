using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasieGame
{
    class Npc: AiMovement
    {
        public Npc() : base("Sprites/NpcTest.png",32)
        {
            Animation_Left = new Animation(32, 0, 4);
            Animation_Right = new Animation(64, 0, 4);
            Animation_Up = new Animation(96, 0, 4);
            Animation_Down = new Animation(0, 0, 4);
        }
    }
}
