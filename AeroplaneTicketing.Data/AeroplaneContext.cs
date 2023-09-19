using Microsoft.EntityFrameworkCore;

namespace AeroplaneTicketing.Data.Model
{
    public class AeroplaneContext:DbContext
    {
        public AeroplaneContext(DbContextOptions<AeroplaneContext> options) : base(options)
        {
        }
        public virtual DbSet<TicketType> TicketType{ get; set; }
    }
}
