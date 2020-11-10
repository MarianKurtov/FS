namespace ForumSystem.Web.ViewModels.Home
{
    public class IndexCategoryViewModel
    {
        public string Title { get; set; } // взимаме от базата

        public string Description { get; set; } // взимаме от базата

        public string Name { get; set; } // взимаме от базата

        public string ImageUrl { get; set; }

        public string Url => $"/f/{this.Name.Replace(' ', '-')}"; // slug
    }
}
