using System;
using System.Collections.Generic;
using System.Text;

using S3Reader.Data;

namespace S3Reader.Domain
{
    public interface IApplicationRepository : IRepository<Application>
    {
        // extend application only 
    }
}
