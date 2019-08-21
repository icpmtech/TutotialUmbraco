using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace UmbracoToReplication.Controllers
{
    public class MemberController : Umbraco.Web.Mvc.SurfaceController
    {
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMember(UmbracoToReplication.Models.RegisterMemberModel model)
        {
           
                if (!ModelState.IsValid)
                    return CurrentUmbracoPage();

                var memberService = Services.MemberService;
                if (memberService.GetByEmail(model.Email) != null)
                {
                    ModelState.AddModelError("", "Member already exists");
                    return CurrentUmbracoPage();
                }
                var member = memberService.CreateMemberWithIdentity(model.Email, model.Email, model.Name, "Member");

                memberService.Save(member);

                memberService.SavePassword(member, model.Password);

                Members.Login(model.Email, model.Password);

                   return Redirect("/Admin");
               // return RegisterMember(model);
        }
         
    }
}