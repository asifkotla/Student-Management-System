using Student_Management_System.Models;

namespace Student_Management_System.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<List<Student>> SearchByName(string name);
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
