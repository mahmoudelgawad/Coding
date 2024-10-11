using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_PlayGround.Repository
{
    internal class BloggingRepository
    {
        public void GetBlog() 
        {
            using (var context = new BloggingContext()) 
            {
                var blogs = context.Blogs
                    .Where(b => b.Rating > 3)
                    .OrderBy(b => b.URL)
                    .ToList();  
            }
        }
    }
}
