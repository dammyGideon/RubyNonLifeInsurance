using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using RubyNonlife.Application.Dtos.Responses.Jwt;
using RubyNonlife.Application.Helper.UtitlityModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RubyNonlife.Application.Helper.GeneralHelper
{
    public static class TokenService
    {
        public static string GenerateToken(string userId, List<FunctionDto> functions, JwtSettings jwtSettings)
        {
            if (string.IsNullOrEmpty(jwtSettings?.SecretKey))
                throw new ArgumentNullException(nameof(jwtSettings.SecretKey), "JWT Secret cannot be null.");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim("functions", JsonConvert.SerializeObject(functions))
            };

            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        public static string GenerateFullNameToken(Guid userId, string username, string adUsername, bool isFullNameLogin, JwtSettings jwtSettings)
        {
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
        new Claim(ClaimTypes.Name, username),
        new Claim("adUsername", adUsername ?? string.Empty),

        // 👇 This is the dynamic part
        new Claim("UserName", isFullNameLogin ? username : adUsername ?? string.Empty)
    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }


}
