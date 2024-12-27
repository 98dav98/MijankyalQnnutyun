using Microsoft.Extensions.Options;
using MijankyalQnnutyun.Models;

namespace MijankyalQnnutyun.DataSeeder
{
    public class DataSeeder(
        DekanatDbContext context, 
        IOptions<StudentsSeedDataSettings> studentSeedDataSettings, 
        IOptions<LearningSeedDataSettings> learningSeedDataSettings,
        IOptions<FacultySeedDataSettings> facultySeedDataSettings
        )
    {
        private readonly DekanatDbContext _context = context;
        private readonly IOptions<StudentsSeedDataSettings> _studentSeedDataSettings = studentSeedDataSettings;
        private readonly IOptions<LearningSeedDataSettings> _learningSeedDataSettings = learningSeedDataSettings;
        private readonly IOptions<FacultySeedDataSettings> _facultySeedDataSettings = facultySeedDataSettings;

        public void SeedStudents()
        {
            if (!_context.Students.Any())
            {
                var students = _studentSeedDataSettings.Value.Students;
                _context.Students.AddRange(students);
                _context.SaveChanges();
            }
        }
        public void SeedFaculties()
        {
            if (!_context.Faculties.Any())
            {
                var faculty = _facultySeedDataSettings.Value.Faculties;
                _context.Faculties.AddRange(faculty);
                _context.SaveChanges();
            }
        }
        public void SeedLearnings()
        {
            if (!_context.Learnings.Any())
            {
                var learnings = _learningSeedDataSettings.Value.Learnings;
                _context.Learnings.AddRange(learnings);
                _context.SaveChanges();
            }
        }
    }
}
