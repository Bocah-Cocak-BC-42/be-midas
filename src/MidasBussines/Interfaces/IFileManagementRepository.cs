using MidasDataAccess.Models;

namespace MidasBussines;

public interface IFileManagementRepository
{
    void Insert(FileManagement req);
}
