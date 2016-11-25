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
    public enum CharakterStates
    {
        None,
        MoveLeft,
        MoveRight,
        MoveUp,
        MoveDown,
     

    }

    abstract class CharakterAnimation
    {
        public float Xposition { get; set; }
        public float Yposition { get; set; }
        public CharakterStates CurrentState { get; set; }

        private Sprite sprite;
        private IntRect spriteRec;
        private int frameSize;
        protected float moveSpeed = 50;
        protected float animSpeed = 0.1f;
        private Clock animClock;

        protected Animation Animation_Left;
        protected Animation Animation_Right;
        protected Animation Animation_Up;
        protected Animation Animation_Down;
        



        public CharakterAnimation(string filename, int frameSize)
        {
            this.frameSize = frameSize;
            Texture texture = new Texture(filename);
            spriteRec = new IntRect(0, 0, frameSize, frameSize);
            sprite = new Sprite(texture, spriteRec);
            animClock = new Clock();

            
  
        }

        public virtual void Update(float timeDelta)
        {
            Animation currentAnimation = null;

            switch (CurrentState)
            {
                case CharakterStates.MoveUp:
                    currentAnimation = Animation_Up;
                    Yposition -= moveSpeed * timeDelta;
                    break;
                case CharakterStates.MoveDown:
                    currentAnimation = Animation_Down;
                    Yposition += moveSpeed * timeDelta;
                    break;
                case CharakterStates.MoveRight:
                    currentAnimation = Animation_Right;
                    Xposition += moveSpeed * timeDelta;
                    break;
                case CharakterStates.MoveLeft:
                    currentAnimation = Animation_Left;
                    Xposition -= moveSpeed * timeDelta;
                    break;
                
            }

            sprite.Position = new Vector2f(Xposition, Yposition);


            //Methode for cyling through and reseting each frame in the Spritesheet

            if (animClock.ElapsedTime.AsSeconds() > animSpeed)
            {
                if (currentAnimation != null)
                {
                    spriteRec.Top = currentAnimation.offsetTop;

                    if (spriteRec.Left == (currentAnimation.frameNum -1)*frameSize)
                    {
                        spriteRec.Left = 0;
                    }
                    else
                    {
                        spriteRec.Left += frameSize;
                    }
                }

                animClock.Restart();
            }

            sprite.TextureRect = spriteRec;
        }

        public void Draw(RenderWindow window)
        {
            window.Draw(sprite);
        }
    }
}
