using IdentityModel;
using Microsoft.IdentityModel.Tokens;
using SmEticaret.Data.Entities;
using SmEticaret.Shared.ServiceResult;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SmEticaret.Api.Services.TokenServices
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IServiceResult<string> CreateToken(UserEntity user)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim(JwtClaimTypes.Name, user.Name),
                    new Claim(JwtClaimTypes.FamilyName, user.LastName),
                    new Claim(JwtClaimTypes.Email, user.Email),
                    new Claim(JwtClaimTypes.Role, user.Role.Name),
                };

                string? secret = GetSecretKeyFromConfiguration();

                if (string.IsNullOrWhiteSpace(secret))
                {
                    return ServiceResult.Fail<string>("Secret key not found in config.", StatusCodes.Status501NotImplemented);
                }

                string issuer = GetIssuerKeyFromConfiguration();

                if (string.IsNullOrWhiteSpace(issuer))
                {
                    return ServiceResult.Fail<string>("Issuer not found in config.", StatusCodes.Status501NotImplemented);
                }

                string audience = GetAudienceKeyFromConfiguration();

                if (string.IsNullOrWhiteSpace(audience))
                {
                    return ServiceResult.Fail<string>("Audience not found in config.", StatusCodes.Status501NotImplemented);
                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));

                var credantials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                if (key is null)
                {
                    return ServiceResult.Fail<string>("Key is null", StatusCodes.Status501NotImplemented);
                }

                var jwtSecurityToken = new JwtSecurityToken(
                    issuer: issuer,
                    audience: audience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: credantials);

                var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

                return ServiceResult.Success(token);

            }
            catch (Exception ex)
            {
                return ServiceResult.Fail<string>("ewewfd", StatusCodes.Status501NotImplemented);
            }

        }
        private string GetAudienceKeyFromConfiguration()
        {
            return _configuration["Jwt:Audence"];
        }

        private string GetIssuerKeyFromConfiguration()
        {
            return _configuration["Jwt:Issuer"];
        }

        private string? GetSecretKeyFromConfiguration()
        {
            return _configuration["Jwt:Secret"];
        }
    }

}
