namespace Login.Models
{
    public class PasswordReset
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PasswordResetToken { get; set; } = string.Empty;
        public DateTime TokenExpirationTime { get; set; }
    }
}
