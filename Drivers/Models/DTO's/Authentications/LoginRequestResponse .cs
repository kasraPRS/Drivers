
using UserApi.Models.DTOs;

namespace Drivers.Models
{
    public class LoginRequestResponse: AuthResult

    {
        public string UserId { get; set; } = "";
        public new string Email { get; set; } = "";
    }
}
