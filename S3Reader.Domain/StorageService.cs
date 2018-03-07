using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;

namespace S3Reader.Domain
{
    public class StorageService : IStorageService
    {
        public async Task<string> LoadFile(string fileName)
        {
            using (var client = new AmazonS3Client(new StoredProfileAWSCredentials(), Amazon.RegionEndpoint.APSoutheast2))
            {
                GetObjectRequest request = new GetObjectRequest
                                               {
                                                   BucketName = "aptlink",
                                                   Key = "gary.json"
                                               };

                using (GetObjectResponse response = await client.GetObjectAsync(request))
                {
                    string dest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "gary.json");
                    StreamReader R = new StreamReader(response.ResponseStream);
                    var content = R.ReadToEnd();
                    return content;
                }
            }
        }
    }
}
