namespace ECardManagment.ViewModel.Users
{
    public class TokenResponseModel
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
    }
}
