using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_CRUD_Operation.Models
{
    [Table("Tbl_Emp")]
    public class EmployeeEntities
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
