using API.Entities;

namespace API.Services
{
    public interface IProjectsService
    {
        Task<List<Project>> GetAllProjects(bool? isActive);
        Task<Project?> GetProjectByID(int id);
        Task<Project?> AddProject(Project obj);
        Task<Project?> UpdateProject(int id, Project obj);
        Task<bool> DeleteProjectByID(int id);
    }
}