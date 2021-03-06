﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataCore.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int NoOfComments { get; set; }
        public Account Author { get; set; }
    }
}
