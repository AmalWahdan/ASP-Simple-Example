using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DAL
{
    public class TicketRepo : ITicketRepo
    {

        private readonly DB _dbContext;

        public TicketRepo(DB dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Ticket> GetAll()
        {
            return _dbContext.Set<Ticket>();
        }

        public Ticket? GetById(int id)
        {
            return _dbContext.Set<Ticket>().FirstOrDefault(t => t.Id == id);
        }

        public void Add(Ticket entity)
        {
            _dbContext.Set<Ticket>().Add(entity);
        }

        public void Update(Ticket entity)
        {
            _dbContext.Set<Ticket>().Update(entity);
        }

        public void Delete(int Id)
        {
            var ticket = GetById(Id);
            if (ticket != null)
            {
                _dbContext.Set<Ticket>().Remove(ticket);
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }

}
