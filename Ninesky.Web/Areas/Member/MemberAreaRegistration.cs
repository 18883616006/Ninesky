using System.Web.Mvc;

namespace Ninesky.Web.Areas.Member
{
    public class MemberAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Member";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Member_default",
                "Member/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                //新添加路由信息（修改 Member 区域路由）
                new string[] {"Ninesky.Web.Areas.Member.Controllers"}
            );
        }
    }
}