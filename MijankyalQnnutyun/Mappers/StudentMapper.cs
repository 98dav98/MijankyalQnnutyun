using MijankyalQnnutyun.Dtos.Student;
using MijankyalQnnutyun.Models;

namespace MijankyalQnnutyun.Mappers
{
    public static class StudentMapper
    {
        public static Student ToStudentFromCreateDto(this CreateStudentRequest studentRequest)
        {
            return new Student
            {
                DateOfBirth = studentRequest.DateOfBirth,
                YearOfEnrollment = studentRequest.YearOfEnrollment,
                Nsf = studentRequest.Nsf,
                LearningId = studentRequest.LearningId
            };
        }
    }
}
