﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P127Task.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ButtonUrl { get; set; }
        public string LeftIcon { get; set; }
        public string RightIcon { get; set; }
    }
}
