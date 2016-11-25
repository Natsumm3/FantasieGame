using System;
using System.IO;
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
    class Map
    {
        Sprite[,] tiles;
        int mapWidth = 100;
        int mapHeight = 100;

        public Map()
        {
            int tilemapWidth = 32;
            int tilemapHeight = 32;
            int tileSize = 32;

            Texture texture = new Texture("Maps/terrain_atlas.png");
            Sprite[] tilemap = new Sprite[tilemapWidth * tilemapHeight];

            for(int y = 0; y < tilemapHeight; y++)
            {
                for(int x = 0; x < tilemapWidth; x++)
                {
                    IntRect rect = new IntRect(x * tileSize, y * tileSize, tileSize, tileSize);
                    tilemap[(y * tilemapWidth) + x] = new Sprite(texture, rect);
                }
            }

            tiles = new Sprite[mapWidth, mapHeight];
            StreamReader reader = new StreamReader("Maps/terraintest.csv");

            for (int y = 0; y < mapHeight; y++)
            {
                string line = reader.ReadLine();
                string[] items = line.Split(',');

                for (int x = 0; x < mapWidth; x++)
                {
                    int id = Convert.ToInt32(items[x]);
                    tiles[x,y] = new Sprite(tilemap[id]);
                    tiles[x,y].Position = new Vector2f(tileSize * x, tileSize * y);
                }
            }

            reader.Close();
            
        }

        public void Draw(RenderWindow window)
        {
            for (int y = 0; y < mapHeight; y++)
            {
  
                for (int x = 0; x < mapWidth; x++)
                {
                    window.Draw(tiles[x,y]);
                }
            }
        }
    }
}
