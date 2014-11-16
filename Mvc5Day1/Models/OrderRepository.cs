using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Mvc5Day1.Models
{   
	public  class OrderRepository : EFRepository<Order>, IOrderRepository
	{

	}

	public  interface IOrderRepository : IRepository<Order>
	{

	}
}