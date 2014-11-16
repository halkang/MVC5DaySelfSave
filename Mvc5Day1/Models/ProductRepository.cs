using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Mvc5Day1.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public override IQueryable<Product> All()
        {
            return base.All().Where(p => p.IsVisible == true && p.IsDelete == false);
        }

        public IQueryable<Product> All(bool isAdmin)
        {
            if (isAdmin)
            {
                return base.All();
            }
            else
            {
                return this.All();
            }
        }

        public Product Find(int id)
        {
            return this.All().Where(p => p.ProductId == id).FirstOrDefault();
        }

        public void Delete(Product entity)
        {
            entity.IsDelete = true;
        }
        
	}

	public  interface IProductRepository : IRepository<Product>
	{

	}
}