namespace ForumSystem.Services.Data
{
    using ForumSystem.Data.Common.Repositories;
    using ForumSystem.Data.Models;
    using ForumSystem.Services.Mapping;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository) // инжектираме IDeletableEntityRepository<Category> 
        {
            this.categoriesRepository = categoriesRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query = 
                 this.categoriesRepository
                 .All()
                 .OrderBy(x => x.Name);

            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            return query.To<T>().ToList();
            //Получаваме готов за използване сървис, който в момента в който го регистрираме ще може да го ползваме навсякъде
        }
    }
}
