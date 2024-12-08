namespace MijankyalQnnutyun.Models;

public partial class Student
{
    public int Id { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateOnly? YearOfEnrollment { get; set; }

    public char? Nsf { get; set; }

    public char? City { get; set; }

    public int? LearningId { get; set; }

    public virtual Learning? Learning { get; set; }
}