             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserclaimconfigurationRepository : Repository<AspNetUserClaimConfiguration>, IAspnetuserclaimconfigurationRepository
	{

		public AspnetuserclaimconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserclaimconfigurationRepository.cs file
	}
}
