using Microsoft.Extensions.Options;
using MijankyalQnnutyun.Models;

namespace MijankyalQnnutyun.DataSeeder
{
    public class DataSeeder(DekanatDbContext context, IOptions<StudentsSeedDataSettings> seedDataSettings)
    {
        private readonly DekanatDbContext _context = context;
        private readonly IOptions<StudentsSeedDataSettings> _seedDataSettings = seedDataSettings;

        public void Seed()
        {
            if (!_context.Students.Any())
            {
                var students = _seedDataSettings.Value.Students;
                _context.Students.AddRange(students);
                _context.SaveChanges();
            }
        }
    }
}
