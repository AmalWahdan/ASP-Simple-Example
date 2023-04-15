using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace System.DAL
{ 
    public class DeptRepo : IDeptRepo
    {
        private readonly DB _context;

        public DeptRepo(DB context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Set<Department>();
        }

        public Department? GetById(int id)
        {
            return _context.Set<Department>().Find(id);
        }

        public Department? GetWithTicketsAndDevelopersById(int id)
        {
           return _context.Departments.Include(d => d.Tickets).ThenInclude(t => t.Developers).FirstOrDefault(d => d.Id == id);
        }
    }
}
