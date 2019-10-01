using coreWebApiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebApiTest.Services
{
    public interface IEmployeeRepository
    {
        string empLogin<T>();
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();

        //offices
        Task<Office[]> GetOffices(bool includeJobDes = false);
        Task<Office> GetOffice(bool includeJobDes = false);
        Task<Office[]> GetOfficeByEmployee(int EmployeeId, bool includeJobDes = false);

        //employees
        Task<Employee[]> GetEmployees(bool includeJobDes = false);
        Task<Employee> GetEmployee(bool includeJobDes = false);
        Task<Employee[]> GetEmployeeByOffice(int OfficeId, bool includeJobDes = false);


        //Jobs
        Task<JobDes[]> GetJobDess(bool includeEmployee = false);
        Task<JobDes> GetJobDes(bool includeJobDes = false);
        Task<JobDes[]> GetJobDesByOffice(int EmployeeId, bool includeJobDes = false);
    }
}
