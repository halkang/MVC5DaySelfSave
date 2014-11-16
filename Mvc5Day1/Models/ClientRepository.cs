using System;
using System.Linq;
using System.Collections.Generic;
	
namespace Mvc5Day1.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{

	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}