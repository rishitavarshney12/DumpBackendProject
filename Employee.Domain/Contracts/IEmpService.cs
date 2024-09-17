using Employee.Domain.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Contracts
{
    public interface IEmpService
    {
        Task<List<EmpTableDto>> GetBy(int id);
        Task<short> Save(EmpTableDto empTableDto);
        Task<List<EmpTableDto>> GetAll();
    }
}
