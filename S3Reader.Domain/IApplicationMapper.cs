using System;
using System.Collections.Generic;
using System.Text;

using S3Reader.Data;
using S3Reader.Domain.Model;

namespace S3Reader.Domain
{
    public interface IApplicationMapper
    {
        Application MapToDbApplication(UserApplication application);

        UserApplication MapToUserApplication(Application applicationRepository);
    }
}
