using EFCore_CRUD_Operation.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CRUD_Operation.DBServices
{
    public class EmployeeDBService
    {
        private EFDBContext _dbContext;

        public EmployeeDBService(EFDBContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<int> Create(EmployeeModel model)
        {
            try
            {
                #region ExchangeData
                EmployeeEntities entities = new EmployeeEntities();
                entities.EmployeeID = model.EmployeeID;
                entities.FullName = model.FullName;
                entities.Email = model.Email;
                entities.PhoneNumber = model.PhoneNumber;
                entities.Office = model.Office;
                entities.Department = model.Department;
                entities.CreatedDate = DateTime.UtcNow.Date;
                #endregion

                await _dbContext.Employees.AddAsync(entities);
                return await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<EmployeeModel>> GetEmployee()
        {
            try
            {
                return await _dbContext.Employees.Select(x => new EmployeeModel
                {
                    Id = x.Id,
                    EmployeeID = x.EmployeeID,
                    FullName = x.FullName,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber,
                    Office = x.Office,
                    Department = x.Department,
                    CreatedDate = x.CreatedDate,
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Update(EmployeeModel model)
        {
            try
            {
                EmployeeEntities entities = new EmployeeEntities();
                entities = await _dbContext.Employees.FindAsync(model.Id);
                if (entities != null)
                {
                    entities.Id = model.Id;
                    entities.EmployeeID = model.EmployeeID;
                    entities.FullName = model.FullName;
                    entities.Email = model.Email;
                    entities.PhoneNumber = model.PhoneNumber;
                    entities.Office = model.Office;
                    entities.Department = model.Department;
                    entities.UpdatedDate = DateTime.UtcNow.Date;

                    _dbContext.Update(entities);
                    return await _dbContext.SaveChangesAsync();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> Delete(int Id)
        {
            try
            {
                EmployeeEntities entities = new EmployeeEntities();
                entities = await _dbContext.Employees.FindAsync(Id);
                if (entities != null)
                {
                    _dbContext.Employees.Remove(entities);
                    return await _dbContext.SaveChangesAsync();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
