using System;
using System.Collections.Generic;
using System.DAL;
using System.BL;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public class TicketManager:ITicketManager
    {

        private readonly ITicketRepo _ticketRepo;

        public TicketManager(ITicketRepo ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public IEnumerable<TicketCrudeDtos> GetAll()
        {
            var tickets = _ticketRepo.GetAll();
            return tickets.Select(t => new TicketCrudeDtos
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                departmentId = t.departmentId
            });
        }

        public TicketCrudeDtos GetTicketById(int id)
        {
            Ticket ticketDtos = _ticketRepo.GetById(id);
            
            return new TicketCrudeDtos
            {
                Id = ticketDtos.Id,
                Title = ticketDtos.Title,
                Description = ticketDtos.Description,
                departmentId = ticketDtos.departmentId
            };
        }

        public void Add(TicketCrudeDtos ticketDtos)
        {
            
            Ticket newTicket = new Ticket
            {
                Title = ticketDtos.Title,
                Description = ticketDtos.Description,
                departmentId = ticketDtos.departmentId
            };


            _ticketRepo.Add(newTicket);
            _ticketRepo.SaveChanges();
        }

        public void Update(TicketCrudeDtos ticketDtos)
        {
            Ticket? oldTicket = _ticketRepo.GetById(ticketDtos.Id);
            oldTicket.Title = ticketDtos.Title;
            oldTicket.Description = ticketDtos.Description;
            oldTicket.departmentId = ticketDtos.Id;

            _ticketRepo.Update(oldTicket);
            _ticketRepo.SaveChanges();
        }

        public void Delete(int id)
        {
            _ticketRepo.Delete(id);
            _ticketRepo.SaveChanges();
        }

    }
}
