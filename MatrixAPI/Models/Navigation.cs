using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixAPI.Models
{
    public class Navigation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public bool ChildLinks { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }

    public class ChildNavigation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public bool ChildLinks { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
