namespace MidasAPI.DTOs.FileManagaement;

public class FileInsertDTO
{
    public IFormFile File { get; set; } = null!;
    public string FileCategory { get; set; } = null!;
}
