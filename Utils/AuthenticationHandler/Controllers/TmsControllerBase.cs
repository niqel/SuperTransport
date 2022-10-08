using Microsoft.AspNetCore.Mvc;
using TmsTcAPI.DAL.Models;

namespace AuthenticationHandler.Controllers
{
    public abstract class TmsControllerBase : ControllerBase
    {
        protected TmsTcEntities Context { get; private set; }

        protected TmsControllerBase(TmsTcEntities context) : base()
        {
            Context = context;
        }
    }
}
