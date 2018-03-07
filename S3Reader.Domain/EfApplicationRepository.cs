using System;
using System.Collections.Generic;
using System.Text;

using S3Reader.Data;

namespace S3Reader.Domain
{
    public class EfApplicationRepository : EfBaseRepository<Application>, IApplicationRepository
    {
        public EfApplicationRepository(S3ReaderContext context) :base(context)
        {
            
        }
    }
}
