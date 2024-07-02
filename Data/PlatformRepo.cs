using PlatformService.Models;

namespace PlatformService.Data;

public class PlatformRepo(AppDbContext context ) : IPlatformRepo
{
    private readonly AppDbContext _context = context;
    public bool SaveChanges()
    {
       return _context.SaveChanges() >= 0;
    }
    public IEnumerable<Platform> GetAllPlatforms()
    {
        return _context.Platforms.ToList();
    }
    public Platform GetPlatform(String Id)
    {
        return _context.Platforms.FirstOrDefault(p => p.Id == Id);
    }
    public void CreatePlatform(Platform platform)
    {
        ArgumentNullException.ThrowIfNull(platform, nameof(Platform));
        _context.Platforms.Add(platform);
    }
}