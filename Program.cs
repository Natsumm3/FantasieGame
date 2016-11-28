using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


namespace LoadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode( 1280, 720), "lol", Styles.Fullscreen);
            window.SetFramerateLimit(60);

            Vector2f position = new Vector2f(1000, 1000);

            View view = new View(new Vector2f(1000, 1000), new Vector2f(1280, 720));

            view.Center = position;
            window.SetView(view);

            //ContentManager.spriteMaps.Add(new SpriteMap(0, "terrain_atlas", "terrain_atlas.png", 32, 32, 32, 32));
            //ContentManager.spriteMaps.Add(new SpriteMap(1, "BLA", "BLA.png", 32, 32, 1, 1));
            //Map map = new Map("map01.tmx");

            ContentManager.spriteMaps.Add(new SpriteMap(0, "terrain_atlas" ,"terrain_atlas.png", 32,32,32,32));
            ContentManager.spriteMaps.Add(new SpriteMap(1, "base_out_atlas", "base_out_atlas.png", 32, 32, 32, 32));
            ContentManager.spriteMaps.Add(new SpriteMap(2, "houses", "houses.png", 32, 32, 13, 16));


            Map world = new Map("fantasieWorld.tmx");


            while (true)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
                    position.Y += 10;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
                    position.Y -= 10;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
                    position.X -= 10;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
                    position.X += 10;
                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                    window.Close();

                window.DispatchEvents();

                view.Center = position;
                window.SetView(view);

                window.Clear();

                world.Draw(window, view);

                window.Display();
            }
        }
    }
}
