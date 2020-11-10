namespace ForumSystem.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using ForumSystem.Data.Common.Repositories;
    using ForumSystem.Data.Models;
    using ForumSystem.Services.Data;
    using ForumSystem.Services.Mapping;
    using ForumSystem.Web.ViewModels;
    using ForumSystem.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public HomeController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel(); // step 1 в идеалния случай един екшън определя viewModel-a (IndexViewModel) !A В VIEWMODEL-A ТРЯБВА ДА МУ ОБЯСНИМ, ЧЕ СЕ МАПВА

            var category = this.categoriesService.GetAll<IndexCategoryViewModel>(); // step 2 взема информацията за viewModel-a с извикването на сървис

            viewModel.Categories = category; // step 3 присвоява го

            return this.View(viewModel); // step 4 подава го
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
