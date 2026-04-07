using Student_Management_System.Models;
using Student_Management_System.Repositories;

namespace Student_Management_System.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetStudents()
            => await _repo.GetAll();

        public async Task AddStudent(Student student)
        {
            student.CreatedDate = DateTime.Now;
            await _repo.Add(student);
        }

        public async Task UpdateStudent(Student student)
        {
            var existing = await _repo.GetById(student.Id);
            if (existing == null) throw new Exception("Student not found");

            existing.Name = student.Name;
            existing.Email = student.Email;
            existing.Age = student.Age;
            existing.Course = student.Course;

            await _repo.Update(existing);
        }

        public async Task DeleteStudent(int id)
        {
            var student = await _repo.GetById(id);
            if (student == null) throw new Exception("Student not found");

            await _repo.Delete(student);
        }
        public async Task<Student> GetStudentById(int id)
        {
            var student = await _repo.GetById(id);
            if (student == null)
                throw new Exception("Student not found");

            return student;
        }

        public async Task<List<Student>> SearchByName(string name)
        {
            return await _repo.SearchByName(name);
        }
    }
}
