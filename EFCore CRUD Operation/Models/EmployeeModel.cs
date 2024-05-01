namespace EFCore_CRUD_Operation.Models
{
    public class EmployeeModel
    {
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
