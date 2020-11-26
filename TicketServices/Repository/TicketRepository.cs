using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using TicketServices.Models;
using TicketServices.Controllers;
using TicketServices.Repository;

namespace TicketServices.Repository
{
    public class TicketRepository : ITicketRepository
    {
        /*private readonly TicketDbContext dbContext;

        public TicketRepository(TicketDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }*/
        public List<Ticket> Ticketlist = new List<Ticket>();
        public TicketRepository()
        {
            Ticketlist.Add(new Ticket { Ticket_Id = 1, Cost = 100, Destination = "vskp-hyd" });
            Ticketlist.Add(new Ticket { Ticket_Id = 2, Cost = 300, Destination = "vskp-kk" });
            Ticketlist.Add(new Ticket { Ticket_Id = 3, Cost = 300, Destination = "vskp-hltt" });
            Ticketlist.Add(new Ticket { Ticket_Id = 4, Cost = 200, Destination = "vskp-NZM" });
        }

            public IEnumerable<Ticket> GetAll()
        {
            //var booklist = dbContext.Tickets.ToList();
            return Ticketlist;
        }
        public Ticket GetById(int ticket_id)
        {
            foreach (var t in Ticketlist)
            {
                if (t.Ticket_Id == ticket_id)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
