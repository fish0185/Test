using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace S3Reader.Data
{
    public class S3ReaderContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public S3ReaderContext(DbContextOptions<S3ReaderContext> options) : base(options)
        {
            
        }
    }
}
