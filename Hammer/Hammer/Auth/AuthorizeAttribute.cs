//using System.Linq;
//using System.Security.Claims;
//using System.Web;
//using System.Web.Mvc;

//namespace Hammer.Auth
//{
//    public class Authorize : AuthorizeAttribute
//    {
//        public Authorize()
//        {
//            base.Roles = IProduct.Modules.Roles.Customers.ToString();
//        }

//        public Authorize(params IProduct.Modules.Roles[] roles)
//        {
//            if (roles != null && roles.Any())
//                base.Roles = string.Join(",", roles.Select(x => x.ToString()));
//            else
//                base.Roles = IProduct.Modules.Roles.Customers.ToString();
//        }

//        protected override void HandleUnauthorizedRequest(AuthorizationContext ctx)
//        {
//            if (!ctx.HttpContext.User.Identity.IsAuthenticated)
//                base.HandleUnauthorizedRequest(ctx);
//            else
//            {
//                var role = HttpContext.Current.GetOwinContext().Authentication.User.Claims
//                           .FirstOrDefault(x => x.Type == "role" || x.Type == ClaimTypes.Role)?.Value;
//                // Role check IsAuthenticated
//                if (!(role == IProduct.Modules.Roles.Administrator.ToString() || Roles.Contains(role)))
//                {
//                    ctx.Result = new ViewResult { ViewName = "Unauthorized" };
//                    ctx.HttpContext.Response.StatusCode = 403;
//                }
//            }
//        }
//    }
//}