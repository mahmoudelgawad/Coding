using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_PlayGround.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string URL { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
}
}
