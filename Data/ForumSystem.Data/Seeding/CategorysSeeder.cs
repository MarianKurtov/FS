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

            var categoties = new List<(string Name, string ImageUrl)>
            {
               ("Sport", "https://www.armaghbanbridgecraigavon.gov.uk/wp-content/uploads/2019/04/sportsballs1.png"),
               ("Coronavirus", "https://hbr.org/resources/images/article_assets/2020/03/Mar20_01_Wikimedia3.jpg"),
               ("News", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRhpiNON39UBXjwmFR3gLH78i-oQe9DWpDkSw&usqp=CAU"),
               ("Music", "https://images.macrumors.com/t/MKlRm9rIBpfcGnjTpf6ZxgpFTUg=/1600x1200/smart/article-new/2018/05/apple-music-note.jpg"),
               ("Programing", "https://cdn4.iconfinder.com/data/icons/data-and-information/100/data-11-512.png"),
               ("Cat", "https://lh3.googleusercontent.com/proxy/mumU_0f4Tt445z22J8nSWbNERIa1388KRmpIcwt00P74WkwTLKwL5OyuAHqy_J5jalnX-8dbQm0EgzlrWxKsAb1rw0Tk7PDlw5f52QwU0NzI4Hfty5Uxn-7mxIWBu4BOknuvOA"),
               ("Dog", "https://post.greatist.com/wp-content/uploads/sites/3/2020/02/322868_1100-1100x628.jpg"),
            };
            foreach (var item in categoties)
            {
                await dbContext.Categorys.AddAsync(new Category
                {
                    Name = item.Name,
                    Description = item.Name,
                    Title = item.Name,
                    ImageUrl=item.ImageUrl
                });
            }
        }
    }
}
