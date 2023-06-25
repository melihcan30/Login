using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ActivitionCode { get; set; } = string.Empty;
        public bool VerificationStatus { get; set; }
        public DateTime LastLoginTime { get; set; }
        public string PasswordResetToken { get; set; } = string.Empty;

    }
}
