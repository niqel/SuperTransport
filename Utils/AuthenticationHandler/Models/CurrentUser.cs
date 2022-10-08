using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace AuthenticationHandler.Models
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Sid { get; set; }
        public List<string> Roles { get; set; }

        public CurrentUser()
        {
        }

        public CurrentUser(ClaimsPrincipal user)
        {
            if (user == null)
                return;

            if (user.Identity.Name == null)
                return;

            Id = int.Parse(user.Identity.Name);
            Email = user.Claims.Where(c => c.Type == ClaimTypes.Email).FirstOrDefault().Value;
            Sid = user.Claims.Where(c => c.Type == ClaimTypes.Sid).FirstOrDefault().Value;
            Roles = user.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();
        }

        public List<Claim> ToClaims()
        {
            var claims = Roles.Select(r => new Claim(ClaimTypes.Role, r)).ToList();
            claims.Add(new Claim(ClaimTypes.Name, Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Email, Email));
            claims.Add(new Claim(ClaimTypes.Sid, Sid));
            return claims;
        }
    }
}
