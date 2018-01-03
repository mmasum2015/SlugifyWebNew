using SlugifyWebNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlugifyWebNew.Data
{
    public class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            var coolPost = new Posts { Title = "small CAPS @ 123-!!! works" };
            context.Posts.Add(coolPost);
            context.SaveChanges();
        }
    }
}
