using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlugifyWebNew.Models
{
    public class Posts
    {
        public int PostsID { get; set; }
        public string Title { get; set; }
        public bool ExplicitLanguage { get; set; }
    }
}
