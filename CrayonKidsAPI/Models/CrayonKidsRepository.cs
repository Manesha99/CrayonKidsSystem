

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

        public async Task<Employee[]> GetAllEmployeesAsync()
        {
            IQueryable<Employee> query = _crayonKidsContext.Employees;
            return await query.ToArrayAsync();
        }

        public async Task<Student[]> GetAllStudentsAsync()
        {
            IQueryable<Student> query = _crayonKidsContext.Students;
            return await query.ToArrayAsync();
        }

        public async Task<Employee> GetEmployeeAsync(string name)
        {
            IQueryable<Employee> query = _crayonKidsContext.Employees.Where(c => c.Name == name);
            return await query.FirstOrDefaultAsync();
        }

        public Task<Student> GetStudentAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _crayonKidsContext.SaveChangesAsync()>0;
        }
    }
}
