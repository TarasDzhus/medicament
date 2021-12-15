using BackendApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BackendApp.Interfaces;
using System.Linq;
using System;

namespace BackendApp.Services
{
    public class EmployeeInfoService : IEmployeeInfoService
    {

        private readonly DatabaseContext _dbContext;
        public EmployeeInfoService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            if (!_dbContext.EmployeeInfos.Any())
            {
                _dbContext.EmployeeInfos.Add(new EmployeeInfo { MaritalStatus = "Не одружений", BirthDate = new DateTime(1990, 04, 30), Address = "Житомирська 16", Phone = "(067)4564489" });
                _dbContext.EmployeeInfos.Add(new EmployeeInfo { MaritalStatus = "Одружений", BirthDate = new DateTime(1998, 06, 25), Address = "Малинова 15", Phone = "(050)0564585" });
                _dbContext.EmployeeInfos.Add(new EmployeeInfo { MaritalStatus = "Не одружений", BirthDate = new DateTime(1998, 11, 03), Address = "Миру 16", Phone = "(068)4560409" });
                _dbContext.EmployeeInfos.Add(new EmployeeInfo { MaritalStatus = "Не одружений", BirthDate = new DateTime(2000, 07, 27), Address = "Антоновича 11", Phone = "(066)4664466" });
                _dbContext.EmployeeInfos.Add(new EmployeeInfo { MaritalStatus = "Заміжня", BirthDate = new DateTime(1974, 05, 11), Address = "Макогона 10", Phone = "(093)4334493" });
                _dbContext.EmployeeInfos.Add(new EmployeeInfo { MaritalStatus = "Заміжня", BirthDate = new DateTime(1960, 08, 21), Address = "Петрівська 7", Phone = "(063)4114141" });
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<EmployeeInfo> GetEmployeeInfo()
        {
            var employeeInfo = _dbContext.EmployeeInfos.ToList();
            return employeeInfo;
        }
        public EmployeeInfo GetEmployeeInfoById(int id)
        {
            var employeeInfo = _dbContext.EmployeeInfos.FirstOrDefault(x => x.Id == id);
            return employeeInfo;
        }

        public EmployeeInfo AddEmployeeInfo(EmployeeInfo employeeInfo)
        {
            if (employeeInfo != null)
            {
                _dbContext.EmployeeInfos.Add(employeeInfo);
                _dbContext.SaveChanges();
                return employeeInfo;
            }
            return null;
        }
        public EmployeeInfo UpdateEmployeeInfo(EmployeeInfo employeeInfo)
        {
            _dbContext.Entry(employeeInfo).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return employeeInfo;
        }
        public EmployeeInfo DeleteEmployeeInfo(int id)
        {
            var employeeInfo = _dbContext.EmployeeInfos.FirstOrDefault(x => x.Id == id);
            _dbContext.Entry(employeeInfo).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return employeeInfo;
        }

        /*public async Task CreateEmployeeInfo(EmployeeInfo employeeInfo)
        {
            await _dbContext.EmployeeInfos.AddAsync(employeeInfo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<EmployeeInfo>> ReadEmployeeInfos()
        {
            return await _dbContext.EmployeeInfos.ToListAsync();
        }

        public async Task<EmployeeInfo> ReadEmployeeInfo(int id)
        {
            var employeeInfo = await _dbContext.EmployeeInfos.FindAsync(id);
            if (employeeInfo == null)
            {
                return NotFound();
            }
            return employeeInfo;
        }

        public async Task UpdateEmployeeInfo(EmployeeInfo employeeInfo)
        {
            _dbContext.Entry(employeeInfo).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<EmployeeInfo> DeleteEmployeeInfo(int id)
        {
            var employeeInfo = await _dbContext.EmployeeInfos.FindAsync(id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            _dbContext.EmployeeInfos.Remove(employeeInfo);
            await _dbContext.SaveChangesAsync();
            return employeeInfo;
        }*/
    }
}
