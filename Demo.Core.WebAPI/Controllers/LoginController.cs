using Demo.Core.CustomersAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Demo.Core.CustomersAPI.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("getaccesstoken")]
        [AllowAnonymous]
        public IResult GetAccessToken([FromBody] User user)
        {


            // User will be validated with Active Directory using LDAP Or
            // SSO(Single Sign on  (Federated Authentication )  ADFS 
            // Active directory --> It's corporate directory which stores all the employee information
            //Network information
            // Domain Information 

            // request ---> UN/PW ---> will be validated with corporte ACtive directory 


            if (user.UserName == "Admin" && user.Password == "Welcome@FoodOrders")
            {
                var issuer = _configuration["Jwt:Issuer"];
                var audience = _configuration["Jwt:Audience"];
                var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]?.ToString());

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                    new Claim("Id", Guid.NewGuid().ToString()),
                    new Claim("UserName", user.UserName),
                    new Claim("SupportId","Welcome2DemoofJWT"),
                    //new Claim("SupportId",user.SupportId)
                    new Claim(JwtRegisteredClaimNames.Jti,
                    Guid.NewGuid().ToString())
             }),
                    Expires = DateTime.UtcNow.AddMinutes(5),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials
                    (new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha512Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwtToken = tokenHandler.WriteToken(token);
                var stringToken = tokenHandler.WriteToken(token);

                return Results.Ok(stringToken);
            }
            return Results.Unauthorized();

        }



    }
}
