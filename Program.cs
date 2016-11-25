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
            Map map = new Map("map01.xml");

            Console.WriteLine(map.GetTiles(1)[1,10]);

            while (true) ;
        }
    }
}
