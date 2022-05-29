

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.Models
{
    public class CrayonKidsRepository : ICrayonKidsRepository
    {

        private readonly CrayonKidsContext _crayonKidsContext;

        public CrayonKidsRepository(CrayonKidsContext crayonKidsContext)
        {
            _crayonKidsContext = crayonKidsContext;
        }
        public void Add<T>(T entity) where T : class
        {
            _crayonKidsContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _crayonKidsContext.Remove(entity);
        }

        public async Task<Allergy[]> GetAllAllergiesAsync()
        {
            IQueryable<Allergy> query = _crayonKidsContext.Allergies;
            return await query.ToArrayAsync();
        }

        public async Task<Assessment[]> GetAllAssessmentsAsync()
        {
            IQueryable<Assessment> query = _crayonKidsContext.Assessments;
            return await query.ToArrayAsync();
        }

        public async Task<Employee[]> GetAllEmployeesAsync()
        {
            IQueryable<Employee> query = _crayonKidsContext.Employees;
            return await query.ToArrayAsync();
        }

        public async Task<Allergy> GetAllergyAsync(int AllergyId)
        {
            IQueryable<Allergy> query = _crayonKidsContext.Allergies.Where(c => c.AllergyId == AllergyId);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<School[]> GetAllSchoolsAsync()
        {
            IQueryable<School> query = _crayonKidsContext.Schools;
            return await query.ToArrayAsync();
        }

        public async Task<Student[]> GetAllStudentsAsync()
        {
            IQueryable<Student> query = _crayonKidsContext.Students;
            return await query.ToArrayAsync();
        }

        public async Task<Assessment> GetAssessmentAsync(int AssessmentId)
        {
            IQueryable<Assessment> query = _crayonKidsContext.Assessments.Where(c => c.AssessmentId == AssessmentId);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Employee> GetEmployeeAsync(int EmployeeId)
        {
            IQueryable<Employee> query = _crayonKidsContext.Employees.Where(c => c.EmployeeId == EmployeeId);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<School> GetSchoolAsync(int SchoolId)
        {
            IQueryable<School> query = _crayonKidsContext.Schools.Where(c => c.SchoolId == SchoolId);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Student> GetStudentAsync(int StudentId)
        {
            IQueryable<Student> query = _crayonKidsContext.Students.Where(c => c.StudentId == StudentId);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _crayonKidsContext.SaveChangesAsync()>0;
        }
    }
}
