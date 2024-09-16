using Store.Domain.Entities;
using System.Linq.Expressions;

namespace Store.Domain.Queries
{
    public static class ProductQuerie
    {
        public static Expression<Func<Product, bool>> GetActiveProducts()
        {
            return x => x.Active;
        }

        public static Expression<Func<Product, bool>> GetInactiveProducts()
        {
            return x => !x.Active;
        }
    }
}
