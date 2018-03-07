using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using S3Reader.Domain.Model;

namespace S3Reader.Domain
{
    public interface IApplicationService
    {
        Task<UserApplication> FetchApplication(string fileName);

        Task<UserApplication> SaveToDb(UserApplication application);
    }
}
