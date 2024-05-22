using HalloBlazor.Contracts;

namespace HalloBlazor.Data
{
    public class EfRepository : IRepository
    {
        private readonly EfContext context = new EfContext();

        public void Add<T>(T entity) where T : class
        {
            context.Add<T>(entity);
            context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Remove<T>(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return context.Set<T>().ToList();
        }

        public T? GetById<T>(int id) where T : class
        {
            return context.Set<T>().Find(id);
        }

        public void Update<T>(T entity) where T : class
        {
            context.Update<T>(entity);
            context.SaveChanges();
        }
    }
}
