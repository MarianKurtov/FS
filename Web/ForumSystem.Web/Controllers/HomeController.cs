namespace ForumSystem.Web.Controllers
{
    using ForumSystem.Data;
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using ForumSystem.Web.ViewModels;
    using ForumSystem.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();

            var category = this.db.Categorys.Select(x => new IndexCategoryViewModel
            {
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Title = x.Title,

            }).ToList();
            viewModel.Categories=category;
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
