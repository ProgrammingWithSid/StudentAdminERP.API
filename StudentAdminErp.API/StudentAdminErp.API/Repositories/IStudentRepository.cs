
using StudentAdminErp.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminErp.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
