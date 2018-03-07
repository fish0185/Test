using System;
using System.Collections.Generic;
using System.Text;

using S3Reader.Data;
using S3Reader.Domain.Model;

namespace S3Reader.Domain
{
    public class ApplicationMapper : IApplicationMapper
    {
        public Application MapToDbApplication(UserApplication application)
        {
            return new Application { TimeStamp = DateTime.Now, Data = application.Name };
        }

        public UserApplication MapToUserApplication(Application applicationy)
        {
            return new UserApplication { Name = applicationy.Data };
        }
    }
}
