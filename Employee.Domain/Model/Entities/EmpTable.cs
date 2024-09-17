using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Model.Entities
{
    [Table("EmpTable")]
    public class EmpTable
    {
        [Key]
        public short EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Int32 ContactNo { get; set; }
         public string Department { get; set; }

    }
}
