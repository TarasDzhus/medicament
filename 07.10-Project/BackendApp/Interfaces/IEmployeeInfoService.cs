using BackendApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BackendApp.Interfaces
{
    public interface IEmployeeInfoService
    {
        public IEnumerable<EmployeeInfo> GetEmployeeInfo();
        public EmployeeInfo GetEmployeeInfoById(int id);
        public EmployeeInfo AddEmployeeInfo(EmployeeInfo employeeInfo);
        public EmployeeInfo UpdateEmployeeInfo(EmployeeInfo employeeInfo);
        public EmployeeInfo DeleteEmployeeInfo(int id);

        /*        public Task CreateEmployeeInfo(EmployeeInfo employeeInfo);
                public Task<List<EmployeeInfo>> ReadEmployeeInfos();
                public Task<EmployeeInfo> ReadEmployeeInfo(int id);
                public Task UpdateEmployeeInfo(EmployeeInfo employeeInfo);
                public Task<EmployeeInfo> DeleteEmployeeInfo(int id); */
    }
}
