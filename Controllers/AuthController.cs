using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Student_Management_System.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                var token = GenerateToken();
                return Ok(new { token = token });
            }

            return Unauthorized("Invalid username or password");
        }

        private string GenerateToken()
        {
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("ThisIsMySuperSecretKey1234567890"));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "admin")
            };

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}