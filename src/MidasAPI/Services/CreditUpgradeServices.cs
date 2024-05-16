using MidasAPI.DTOs;
using MidasBussines.Interfaces;
using MidasDataAccess.Models;

namespace MidasAPI;

public class CreditUpgradeServices
{
    private readonly ICreditUpgradeRepository _creditUpgradeRepository;
    private readonly IUserRepository _userRepository;

    public CreditUpgradeServices(ICreditUpgradeRepository creditUpgradeRepository, IUserRepository userRepository)
    {
        _creditUpgradeRepository = creditUpgradeRepository;
        _userRepository = userRepository;
    }

    private string GetIdentityNumber(string userId)
    {
        return _userRepository.GetById(userId).IdentityNumber;
    }

    private string CreateCreditUpgradeNumber(string userId)
    {
        string creditUpgradeNumber = "UK-";
        string identityNumber = GetIdentityNumber(userId)+"-";
        string submitDate = DateTime.Now.ToString("ddMMyyyy");
        return creditUpgradeNumber+identityNumber+submitDate;;
    }

    public void InsertCreditUpgrade(CreditUpgradeInsertDTO creditUpgrade, string userId)
    {
        _creditUpgradeRepository.Insert(new CreditUpgrade(){
            Id = Guid.NewGuid().ToString(),
            UserId = userId,
            CreditUpgradeNumber = CreateCreditUpgradeNumber(userId),
            MonthlyIncome = creditUpgrade.MonthlyIncome,
            AnnualBusinessGross = creditUpgrade.AnnualBusinessGross,
            ProfitBusinessGross = creditUpgrade.ProfitBusinessGross,
            Status = UpgradeCreditApprovalStatusConfig.WAITING_ADMIN_VERIFICATION,
            Notes = creditUpgrade.Notes,
            FinancialStatementFile = creditUpgrade.FinancialStatementFileId,
            CreatedBy = userId, 
            CreatedAt = DateTime.Now,
        });
    }

    public void EditCreditUpgrade(CreditUpgradeInsertDTO creditUpgrade, string creditUpgradeId, string userId)
    {
        var VerifiedBy = _creditUpgradeRepository.GetVerifiedBy(creditUpgradeId);
        var creditUpg = new CreditUpgrade(){
            Id = creditUpgradeId,
            UserId = userId,
            CreditUpgradeNumber = CreateCreditUpgradeNumber(userId),
            MonthlyIncome = creditUpgrade.MonthlyIncome,
            AnnualBusinessGross = creditUpgrade.AnnualBusinessGross,
            ProfitBusinessGross = creditUpgrade.ProfitBusinessGross,
            Notes = creditUpgrade.Notes,
            FinancialStatementFile = creditUpgrade.FinancialStatementFileId,
            CreatedBy = userId, 
            CreatedAt = DateTime.Now,
        };
        if(VerifiedBy.Role.Name == null) creditUpg.Status = UpgradeCreditApprovalStatusConfig.WAITING_ADMIN_VERIFICATION;
        if(VerifiedBy.Role.Name == "Admin") creditUpg.Status = UpgradeCreditApprovalStatusConfig.WAITING_SUPERFISOR_VERIFICATION;
        _creditUpgradeRepository.Update(creditUpg);
    }

    public CreditUpgradeResponseDTO Get(string creditUpgradeId)
    {
        var creditUpgrade = _creditUpgradeRepository.Get(creditUpgradeId);
        return new CreditUpgradeResponseDTO(){
            Id = creditUpgrade.Id,
            UserId = creditUpgrade.UserId,
            FullName = creditUpgrade.User.FullName,
            CreditUpgradeNumber = creditUpgrade.CreditUpgradeNumber,
            MonthlyIncome = creditUpgrade.MonthlyIncome,
            AnnualBusinessGross = creditUpgrade.AnnualBusinessGross,
            ProfitBusinessGross = creditUpgrade.ProfitBusinessGross,
            Status = creditUpgrade.Status,
            Notes = creditUpgrade.Notes,
            FinancialStatementFile = creditUpgrade.FinancialStatementFile,
            CreatedAt = creditUpgrade.CreatedAt,
            UpdatedAt = creditUpgrade.UpdatedAt,
            VerifiedBy = creditUpgrade.VerifiedBy,
            VerifiedById = creditUpgrade?.VerifiedByNavigation?.FullName,
            VerifiedAt = creditUpgrade?.VerifiedAt
        };
    }

    public CreditUpgradeListResDTO GetCreditUpgradesCustomer(string userId)
    {
        var creditUpgrades = _creditUpgradeRepository.GetCreditUpgradesCustomer(userId);
        return new CreditUpgradeListResDTO(){
            CreditUpgrades = creditUpgrades.Select(c => new CreditUpgradeResponseDTO(){
                Id = c.Id,
                UserId = c.UserId,
                FullName = c.User.FullName,
                CreditUpgradeNumber = c.CreditUpgradeNumber,
                MonthlyIncome = c.MonthlyIncome,
                AnnualBusinessGross = c.AnnualBusinessGross,
                ProfitBusinessGross = c.ProfitBusinessGross,
                Status = c.Status,
                Notes = c.Notes,
                FinancialStatementFile = c.FinancialStatementFile,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                VerifiedById = c.VerifiedBy,
                VerifiedBy = c?.VerifiedByNavigation?.FullName,
                VerifiedAt = c?.VerifiedAt
            }).ToList(),
        };
    }

    public PaginationDTO CreditUpgradePagination(string role, int page, int pageSize)
    {
        var creditUpgrades = new List<CreditUpgrade>();
        if(role == "Admin"){
            creditUpgrades = _creditUpgradeRepository.GetCreditUpgradeAdmin(page, pageSize);
        }else if(role == "Supervisor"){
            creditUpgrades = _creditUpgradeRepository.GetCreditUpgradeSupervisor(page, pageSize);
        }
        return new PaginationDTO(){
            Page = page,
            PageSize = pageSize,
            TotalData = creditUpgrades.Count,
        };
    }

    public CreditUpgradeListResDTO GetCreditUpgrades(string role, int page, int pageSize)
    {
        var creditUpgrades = new List<CreditUpgrade>();
        if(role == "Admin"){
            creditUpgrades = _creditUpgradeRepository.GetCreditUpgradeAdmin(page, pageSize);
        }else if(role == "Supervisor"){
            creditUpgrades = _creditUpgradeRepository.GetCreditUpgradeSupervisor(page, pageSize);
        }
        return new CreditUpgradeListResDTO(){
            CreditUpgrades = creditUpgrades.Select(c => new CreditUpgradeResponseDTO(){
                Id = c.Id,
                UserId = c.UserId,
                FullName = c.User.FullName,
                CreditUpgradeNumber = c.CreditUpgradeNumber,
                MonthlyIncome = c.MonthlyIncome,
                AnnualBusinessGross = c.AnnualBusinessGross,
                ProfitBusinessGross = c.ProfitBusinessGross,
                Status = c.Status,
                Notes = c.Notes,
                FinancialStatementFile = c.FinancialStatementFile,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                VerifiedById = c.VerifiedBy,
                VerifiedBy = c?.VerifiedByNavigation?.FullName,
                VerifiedAt = c?.VerifiedAt
            }).ToList(),
        };
    }

    public void ApproveCreditUpgrade(string userId, string role, ApproveCreditUpgradeDTO dto)
    {
        var creditUpgrade = _creditUpgradeRepository.Get(dto.CreditUpgradeId);
        creditUpgrade.VerifiedBy = userId;
        creditUpgrade.VerifiedAt = DateTime.Now;
        if(role == "Supervisor") creditUpgrade.Status = UpgradeCreditApprovalStatusConfig.APPROVED;
        else if(role == "Admin") creditUpgrade.Status = UpgradeCreditApprovalStatusConfig.WAITING_SUPERFISOR_VERIFICATION;
        _creditUpgradeRepository.Update(creditUpgrade);
    }

    public void RejectCreditUpgrade(RejectCreditUpgradeDTO dto)
    {
        var creditUpgrade = _creditUpgradeRepository.Get(dto.CreditUpgradeId);
        creditUpgrade.Notes = dto.Notes;
        creditUpgrade.Status = UpgradeCreditApprovalStatusConfig.REJECTED;
        _creditUpgradeRepository.Update(creditUpgrade);
    }
}
