using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace fantasieGame
{
    class Game
    {
        public void Start()
        {
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "FantasieGame");
            window.SetFramerateLimit(60);
            window.Closed += Window_Closed;
            

            Map map = new Map();
            Npc npc = new Npc();
            npc.Waypoints = new List<Waypoint>();
            npc.Waypoints.Add(new Waypoint(0, 0));
            npc.Waypoints.Add(new Waypoint(200, 0));
            npc.Waypoints.Add(new Waypoint(200, 250));
            npc.Waypoints.Add(new Waypoint(300, 250));
            npc.Waypoints.Add(new Waypoint(300, 100));
            npc.Waypoints.Add(new Waypoint(300, 0));
            npc.Waypoints.Add(new Waypoint(0, 0));



            Player player = new Player();
            View view = new View(new Vector2f(0, 0), new Vector2f(800, 600));
         
            Clock clock = new Clock();
            

            while(window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(new Color(43, 130, 53));
                float timeDelta = clock.Restart().AsSeconds();

                npc.Update(timeDelta);
                player.Update(timeDelta);

                view.Center = new Vector2f(player.Xposition, player.Yposition);
                window.SetView(view);
                  
                map.Draw(window);
                npc.Draw(window);
                player.Draw(window);               
                window.Display();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Close();
        }
    }
}
