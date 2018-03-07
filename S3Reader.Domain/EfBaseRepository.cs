using System;
using System.Collections.Generic;
using System.Text;

using S3Reader.Data;

namespace S3Reader.Domain
{
    public class EfBaseRepository<T> : IRepository<T> where T : class 
    {
        private readonly S3ReaderContext _context;

        public EfBaseRepository(S3ReaderContext context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }
    }
}
