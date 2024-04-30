using System.Text;
using MidasBussines;
using MidasDataAccess.Models;

namespace MidasAPI;

public class FileManagementServices
{
    private readonly IFileManagementRepository _rep;

    public FileManagementServices(IFileManagementRepository rep)
    {
        _rep = rep;
    }

    public FileManagement GetFile (string id)
    {
        return _rep.Get(id);
    }

    public string Upload(FileInsertDTO dto)
    {
        var model = new FileManagement
        {
            Id = Guid.NewGuid().ToString(),
            Name = AddImage(dto.FileCategory, dto.File)
        };
        model.Path = dto.FileCategory+"/"+model.Name;
        _rep.Insert(model);
        return model.Id;
    }
    private string AddImage(string fileCategory, IFormFile file)
    {
        string uploadedFileName = Path.GetExtension(file.FileName);
        List<string> fileNameSplit = [.. uploadedFileName.Split('.')];
        string extension = fileNameSplit[^1];
        string fileName = fileCategory +"-"+ DateTime.Now.ToString("yyyyMMddHHmmssffff") +"."+ extension;
        string path = Path.Combine(Directory.GetCurrentDirectory(),"Files/"+fileCategory);
        if(!Directory.Exists(path)){
            DirectoryInfo di = Directory.CreateDirectory(path);
        }
        using FileStream stream = new FileStream(Path.Combine(path,fileName), FileMode.Create);
        file.CopyTo(stream);

        return fileName;
    }
}
