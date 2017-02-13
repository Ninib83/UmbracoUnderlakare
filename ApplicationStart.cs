using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using Umbraco.Core;
using UmbracoUnderlakare.App_Start;

namespace UmbracoUnderlakare
{
    public class ApplicationStart : ApplicationEventHandler
    {
        protected override void ApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            WebApiConfig.Register(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configuration.Services.
               Replace(typeof(IHttpControllerActivator), new UmbracoWebApiHttpControllerActivator());
        }
    }
}