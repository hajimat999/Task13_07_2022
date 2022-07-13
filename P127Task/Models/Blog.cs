using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P127Task.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
