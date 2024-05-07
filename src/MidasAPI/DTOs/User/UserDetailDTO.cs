namespace MidasAPI.DTOs.User
{
    public class UserDetailDTO
    {
        public string Id { get; set; } = null!;

        public string Email { get; set; } = null!;

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

        public string RoleName { get; set; } = null!;
    }
}
