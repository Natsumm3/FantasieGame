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
    [XmlRoot("map")]
    public class Map
    {
        #region Methods

        public Map()
        {}

        public Map(string xmlFile)
        {
            StreamReader reader = new StreamReader(xmlFile);
            XmlSerializer serializer = new XmlSerializer(typeof(Map));

            Map map = (Map)serializer.Deserialize(reader);
            width = map.width;
            height = map.height;
            tilewidth = map.tilewidth;
            tileheight = map.tileheight;
            layers = map.layers;
            objectgroups = map.objectgroups;
            tileset = map.tileset;
            Tiles = new List<int[,]>();

            for (int i = 0; i < layers.Length; i++)
            {
                Tiles.Add(CreateTiles(i));
            }
        }

        /// <summary>
        /// Returns a 2D-Array with the int ID's of the Tiles
        /// </summary>
        /// <param name="layer">The Layer of the wanted Tiles</param>
        private int[,] CreateTiles(int layer)
        {
            int[,] tiles = new int[width, height]; ;
            for (int y = 0; y < height+1; y++)
            {
                string line = layers[layer].tileString.Split('\n')[y];
                for (int x = 0; x < width; x++)
                {
                    if (y > 0)
                    {
                        int id = Convert.ToInt32(line.Split(',')[x]);
                        tiles[x, y - 1] = id;
                    }
                }
            }
            return tiles;
        }

        public int[,] GetTiles(int layer)
        {
            return Tiles[layer];
        }

        public void Update()
        {

        }

        public void Draw(RenderWindow window)
        {
            for (int i = 0; i < Tiles.Count ; i++)
            {
                for (int y = 0; y < Tiles[i].GetLength(1) ; y++)
                {
                    for (int x = 0; x < Tiles[i].GetLength(0); x++)
                    {
                        //window.Draw();
                    }
                }
            }
        }

        #endregion



        #region Variables

        List<int[,]> Tiles;

        [XmlAttribute("width")]
        public int width
        {
            get;
            set;
        }

        [XmlAttribute("height")]
        public int height
        {
            get;
            set;
        }

        [XmlAttribute("tilewidth")]
        public int tilewidth
        {
            get;
            set;
        }

        [XmlAttribute("tileheight")]
        public int tileheight
        {
            get;
            set;
        }

        [XmlElement("layer")]
        public Layer[] layers
        {
            get;
            set;
        }

        [XmlElement("objectgroup")]
        public ObjectGroup[] objectgroups
        {
            get;
            set;
        }

        [XmlElement("tileset")]
        public Tileset tileset
        {
            get;
            set;
        }

        #endregion
    }

    public class Layer
    {
        [XmlAttribute("name")]
        public string name
        {
            get;
            set;
        }

        [XmlElement("data")]
        public string tileString
        {
            get;
            set;
        }
    }

    public class ObjectGroup
    {
        [XmlAttribute("name")]
        public string name
        {
            get;
            set;
        }

        [XmlElement("object")]
        public Rectangle[] rectangles
        {
            get;
            set;
        }
    }

    public class Tileset
    {
        [XmlAttribute("name")]
        public string name
        {
            get;
            set;
        }

        [XmlAttribute("tilecount")]
        public int tileCount
        {
            get;
            set;
        }

        [XmlAttribute("columns")]
        public int columns
        {
            get;
            set;
        }
    }

    public class Rectangle
    {
        [XmlAttribute("id")]
        public int id
        {
            get;
            set;
        }

        [XmlAttribute("x")]
        public int x
        {
            get;
            set;
        }

        [XmlAttribute("y")]
        public int y
        {
            get;
            set;
        }

        [XmlAttribute("width")]
        public int width
        {
            get;
            set;
        }

        [XmlAttribute("height")]
        public int height
        {
            get;
            set;
        }
    }
}
