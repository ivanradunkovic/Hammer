//using EntityWorker.Core.Helper;
//using Hammer.Controllers;
//using Hammer.Models;
//using Hammer.Modules;
//using System.Web.Mvc;

//namespace IProduct.Controllers
//{
//    public class AccountController : SharedController
//    {
//        [AllowAnonymous]
//        public ActionResult Index(GenericView<User> user, string type = "")
//        {
//            if (Request.IsAuthenticated)
//                return Redirect("~/Home");
//            else if (type.ConvertValue<SignInApplication?>().HasValue)
//            {
//                using (var manager = new UserManager())
//                {
//                    if (!Request.IsAuthenticated)
//                    {
//                        manager.SignIn(type.ConvertValue<SignInApplication>(), user);
//                    }
//                }

//                if (type.ConvertValue<SignInApplication>() == SignInApplication.Cookie &&
//                    !Request.IsAuthenticated)
//                    return View(user.Error("Email or Password could not be found."));
//            }
//            return View(user ?? new GenericView<User>());
//        }

//        #region Facebook
//        // we may need to add some changes here later as if now, the Facebook provider
//        // take care of the login
//        [AllowAnonymous]
//        public ActionResult Facebook(string error)
//        {
//            if (Request.IsAuthenticated)
//                return Redirect("~/Home");

//            return Redirect("Index");
//        }
//        #endregion
//    }
//}