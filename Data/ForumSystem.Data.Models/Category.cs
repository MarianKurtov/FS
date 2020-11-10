namespace ForumSystem.Data.Models
{
using System.Collections.Generic;

using ForumSystem.Data.Common.Models;

public class Category : BaseDeletableModel<int> // 1.категория на поста => 2. Добавяме в ApplicationDbContext
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Post> Posts { get; set; } // Обратната релация към всички постове на тази категория
    }
}
