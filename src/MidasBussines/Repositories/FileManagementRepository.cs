using MidasDataAccess.Models;

namespace MidasBussines;

public class FileManagementRepository : IFileManagementRepository
{

    private readonly MidasContext _context;

    public FileManagementRepository(MidasContext context)
    {
        _context = context;
    }

    public void Insert(FileManagement req)
    {
        try
        {
            _context.FileManagements.Add(req);
            _context.SaveChanges();
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}
