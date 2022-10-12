using GECP_DOT_NET_API.Models;
using GECP_DOT_NET_API.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GECP_DOT_NET_API.Controllers
{
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private IPortfolioRepo iportfolioRepo;
        private IWebHostEnvironment _hostingEnvironment;

        public PortfolioController(IWebHostEnvironment environment)
        {
            iportfolioRepo = new PortfolioRepo();
            _hostingEnvironment = environment;
        }

        [HttpGet, Route("api/GetAllPortfolioDetails")]
        public IActionResult GetAllPortfolioDetails()
        {
            var response = iportfolioRepo.GetAllPortfolioDetails();
            return Ok(response);
        }

        [HttpPost, Route("api/AddPortfolioDetail")]
        public IActionResult AddPortfolioDetail()
        {
            var portfolioVM = new PortfolioVM();
            TryUpdateModelAsync<PortfolioVM>(portfolioVM);
            return Ok(iportfolioRepo.AddPortfolioDetail(portfolioVM));
        }

        [HttpPost, Route("api/UpdatePortfolioDetail")]
        public IActionResult UpdatePortfolioDetail()
        {
            var portfolioVM = new PortfolioVM();
            TryUpdateModelAsync<PortfolioVM>(portfolioVM);
            return Ok(iportfolioRepo.UpdatePortfolioDetail(portfolioVM));
        }

        [HttpPost, Route("api/DeletePortfolioDetail")]
        public IActionResult DeletePortfolioDetail(PortfolioVM portfolioVM)
        {
            return Ok(iportfolioRepo.DeletePortfolioDetail(portfolioVM));
        }
    }
}
