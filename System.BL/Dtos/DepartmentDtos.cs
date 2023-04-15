using System;
using System.Collections.Generic;
using System.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public class DepartmentDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TicketsDtos> Tickets { get; set; }

    }
}
