﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EASHLWebApp.Models
{
    public class Post
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Image { get; set; }

        public string Youtube { get; set; }
    }
}