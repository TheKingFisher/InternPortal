             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class PositionRepository : Repository<Position>, IPositionRepository
	{

		public PositionRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IPositionRepository.cs file
	}
}
