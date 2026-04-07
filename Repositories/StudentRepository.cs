using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;

namespace Student_Management_System.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetAll()
            => await _context.Students.ToListAsync();

        public async Task<Student> GetById(int id)
            => await _context.Students.FindAsync(id);

        public async Task Add(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Student>> SearchByName(string name)
        {
            return await _context.Students
                .Where(s => s.Name.Contains(name))
                .ToListAsync();
        }
    }
}
