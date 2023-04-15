using System;
using System.Collections.Generic;
using System.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public class TicketCrudeDtos
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Title { get; set; }

        public int departmentId { get; set; }

    }
}
