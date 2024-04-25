using System;
using System.Collections.Generic;

namespace MidasDataAccess.Models;

public partial class FileManagement
{
    public string Id { get; set; } = null!;

    public string Path { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<CompanyCredit> CompanyCreditBoardOfManagementFileNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditCompanyRegistrationNumberFileNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditEstablishRegistrationNumberFileNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditFinancialStatementFileNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditIdentityNumberFileNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CompanyCredit> CompanyCreditNpwpfileNavigations { get; set; } = new List<CompanyCredit>();

    public virtual ICollection<CreditPayment> CreditPayments { get; set; } = new List<CreditPayment>();

    public virtual ICollection<CreditUpgrade> CreditUpgrades { get; set; } = new List<CreditUpgrade>();

    public virtual ICollection<IndividualCredit> IndividualCreditBusinessCertificateFileNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditDomicileFileNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditFamilyCardFileNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditIdentityCardFileNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<IndividualCredit> IndividualCreditIdentityCardSelfieFileNavigations { get; set; } = new List<IndividualCredit>();

    public virtual ICollection<Withdrawal> Withdrawals { get; set; } = new List<Withdrawal>();
}
