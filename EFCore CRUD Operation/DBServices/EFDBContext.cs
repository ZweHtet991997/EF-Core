using EFCore_CRUD_Operation.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CRUD_Operation.DBServices
{
    public class EFDBContext : DbContext
    {
        public EFDBContext(DbContextOptions options) : base(options) { }
        public DbSet<EmployeeEntities> Employees { get; set; }

        internal Task<EmployeeEntities> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
