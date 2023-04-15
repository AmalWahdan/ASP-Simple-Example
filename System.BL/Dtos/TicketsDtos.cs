using System;
using System.Collections.Generic;
using System.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public class TicketsDtos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DevelopersCount { get; set; }

    }
}
