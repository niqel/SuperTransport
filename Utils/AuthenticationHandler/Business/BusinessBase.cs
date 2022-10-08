using AuthenticationHandler.Models;
using System.Security.Claims;
using TmsTcAPI.DAL.Models;

namespace AuthenticationHandler.Business
{
    public abstract class BusinessBase
    {
        protected TmsTcEntities Context { get; private set; }
        protected CurrentUser CurrentUser { get; private set; }

        public BusinessBase(TmsTcEntities context)
        {
            this.Context = context;
        }

        protected BusinessBase(TmsTcEntities context, ClaimsPrincipal user)
        {
            Context = context;

            if (user == null)
                return;

            if (user.Identity.Name == null)
                return;

            CurrentUser = new CurrentUser(user);
        }
    }
}
