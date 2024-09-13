namespace API.Entities
{
  public class Design
  {
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Location { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatorId { get; set; }
  }
  
}