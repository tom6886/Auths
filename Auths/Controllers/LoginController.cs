using Auths.Context;
using Auths.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Utils;

namespace Auths.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public object signIn(string account, string pwd, string remeberMe)
        {
            string returnUrl = string.Empty;

            using (var db = new DBContext())
            {
                string _pass = StringUtil.Md5Encrypt(pwd);

                IUser user = db.IUser.Where(q => q.Account.Equals(account) && q.PassWord.Equals(_pass)).FirstOrDefault();

                if (user == null) { return Json(new { code = -1, msg = "用户名或密码错误" }); }

                if (user.Status == Status.disable) { return Json(new { code = -2, msg = "此用户已禁用，请联系管理员" }); }

                returnUrl = "User";
            }

            return Json(new { code = 1, msg = "登录成功", url = returnUrl });
        }
    }
}
