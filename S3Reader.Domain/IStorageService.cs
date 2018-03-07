using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace S3Reader.Domain
{
    public interface IStorageService
    {
        Task<string> LoadFile(string fileName);
    }
}
