namespace ForumSystem.Web.ViewModels.Home
{
    using ForumSystem.Data.Models;
    using ForumSystem.Services.Mapping;

    public class IndexCategoryViewModel : IMapFrom<Category> // step 5 казваме му, че ще се мапва от Category
    {
        public string Title { get; set; } // взимаме от базата

        public string Description { get; set; } // взимаме от базата

        public string Name { get; set; } // взимаме от базата

        public string ImageUrl { get; set; }

        public int PostCount { get; set; }

        public string Url => $"/f/{this.Name.Replace(' ', '-')}"; // slug
    }
}
