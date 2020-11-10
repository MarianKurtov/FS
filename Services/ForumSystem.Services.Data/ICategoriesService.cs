namespace ForumSystem.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>(int? count = null); // слагаме му параметър, колко категории искаме да вземем (дефолтната стойност на count е null)
    }
}
