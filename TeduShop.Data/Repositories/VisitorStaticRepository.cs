using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public class VisitorStaticRepository : RepositoryBase<VisitorStatic>
    {
        public VisitorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}