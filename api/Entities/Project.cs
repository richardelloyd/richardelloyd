namespace API.Entities
{
  public class Project
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatorId { get; set; }
  }
}
