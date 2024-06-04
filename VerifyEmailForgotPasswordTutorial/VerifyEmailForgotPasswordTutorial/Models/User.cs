namespace VerifyEmailForgotPasswordTutorial.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];

        public string? VerificationToken { get; set; }

        public DateTime? VerifiedAt { get; set; }

        public string? PasswordResetToken { get; set; }

        public DateTime? ResetTokenExpires { get; set; }
    }
}

//PasswordSalt - this property stores th3 salt used during the password hashing process.
//A salt is a random value added to the password before hashing to make it more secure
//by preventing certain types of attacks such as rainbow table attacks