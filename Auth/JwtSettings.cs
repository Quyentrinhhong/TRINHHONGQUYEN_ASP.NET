namespace TrinhHongQuyen_2122110059.Auth
{
    public class JwtSettings
    {
        public string SecretKey { get; set; } = "THIS_IS_A_SUPER_SECRET_KEY_1234567890_32";
        public string Issuer { get; set; } = "TrinhHongQuyen_2122110059App";
        public string Audience { get; set; } = "TrinhHongQuyen_2122110059Users";
        public int ExpirationMinutes { get; set; } = 60;
    }
}
