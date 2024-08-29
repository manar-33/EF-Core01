using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core01.Entities
{
    [Table("MyDepartments")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Inst_Id { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
