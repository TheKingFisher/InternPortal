             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class MessagerepositoryRepository : Repository<MessageRepository>, IMessagerepositoryRepository
	{

		public MessagerepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IMessagerepositoryRepository.cs file
	}
}
