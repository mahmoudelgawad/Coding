using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;


namespace WebAPI_ASPCOREMVC_PlayGround.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private string GenerateJWT() 
        {
            //Algorithm
            var algo = SecurityAlgorithms.HmacSha256;

            // claims idintity user
            var claims = new Claim[] 
            {
                 new Claim(JwtRegisteredClaimNames.Sub, "Mahmoud"),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new Claim(JwtRegisteredClaimNames.Iat, "12458776")
            };

            //Signature
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MahmoudAhmed@d15647c"));
            var credentials = new SigningCredentials(securityKey, algo);

            var token = new JwtSecurityToken(
                "MahmoudIssuerApp", // issuer
                "ForClientsAudience", //audience
                claims, //IEnumerable<Claim>
                null,   //not before datetime
                null,   //expire
                credentials //SigningCredentials instance
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
