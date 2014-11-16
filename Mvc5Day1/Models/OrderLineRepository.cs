using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Mvc5Day1.Models
{   
	public  class OrderLineRepository : EFRepository<OrderLine>, IOrderLineRepository
	{

	}

	public  interface IOrderLineRepository : IRepository<OrderLine>
	{

	}
}