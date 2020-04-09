using System.Linq;
using MyShop.Core.Models;

namespace MyShop.DataAccess.SQL
{
    public interface ISQLRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}