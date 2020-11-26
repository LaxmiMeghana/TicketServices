using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketServices.Models;

namespace TicketServices.Repository
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAll();

        Ticket GetById(int ticket_id);
    }
}
