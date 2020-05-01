using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;


namespace Nop.Plugin.Payments.MinburPayment.Components
{
    [ViewComponent(Name = "PaymentMinburPayment")]
    public class PaymentMinburPaymentViewComponent : NopViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/Payments.MinburPayment/Views/PaymentInfo.cshtml");
        }
    }
}
