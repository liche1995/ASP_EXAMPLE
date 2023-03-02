using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_example.Models;

namespace ASP_example.data
{
    public class PostData : DbContext
    {
        public PostData (DbContextOptions<PostData> options)
            : base(options)
        {
        }

        public DbSet<ASP_example.Models.Post> Post { get; set; } = default!;
    }
}
