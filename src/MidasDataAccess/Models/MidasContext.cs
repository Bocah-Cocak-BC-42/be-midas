using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MidasDataAccess.Seeders;

namespace MidasDataAccess.Models;

public partial class MidasContext : DbContext
{
    public MidasContext()
    {
    }

    public MidasContext(DbContextOptions<MidasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AssociateUserBranch> AssociateUserBranches { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BranchOffice> BranchOffices { get; set; }

    public virtual DbSet<BusinessOwnerDetail> BusinessOwnerDetails { get; set; }

    public virtual DbSet<BusinessSector> BusinessSectors { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CompanyAsset> CompanyAssets { get; set; }

    public virtual DbSet<CompanyCredit> CompanyCredits { get; set; }

    public virtual DbSet<CreditPayment> CreditPayments { get; set; }

    public virtual DbSet<CreditUpgrade> CreditUpgrades { get; set; }

    public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; }

    public virtual DbSet<FileManagement> FileManagements { get; set; }

    public virtual DbSet<IndividualCredit> IndividualCredits { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SubDistrict> SubDistricts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Village> Villages { get; set; }

    public virtual DbSet<Withdrawal> Withdrawals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(DbContextConnectionConfig.ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssociateUserBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Associat__3214EC074CF4ADD5");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchOfficeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BranchOffice).WithMany(p => p.AssociateUserBranches)
                .HasForeignKey(d => d.BranchOfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Associate__Branc__628FA481");

            entity.HasOne(d => d.User).WithMany(p => p.AssociateUserBranches)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Associate__UserI__619B8048");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Banks__3214EC073E0B7FAD");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BankCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Banks__CreatedBy__5441852A");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.BankDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Banks__DeletedBy__571DF1D5");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.BankUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Banks__UpdatedBy__5629CD9C");
        });

        modelBuilder.Entity<BranchOffice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchOf__3214EC07754AD330");

            entity.HasIndex(e => e.OfficeCode, "UQ__BranchOf__16F536C6D42E8226").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfficeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OfficeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VillageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BranchOfficeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BranchOff__Creat__5BE2A6F2");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.BranchOfficeDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__BranchOff__Delet__5EBF139D");

            entity.HasOne(d => d.Village).WithMany(p => p.BranchOffices)
                .HasForeignKey(d => d.VillageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BranchOff__Vill__5AEE82B9");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.BranchOfficeUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__BranchOff__Updat__5DCAEF64");
        });

        modelBuilder.Entity<BusinessOwnerDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Business__3214EC07B6A1C06A");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeIdentityNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentityNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Company).WithMany(p => p.BusinessOwnerDetails)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BusinessO__Compa__10566F31");
        });

        modelBuilder.Entity<BusinessSector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Business__3214EC07B146A0B6");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BusinessSectorCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BusinessS__Creat__656C112C");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.BusinessSectorDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__BusinessS__Delet__68487DD7");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.BusinessSectorUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__BusinessS__Updat__6754599E");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC078ECFC12C");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProvinceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CityCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cities__CreatedB__3A81B327");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.CityDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Cities__DeletedB__3D5E1FD2");

            entity.HasOne(d => d.Province).WithMany(p => p.Cities)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cities__Province__398D8EEE");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CityUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Cities__UpdatedB__3C69FB99");
        });

        modelBuilder.Entity<CompanyAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyA__3214EC0788905132");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Value).HasColumnType("money");

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyAssets)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyAs__Compa__1332DBDC");
        });

        modelBuilder.Entity<CompanyCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CompanyC__3214EC07AE1E45A9");

            entity.HasIndex(e => e.CreditApplicationNumber, "UQ__CompanyC__5473C74C9619A32C").IsUnique();

            entity.HasIndex(e => e.Npwp, "UQ__CompanyC__E542917DCD57F910").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationAmount).HasColumnType("money");
            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.BoardOfManagementFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchOfficeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyOwnerId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyRegistrationNumber)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.CompanyRegistrationNumberFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreditApplicationNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreditEndDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstablishRegistrationNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EstablishRegistrationNumberFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinancialStatementFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentityNumberFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.Npwp)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("NPWP");
            entity.Property(e => e.Npwpfile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPWPFile");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfEstasblishment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VillageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerifiedAt).HasColumnType("datetime");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BoardOfManagementFileNavigation).WithMany(p => p.CompanyCreditBoardOfManagementFileNavigations)
                .HasForeignKey(d => d.BoardOfManagementFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Board__07C12930");

            entity.HasOne(d => d.BranchOffice).WithMany(p => p.CompanyCredits)
                .HasForeignKey(d => d.BranchOfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Branc__02FC7413");

            entity.HasOne(d => d.CompanyOwner).WithMany(p => p.CompanyCreditCompanyOwners)
                .HasForeignKey(d => d.CompanyOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Compa__02084FDA");

            entity.HasOne(d => d.CompanyRegistrationNumberFileNavigation).WithMany(p => p.CompanyCreditCompanyRegistrationNumberFileNavigations)
                .HasForeignKey(d => d.CompanyRegistrationNumberFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Compa__04E4BC85");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CompanyCreditCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Creat__09A971A2");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.CompanyCreditDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__CompanyCr__Delet__0C85DE4D");

            entity.HasOne(d => d.EstablishRegistrationNumberFileNavigation).WithMany(p => p.CompanyCreditEstablishRegistrationNumberFileNavigations)
                .HasForeignKey(d => d.EstablishRegistrationNumberFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Estab__03F0984C");

            entity.HasOne(d => d.FinancialStatementFileNavigation).WithMany(p => p.CompanyCreditFinancialStatementFileNavigations)
                .HasForeignKey(d => d.FinancialStatementFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Finan__08B54D69");

            entity.HasOne(d => d.IdentityNumberFileNavigation).WithMany(p => p.CompanyCreditIdentityNumberFileNavigations)
                .HasForeignKey(d => d.IdentityNumberFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Ident__06CD04F7");

            entity.HasOne(d => d.NpwpfileNavigation).WithMany(p => p.CompanyCreditNpwpfileNavigations)
                .HasForeignKey(d => d.Npwpfile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__NPWPF__05D8E0BE");

            entity.HasOne(d => d.Village).WithMany(p => p.CompanyCredits)
                .HasForeignKey(d => d.VillageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CompanyCr__Vill__01142BA1");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CompanyCreditUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__CompanyCr__Updat__0B91BA14");

            entity.HasOne(d => d.VerifiedByNavigation).WithMany(p => p.CompanyCreditVerifiedByNavigations)
                .HasForeignKey(d => d.VerifiedBy)
                .HasConstraintName("FK__CompanyCr__Verif__0D7A0286");
        });

        modelBuilder.Entity<CreditPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CreditPa__3214EC075A0D5231");

            entity.HasIndex(e => e.PaymentBilling, "UQ__CreditPa__5F8E21DE1FCC2FB3").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCreditId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndividualCreditId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.PaymentBilling)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerifiedAt).HasColumnType("datetime");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CompanyCredit).WithMany(p => p.CreditPayments)
                .HasForeignKey(d => d.CompanyCreditId)
                .HasConstraintName("FK__CreditPay__Compa__17F790F9");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CreditPaymentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CreditPay__Creat__19DFD96B");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.CreditPaymentDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__CreditPay__Delet__1CBC4616");

            entity.HasOne(d => d.IndividualCredit).WithMany(p => p.CreditPayments)
                .HasForeignKey(d => d.IndividualCreditId)
                .HasConstraintName("FK__CreditPay__Indiv__17036CC0");

            entity.HasOne(d => d.ReceiptFileNavigation).WithMany(p => p.CreditPayments)
                .HasForeignKey(d => d.ReceiptFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CreditPay__Recei__18EBB532");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CreditPaymentUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__CreditPay__Updat__1BC821DD");

            entity.HasOne(d => d.VerifiedByNavigation).WithMany(p => p.CreditPaymentVerifiedByNavigations)
                .HasForeignKey(d => d.VerifiedBy)
                .HasConstraintName("FK__CreditPay__Verif__1DB06A4F");
        });

        modelBuilder.Entity<CreditUpgrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CreditUp__3214EC070C13F416");

            entity.HasIndex(e => e.CreditUpgradeNumber, "UQ__CreditUp__6FC6D8937441A792").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AnnualBusinessGross).HasColumnType("money");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreditUpgradeNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinancialStatementFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MonthlyIncome).HasColumnType("money");
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ProfitBusinessGross).HasColumnType("money");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CreditUpgradeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CreditUpg__Creat__2DE6D218");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.CreditUpgradeDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__CreditUpg__Delet__30C33EC3");

            entity.HasOne(d => d.FinancialStatementFileNavigation).WithMany(p => p.CreditUpgrades)
                .HasForeignKey(d => d.FinancialStatementFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CreditUpg__Finan__2CF2ADDF");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.CreditUpgradeUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__CreditUpg__Updat__2FCF1A8A");

            entity.HasOne(d => d.User).WithMany(p => p.CreditUpgradeUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CreditUpg__UserI__2BFE89A6");
        });

        modelBuilder.Entity<EmergencyContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Emergenc__3214EC0771E679C6");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndividualCreditId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Relative)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IndividualCredit).WithMany(p => p.EmergencyContacts)
                .HasForeignKey(d => d.IndividualCreditId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Emergency__Indiv__31B762FC");
        });

        modelBuilder.Entity<FileManagement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FileMana__3214EC074EBF133F");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IndividualCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Individu__3214EC07B8A14867");

            entity.HasIndex(e => e.CreditApplicationNumber, "UQ__Individu__5473C74C2A8121B5").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationAmount).HasColumnType("money");
            entity.Property(e => e.ApplicationDate).HasColumnType("datetime");
            entity.Property(e => e.BranchOfficeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BusinessCertificateFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.BusinessPlaceStatus)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.BusinessVillage)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BusinessSectorId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreditApplicationNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreditEndDate).HasColumnType("datetime");
            entity.Property(e => e.CreditStartDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DomicileFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FamilyCardFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FamilyCardNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.IdentityCardFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentityCardSelfieFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Note).IsUnicode(false);
            entity.Property(e => e.VillageId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BranchOffice).WithMany(p => p.IndividualCredits)
                .HasForeignKey(d => d.BranchOfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Branc__71D1E811");

            entity.HasOne(d => d.BusinessCertificateFileNavigation).WithMany(p => p.IndividualCreditBusinessCertificateFileNavigations)
                .HasForeignKey(d => d.BusinessCertificateFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Busin__76969D2E");

            entity.HasOne(d => d.BusinessVillageNavigation).WithMany(p => p.IndividualCreditBusinessVillageNavigations)
                .HasForeignKey(d => d.BusinessVillage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Busin__70DDC3D8");

            entity.HasOne(d => d.BusinessSector).WithMany(p => p.IndividualCredits)
                .HasForeignKey(d => d.BusinessSectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Busin__6FE99F9F");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IndividualCreditCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Creat__778AC167");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.IndividualCreditDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Individua__Delet__7A672E12");

            entity.HasOne(d => d.DomicileFileNavigation).WithMany(p => p.IndividualCreditDomicileFileNavigations)
                .HasForeignKey(d => d.DomicileFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Domic__72C60C4A");

            entity.HasOne(d => d.FamilyCardFileNavigation).WithMany(p => p.IndividualCreditFamilyCardFileNavigations)
                .HasForeignKey(d => d.FamilyCardFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Famil__75A278F5");

            entity.HasOne(d => d.IdentityCardFileNavigation).WithMany(p => p.IndividualCreditIdentityCardFileNavigations)
                .HasForeignKey(d => d.IdentityCardFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Ident__73BA3083");

            entity.HasOne(d => d.IdentityCardSelfieFileNavigation).WithMany(p => p.IndividualCreditIdentityCardSelfieFileNavigations)
                .HasForeignKey(d => d.IdentityCardSelfieFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Ident__74AE54BC");

            entity.HasOne(d => d.Village).WithMany(p => p.IndividualCreditVillages)
                .HasForeignKey(d => d.VillageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__Vill__6EF57B66");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.IndividualCreditUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Individua__Updat__797309D9");

            entity.HasOne(d => d.User).WithMany(p => p.IndividualCreditUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Individua__UserI__6E01572D");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Province__3214EC07115CA759");

            entity.HasIndex(e => e.Name, "UQ__Provinces").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProvinceCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Provinces__Creat__33D4B598");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.ProvinceDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Provinces__Delet__36B12243");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.ProvinceUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Provinces__Updat__35BCFE0A");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC077DFD2452");

            entity.HasIndex(e => e.Name, "UQ__Roles").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<SubDistrict>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubDistr__3214EC073B248931");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.City).WithMany(p => p.SubDistricts)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SubDistri__CityI__403A8C7D");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SubDistrictCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SubDistri__Creat__412EB0B6");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.SubDistrictDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__SubDistri__Delet__440B1D61");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.SubDistrictUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__SubDistri__Updat__4316F928");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC0779B1C58E");

            entity.HasIndex(e => e.IdentityNumber, "UQ__Users__6354A73FEFBA1441").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534726D34FB").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCreditLimit).HasColumnType("money");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdentityNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password).IsUnicode(false);
            entity.Property(e => e.PersonalCreditLimit).HasColumnType("money");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InverseCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__CreatedBy__2B3F6F97");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.InverseDeletedByNavigation)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Users__DeletedBy__2E1BDC42");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__RoleId__2A4B4B5E");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.InverseUpdatedByNavigation)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Users__UpdatedBy__2D27B809");
        });

        modelBuilder.Entity<Village>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Villages__3214EC07FF9CFCDC");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubDistrictId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.VillageCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Villages__Create__47DBAE45");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.VillageDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Villages__Delete__4AB81AF0");

            entity.HasOne(d => d.SubDistrict).WithMany(p => p.Villages)
                .HasForeignKey(d => d.SubDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Villages__SubDis__46E78A0C");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.VillageUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Villages__Update__49C3F6B7");
        });

        modelBuilder.Entity<Withdrawal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Withdraw__3214EC073C477D25");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BankId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyCreditId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeletedAt).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndividualCreditId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ReceiptFile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerifiedAt).HasColumnType("datetime");
            entity.Property(e => e.VerifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Bank).WithMany(p => p.Withdrawals)
                .HasForeignKey(d => d.BankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Withdrawa__BankI__208CD6FA");

            entity.HasOne(d => d.CompanyCredit).WithMany(p => p.Withdrawals)
                .HasForeignKey(d => d.CompanyCreditId)
                .HasConstraintName("FK__Withdrawa__Compa__22751F6C");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.WithdrawalCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Withdrawa__Creat__245D67DE");

            entity.HasOne(d => d.DeletedByNavigation).WithMany(p => p.WithdrawalDeletedByNavigations)
                .HasForeignKey(d => d.DeletedBy)
                .HasConstraintName("FK__Withdrawa__Delet__2739D489");

            entity.HasOne(d => d.IndividualCredit).WithMany(p => p.Withdrawals)
                .HasForeignKey(d => d.IndividualCreditId)
                .HasConstraintName("FK__Withdrawa__Indiv__2180FB33");

            entity.HasOne(d => d.ReceiptFileNavigation).WithMany(p => p.Withdrawals)
                .HasForeignKey(d => d.ReceiptFile)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Withdrawa__Recei__236943A5");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.WithdrawalUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Withdrawa__Updat__2645B050");

            entity.HasOne(d => d.VerifiedByNavigation).WithMany(p => p.WithdrawalVerifiedByNavigations)
                .HasForeignKey(d => d.VerifiedBy)
                .HasConstraintName("FK__Withdrawa__Verif__282DF8C2");
        });

        // Seeders
        modelBuilder.Entity<Role>().HasData(RoleSeeder.SeedRoles());
        modelBuilder.Entity<User>().HasData(UserSeeder.SeedUsers());
        modelBuilder.Entity<BusinessSector>().HasData(BusinessSectorSeeder.SeedBusinessSectors());
        modelBuilder.Entity<Province>().HasData(ProvinceSeeder.SeedProvinces());
        modelBuilder.Entity<City>().HasData(CitySeeder.SeedCities());
        modelBuilder.Entity<SubDistrict>().HasData(SubdistrictSeeder.SeedSubdistricts());
        modelBuilder.Entity<Village>().HasData(VillageSeeder.SeedVillages());
        modelBuilder.Entity<Bank>().HasData(BankSeeder.SeedBanks());
        // modelBuilder.Entity<BranchOffice>().HasData(BranchOfficeSeeder.SeedBranchOffices());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
