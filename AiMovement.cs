using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantasieGame
{
    class AiMovement : CharakterAnimation
    {
        public List<Waypoint> Waypoints { get; set; }
        public int nextWaypointIndex = 1;

        public AiMovement(string filename,int frameSize): base(filename,frameSize)
        {

        }

        public override void Update (float timeDelta)
        {
            FollowPoints();

            base.Update(timeDelta);
        }

        private void FollowPoints()
        {
            if (Waypoints != null)
            {
                Waypoint nextWaypoint =  Waypoints[nextWaypointIndex];

                float xDiff = nextWaypoint.XPosition - this.Xposition;
                float yDiff = nextWaypoint.YPosition - this.Yposition;
                float absXDiff = Math.Abs(xDiff);
                float absYDiff = Math.Abs(yDiff);

                if (absXDiff < 10 && absYDiff < 10)
                {
                    if(nextWaypointIndex < Waypoints.Count-1)
                    {
                        nextWaypointIndex++;
                    }
                    else
                    {
                        nextWaypointIndex = 0;
                    }
                }

                if (absXDiff > absYDiff)
                {
                    if (xDiff > 0)
                    {
                        this.CurrentState = CharakterStates.MoveRight;
                    }
                    if (xDiff < 0)
                    {
                        this.CurrentState = CharakterStates.MoveLeft;
                    }


                }
                else
                {
                    if (yDiff > 0)
                    {
                        this.CurrentState = CharakterStates.MoveDown;
                    }
                    if (yDiff < 0)
                    {
                        this.CurrentState = CharakterStates.MoveUp;
                    }

                }

            }
        }
    }
}
