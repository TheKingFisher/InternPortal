             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserloginrepositoryRepository : Repository<AspnetuserloginRepository>, IAspnetuserloginrepositoryRepository
	{

		public AspnetuserloginrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserloginrepositoryRepository.cs file
	}
}
