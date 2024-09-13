using API.Data;
using API.Entities;

namespace API.Services
{
  public class ProjectsService : IProjectsService
  {
    private readonly DataContext _db;
    public ProjectsService(DataContext db)
    {
      _db = db;
    }

    public Task<Project?> AddProject(Project obj)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteHerosByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProjectByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Project>> GetAllHeros(bool? isActive)
    {
        throw new NotImplementedException();
    }

    public Task<List<Project>> GetAllProjects(bool? isActive)
    {
        throw new NotImplementedException();
    }

    public Task<Project?> GetHerosByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Project?> GetProjectByID(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Project?> UpdateProject(int id, Project obj)
    {
        throw new NotImplementedException();
    }
  }
}