using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

using S3Reader.Domain.Model;

namespace S3Reader.Domain
{
    public class ApplicationService : IApplicationService
    {
        private readonly IStorageService storageService;

        private readonly IApplicationMapper applicationMapper;

        private readonly IApplicationRepository applicationRepository;

        private readonly IUnitOfWork unitOfWork;


        public ApplicationService(
            IStorageService storageService,
            IApplicationMapper applicationMapper,
            IApplicationRepository applicationRepository,
            IUnitOfWork unitOfWork)
        {
            this.storageService = storageService;
            this.applicationMapper = applicationMapper;
            this.applicationRepository = applicationRepository;
            this.unitOfWork = unitOfWork;
        }

        public class Info
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        public async Task<UserApplication> FetchApplication(string fileName)
        {
            var contetnt = await storageService.LoadFile(fileName);
            return JsonConvert.DeserializeObject<UserApplication>(contetnt);
        }

        public async Task<UserApplication> SaveToDb(UserApplication application)
        {
            var dbApplication = applicationMapper.MapToDbApplication(application);
            applicationRepository.Add(dbApplication);
            await this.unitOfWork.SaveAsync();
            return applicationMapper.MapToUserApplication(dbApplication);
        }
    }
}
