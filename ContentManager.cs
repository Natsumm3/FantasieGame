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
    public static class ContentManager
    {

    }

    class SpriteMap
    {
        /// <summary>
        /// Creates a Spritemap
        /// </summary>
        /// <param name="id">Id of the SpriteMap</param>
        /// <param name="name">Name for the SpriteMap</param>
        /// <param name="fileName">Name of the Texture</param>
        /// <param name="tilewidth">Width of a Sprite</param>
        /// <param name="tileheight">Height of a Sprite</param>
        /// <param name="width">Amount of Horizontal Sprites</param>
        /// <param name="height">Amount of Vertical Sprites</param>
        public SpriteMap(int id, string name, string fileName, int tilewidth, int tileheight, int width, int height)
        {
            this.id = id;
            this.name = name;
            texture = new Texture(fileName);
            for (int i = 0; i < (width * height); i++)
            {

            }
        }

        int id;
        string name { get; }
        Texture texture;
        Sprite[,] sprites;
    }
}
