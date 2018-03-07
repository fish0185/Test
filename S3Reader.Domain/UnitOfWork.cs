using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using S3Reader.Data;

namespace S3Reader.Domain
{
   public  class UnitOfWork : IUnitOfWork
    {
        private readonly S3ReaderContext _context;

        public UnitOfWork(S3ReaderContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
