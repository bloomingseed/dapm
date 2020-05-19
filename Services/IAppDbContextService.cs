using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
	public interface IAppDbContextService<TModel>
	{
		TModel[] SelectAllAsync();
		void Insert(TModel record);
		//void Update(TModel )
	}
}
