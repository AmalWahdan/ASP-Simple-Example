using System;
using System.Collections.Generic;
using System.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public interface ITicketManager
    {
        IEnumerable<TicketCrudeDtos> GetAll();
        TicketCrudeDtos GetTicketById(int id);
        void Add(TicketCrudeDtos ticket);
        void Update(TicketCrudeDtos ticket);
        void Delete(int id);


    }
}
