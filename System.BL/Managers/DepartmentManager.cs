using Microsoft.EntityFrameworkCore;
using System;
using System.BL;
using System.Collections.Generic;
using System.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public class DepartmentManager : IDeptManager
    {
        
        private readonly IDeptRepo _deptRepo;
        public DepartmentManager(IDeptRepo deptRepo)
        {
            _deptRepo= deptRepo;
        }

        public DepartmentDtos GetDepartmentById(int id)
        {
           var department = _deptRepo.GetWithTicketsAndDevelopersById(id);
        
       
        
        var ticketsDtos = department.Tickets.Select(t => new TicketsDtos
        {
            Id = t.Id,
            Description = t.Description,
            DevelopersCount = t.Developers.Count
        }).ToList();
        
        var departmentDTO = new DepartmentDtos
        {
            Id = department.Id,
            Name = department.Name,
            Tickets = ticketsDtos
        };
        
        return departmentDTO;
        }
    }
}
