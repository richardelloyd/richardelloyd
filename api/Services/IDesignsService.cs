using API.Entities;

namespace API.Services
{
    public interface IDesignsService
    {
        Task<List<Design>> GetAllDesigns(bool? isActive);
        Task<Design?> GetDesignByID(int id);
        Task<Design?> AddDesign(Design obj);
        Task<Design?> UpdateDesign(int id, Design obj);
        Task<bool> DeleteDesignByID(int id);
    }
}