namespace MidasAPI.DTOs.User
{
    public class CustomerResponseDTO
    {
        public string Id { get; set; } = null!;

        public string FullName { get; set; } = null!;

        public string NickName { get; set; } = null!;

        public string IdentityNumber { get; set; } = null!;

        public int? CreditScore { get; set; }
    }
}
