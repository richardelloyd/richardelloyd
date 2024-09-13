using API.Data;
using API.Entities;

namespace API.Services
{
  public class DesignsService : IDesignsService
  {
    private readonly DataContext _db;
    public DesignsService(DataContext db)
    {
      _db = db;
    }

    public Task<Design?> AddDesign(Design obj)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteDesignByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Design>> GetAllDesigns(bool? isActive)
    {
        throw new NotImplementedException();
    }

    public Task<Design?> GetDesignByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Design?> UpdateDesign(int id, Design obj)
    {
        throw new NotImplementedException();
    }
  }  
}