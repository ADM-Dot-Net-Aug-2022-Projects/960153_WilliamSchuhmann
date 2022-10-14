namespace EcommerceApp.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient http;

        public AuthService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await http.PostAsJsonAsync("api/auth/register", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
