namespace ForumSystem.Data.Seeding
{
    using ForumSystem.Data.Models;
    using Microsoft.EntityFrameworkCore.Internal;
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class CategorysSeeder : ISeeder
    {
        // Този метод се извиква и се стартира всеки път, когато се стартира приложението
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categorys.Any()) // Ако има някакви категории, просто ги връщаме(не прави нищо), но ако няма трявба да си сииднем тези от долу дефолтно
            {
                return;
            }

            var categoties = new List<string>
            {
                "Sport",
                "Coronavirus",
                "News",
                "Music",
                "Programing",
                "Cat",
                "Dog",
            };
            foreach (var item in categoties)
            {
                await dbContext.Categorys.AddAsync(new Category
                {
                    Name = item,
                    Description = item,
                    Title = item,
                });
            }
        }
    }
}
