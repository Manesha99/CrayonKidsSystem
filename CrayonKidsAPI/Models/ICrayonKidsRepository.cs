using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.Models
{
    public interface ICrayonKidsRepository
    {

        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;


        Task<bool> SaveChangesAsync();
        Task<Employee[]> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeAsync(string name);
        Task<Student[]> GetAllStudentsAsync();
        Task<Student> GetStudentAsync();

    }
}
