using AeroplaneTicketing.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace AeroplaneTicketing.Api.Services
{
    public interface ITicketService
    {
        Task<List<TicketType>> GetTicketTypes();
    }
    public class TicketService : ITicketService
    {
        private readonly AeroplaneContext _context;
        public TicketService(AeroplaneContext context)
        {
            _context = context;
        }
        
       
        public async Task<List<TicketType>> GetTicketTypes()
        {
            var data = await _context.TicketType.ToListAsync();
            
            return data;

        }
    }
}
