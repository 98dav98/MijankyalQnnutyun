namespace MijankyalQnnutyun.Models;

public partial class Learning
{
    public int Id { get; set; }

    public int? ScholarshipAmount { get; set; }

    public int? Year { get; set; }

    public char? Speciality { get; set; }

    public char? Group { get; set; }

    public virtual ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
public class LearningSeedDataSettings
{
    public List<Learning> Learnings { get; set; }
}