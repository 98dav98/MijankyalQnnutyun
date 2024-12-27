namespace MijankyalQnnutyun.Models;

public partial class Faculty
{
    public int Id { get; set; }

    public int? NumberOfSeats { get; set; }

    public char? Name { get; set; }

    public char? Dekan { get; set; }

    public int? LearningId { get; set; }

    public virtual Learning? Learning { get; set; }
}
public class FacultySeedDataSettings
{
    public List<Faculty> Faculties { get; set; }
}