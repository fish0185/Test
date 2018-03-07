using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace S3Reader.Domain
{
    public interface IUnitOfWork
    {
        void Save();

        Task<int> SaveAsync();
    }
}
