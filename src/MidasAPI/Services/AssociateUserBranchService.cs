using MidasAPI.DTOs.AssociateUserBranch;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI.Services;

public class AssociateUserBranchService
{
    private readonly IAssociateUserBranchRepository _associateRep;

    public AssociateUserBranchService(IAssociateUserBranchRepository associateRep)
    {
        _associateRep = associateRep;
    }
    public List<AssociateUserBranchResponseDTO> Get()=>
        _associateRep.Get()
        .Select(associate => new AssociateUserBranchResponseDTO(){
            Id = associate.Id,
            UserId = associate.UserId,
            BranchOfficeId = associate.BranchOfficeId,
        }).ToList();
    public AssociateUserBranch? Get(string id) =>
        _associateRep.Get(id);
    public void Insert(AssociateUserBranchInsertDTO req) =>
        _associateRep.Insert(new AssociateUserBranch{
            Id = Guid.NewGuid().ToString(),
            UserId = req.UserId,
            BranchOfficeId = req.BranchOfficeId
        });
    public void Update(AssociateUserBranchUpdateDTO req)
    {
        var model = _associateRep.Get(req.Id) ?? throw new Exception(ConstantConfigs.MESSAGE_NOT_FOUND("asosiasi karyawan dan kantor cabang"));
        model.UserId = req.UserId;
        model.BranchOfficeId = req.BranchOfficeId;

        _associateRep.Update(model);
    }
    public void Delete(string id) =>
        _associateRep.Delete(id);
}
