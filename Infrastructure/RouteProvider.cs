using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;


namespace Nop.Plugin.Payments.MinburPayment.Infrastructure
{
    public partial class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            //PDT
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.MinburPayment.PDTHandler", "Plugins/PaymentMinburPayment/PDTHandler",
                 new { controller = "PaymentMinburPayment", action = "PDTHandler" });

            //IPN
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.MinburPayment.IPNHandler", "Plugins/PaymentMinburPayment/IPNHandler",
                 new { controller = "PaymentMinburPayment", action = "IPNHandler" });

            //Cancel
            endpointRouteBuilder.MapControllerRoute("Plugin.Payments.MinburPayment.CancelOrder", "Plugins/PaymentMinburPayment/CancelOrder",
                 new { controller = "PaymentMinburPayment", action = "CancelOrder" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => -1;
    }

}
