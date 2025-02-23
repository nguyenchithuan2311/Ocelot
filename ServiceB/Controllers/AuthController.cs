using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ServiceB.Entity;

namespace ServiceB.Controllers;
[ApiController]
[Route("api/auth")]
public class AuthController(JwtSettings jwtSettings) : ControllerBase
{
    private string KeyJwt { get; set; } = jwtSettings.Key;
    [HttpGet]
    public string Get()
    {
        
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("sub", "user123") }),
            Expires = DateTime.UtcNow.AddHours(1),
            Issuer = "http://localhost:5193",
            Audience = "api-gateway",
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KeyJwt)),
                SecurityAlgorithms.HmacSha256Signature
            )
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}