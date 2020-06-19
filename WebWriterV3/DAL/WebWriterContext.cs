using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWriterV3.DAL.DbModel;

namespace WebWriterV3.DAL
{
    public class WebWriterContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }

        public WebWriterContext(DbContextOptions<WebWriterContext> option) : base(option) { }
    }
}
