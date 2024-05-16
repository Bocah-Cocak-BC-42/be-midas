using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string NickName { get; set; } = null!;

    public string IdentityNumber { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string? BirthPlace { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? PhoneNumber { get; set; }

    public int? CreditScore { get; set; }

    public decimal? PersonalCreditLimit { get; set; }

    public decimal? CompanyCreditLimit { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string RoleId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<AssociateUserBranch> AssociateUserBranches { get; set; } = new List<AssociateUserBranch>();

    public virtual ICollection<Bank> BankCreatedByNavigations { get; set; } = new List<Bank>();

    public virtual ICollection<Bank> BankDeletedByNavigations { get; set; } = new List<Bank>();

    public virtual ICollection<Bank> BankUpdatedByNavigations { get; set; } = new List<Bank>();

    public virtual ICollection<BranchOffice> BranchOfficeCreatedByNavigations { get; set; } = new List<BranchOffice>();

    public virtual ICollection<BranchOffice> BranchOfficeDeletedByNavigations { get; set; } = new List<BranchOffice>();

    public virtual ICollection<BranchOffice> BranchOfficeUpdatedByNavigations { get; set; } = new List<BranchOffice>();

    public virtual ICollection<BusinessSector> BusinessSectorCreatedByNavigations { get; set; } = new List<BusinessSector>();

    public virtual ICollection<BusinessSector> BusinessSectorDeletedByNavigations { get; set; } = new List<BusinessSector>();

    public virtual ICollection<BusinessSector> BusinessSectorUpdatedByNavigations { get; set; } = new List<BusinessSector>();

    public virtual ICollection<City> CityCreatedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<City> CityDeletedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<City> CityUpdatedByNavigations { get; set; } = new List<City>();

    public virtual ICollection<CompanyCredit> CompanyCreditCompanyOwners { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditCreatedByNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditDeletedByNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditUpdatedByNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditVerifiedByNavigations { get; set; } = new List<CompanyCredit>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<CreditPayment> CreditPaymentCreatedByNavigations { get; set; } = new List<CreditPayment>();

    public virtual ICollection<CreditPayment> CreditPaymentDeletedByNavigations { get; set; } = new List<CreditPayment>();

    public virtual ICollection<CreditPayment> CreditPaymentUpdatedByNavigations { get; set; } = new List<CreditPayment>();

    public virtual ICollection<CreditPayment> CreditPaymentVerifiedByNavigations { get; set; } = new List<CreditPayment>();

    public virtual ICollection<CreditUpgrade> CreditUpgradeCreatedByNavigations { get; set; } = new List<CreditUpgrade>();

    public virtual ICollection<CreditUpgrade> CreditUpgradeDeletedByNavigations { get; set; } = new List<CreditUpgrade>();

    public virtual ICollection<CreditUpgrade> CreditUpgradeUpdatedByNavigations { get; set; } = new List<CreditUpgrade>();
    public virtual ICollection<CreditUpgrade> CreditUpgradeVerifiedByNavigations { get; set; } = new List<CreditUpgrade>();
    public virtual ICollection<CreditUpgrade> CreditUpgradeUsers { get; set; } = new List<CreditUpgrade>();

    public virtual User? DeletedByNavigation { get; set; }

    public virtual ICollection<IndividualCredit> IndividualCreditCreatedByNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditDeletedByNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditUpdatedByNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditUsers { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<User> InverseCreatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<User> InverseDeletedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<User> InverseUpdatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<Province> ProvinceCreatedByNavigations { get; set; } = new List<Province>();

    public virtual ICollection<Province> ProvinceDeletedByNavigations { get; set; } = new List<Province>();

    public virtual ICollection<Province> ProvinceUpdatedByNavigations { get; set; } = new List<Province>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<SubDistrict> SubDistrictCreatedByNavigations { get; set; } = new List<SubDistrict>();

    public virtual ICollection<SubDistrict> SubDistrictDeletedByNavigations { get; set; } = new List<SubDistrict>();

    public virtual ICollection<SubDistrict> SubDistrictUpdatedByNavigations { get; set; } = new List<SubDistrict>();

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual ICollection<Village> VillageCreatedByNavigations { get; set; } = new List<Village>();

    public virtual ICollection<Village> VillageDeletedByNavigations { get; set; } = new List<Village>();

    public virtual ICollection<Village> VillageUpdatedByNavigations { get; set; } = new List<Village>();

    public virtual ICollection<Withdrawal> WithdrawalCreatedByNavigations { get; set; } = new List<Withdrawal>();

    public virtual ICollection<Withdrawal> WithdrawalDeletedByNavigations { get; set; } = new List<Withdrawal>();

    public virtual ICollection<Withdrawal> WithdrawalUpdatedByNavigations { get; set; } = new List<Withdrawal>();

    public virtual ICollection<Withdrawal> WithdrawalVerifiedByNavigations { get; set; } = new List<Withdrawal>();
}
