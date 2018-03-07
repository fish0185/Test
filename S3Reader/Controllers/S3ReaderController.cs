using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using S3Reader.Domain;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace S3Reader.Controllers
{
    [Route("api/[controller]")]
    public class S3ReaderController : Controller
    {
        private readonly IApplicationService applicationService;

        public S3ReaderController(IApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        [HttpGet("{fileName}")]
        public async Task<IActionResult> Index(string fileName)
        {
            var app = await applicationService.FetchApplication(fileName);
            var result = await this.applicationService.SaveToDb(app);
            return this.Ok(result);
        }
    }
}
