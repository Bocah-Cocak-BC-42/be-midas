using MidasDataAccess.Models;

namespace MidasBussines.Interfaces;

public interface IFileManagementRepository
{
    void Insert(FileManagement req);
    FileManagement? Get (string id);
}
