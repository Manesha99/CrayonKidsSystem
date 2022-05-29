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
        Task<Employee> GetEmployeeAsync(int EmployeeId);
        Task<Student[]> GetAllStudentsAsync();
        Task<Student> GetStudentAsync( int StudentId);
        Task<School[]> GetAllSchoolsAsync();
        Task<School> GetSchoolAsync(int SchoolId);
        Task<Assessment[]> GetAllAssessmentsAsync();
        Task<Assessment> GetAssessmentAsync(int AssessmentId);
        Task<Allergy[]> GetAllAllergiesAsync();
        Task<Allergy> GetAllergyAsync(int AllergyId);


    }
}
