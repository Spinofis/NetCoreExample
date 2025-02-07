﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
