namespace ForumSystem.Data.Models
{
using System.Collections.Generic;

using ForumSystem.Data.Common.Models;

public class Post : BaseDeletableModel<int>
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; } // физическата колоно, която ще направи релацията между Id  и  User

        public virtual ApplicationUser User { get; set; } // Правим релация към foreing key на user

        public string CategoryId { get; set; }

        public virtual Category Category { get; set; } // Релация към категорията

        public virtual ICollection<Comment> Comments { get; set; } // колекция от коментарите под този пост
    }
}
