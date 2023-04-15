using System;
using System.BL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.BL
{
    public interface IDeptManager
    {
        public DepartmentDtos GetDepartmentById(int id);
    }

}
