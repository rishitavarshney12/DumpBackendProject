using Employee.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Contracts
{
    public interface IEmpTableRepository
    {
        Task<List<EmpTable>> FetchBy(int empId);
        Task<short> Create(EmpTable empTable);
        Task<List<EmpTable>> FetchAll();
    }
}
