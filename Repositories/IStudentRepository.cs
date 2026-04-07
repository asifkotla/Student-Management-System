using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;

namespace Student_Management_System.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(Student student);
        Task<List<Student>> SearchByName(string name);

    }
    
}

