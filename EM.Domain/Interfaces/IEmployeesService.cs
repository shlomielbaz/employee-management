using EM.Domain.Entities;
using EM.Domain.ViewModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain.Interfaces
{
    public interface IEmployeesService: ICrudService<Employee>
    {
    }
}
