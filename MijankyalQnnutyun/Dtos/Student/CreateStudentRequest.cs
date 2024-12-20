namespace MijankyalQnnutyun.Dtos.Student
{
    public class CreateStudentRequest
    {
        public DateOnly? DateOfBirth { get; set; }

        public DateOnly? YearOfEnrollment { get; set; }

        public char? Nsf { get; set; }

        public char? City { get; set; }

        public int? LearningId { get; set; }
    }
}
