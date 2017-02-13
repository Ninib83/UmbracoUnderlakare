﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoUnderlakare
{
    public class ControllerHelper
    {
        public static bool IsUmbracoController(Type controllerType)
        {
            return controllerType.Namespace != null
               && controllerType.Namespace.StartsWith("umbraco", StringComparison.InvariantCultureIgnoreCase)
               && !controllerType.Namespace.StartsWith("umbraco.extensions", StringComparison.InvariantCultureIgnoreCase);
        }
    }
}