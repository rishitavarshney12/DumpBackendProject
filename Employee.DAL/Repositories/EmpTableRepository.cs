using Employee.Domain.Contracts;
using Employee.Domain.Model.Entities;
using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employee.DAL.Repositories
{
    public  class EmpTableRepository : IEmpTableRepository
    {
        private readonly EmployeeServiceContext _context;

        public EmpTableRepository(EmployeeServiceContext context) 
        {
            _context = context;
        } 
        public async Task<List<EmpTable>> FetchBy(int empId)
        {
            return await _context.EmpTable.Where(x=> x.EmpId == empId).ToListAsync();
            
        }
        public async Task<List<EmpTable>> FetchAll()
        {
            return await _context.EmpTable.ToListAsync();

        }
        public async Task<short> Create(EmpTable empTable)
        {
            _context.EmpTable.Add(empTable);

            var affectedRows = await _context.SaveChangesAsync();
            if (affectedRows <= 0) throw new Exception("Unable to create Employee");
            return empTable.EmpId;
        }
    }
}
