using MaleFashion.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MaleFashion.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IFileStorageService _fileStorageService;

        public ProductController(ILogger<ProductController> logger, 
            IFileStorageService fileStorageService)
        {
            _logger = logger;
            _fileStorageService = fileStorageService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
