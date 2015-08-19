using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EASHLWebApp.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        public string Gamertag { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Number { get; set; }

        public int Age { get; set; }

        public string Type { get; set; }

        public string Strength { get; set; }

        public string Style { get; set; }

        public string Position { get; set; }

        public string Eaid { get; set; }
    }
}