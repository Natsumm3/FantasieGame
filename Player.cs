using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;
using SFML.Graphics;
using SFML.Window;

namespace fantasieGame
{
    class Player : CharakterAnimation
    {
        public Player(): base("Sprites/dante_sprite.png",32)
        {
            Animation_Left = new Animation(32, 0, 3);
            Animation_Right = new Animation(64, 0, 3);
            Animation_Up = new Animation(96, 0, 3);
            Animation_Down = new Animation(0, 0, 3);
            

            moveSpeed = 100;
            animSpeed = 0.15f;
        }

        public override void Update(float timeDelta)
        {
            this.CurrentState = CharakterStates.None;

            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                this.CurrentState = CharakterStates.MoveUp;
            }
            else if(Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                this.CurrentState = CharakterStates.MoveDown;
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                this.CurrentState = CharakterStates.MoveLeft;
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                this.CurrentState = CharakterStates.MoveRight;
            }
            

            base.Update(timeDelta);
        }
    }
}
