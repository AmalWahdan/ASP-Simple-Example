using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace System.DAL
{
    public interface IDeptRepo
    {
        IEnumerable<Department> GetAll();
        Department? GetById(int id);
        Department? GetWithTicketsAndDevelopersById(int id);
        

    }

}
