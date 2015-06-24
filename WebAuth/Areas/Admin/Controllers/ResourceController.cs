﻿using Resources.App_LocalResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAuth.Controllers;

namespace WebAuth.Areas.Admin.Controllers
{
    /// <summary>
    /// ResourceController
    /// </summary>
    /// <see cref="http://afana.me/post/aspnet-mvc-internationalization-strings-localization-client-side.aspx"/>
    public class ResourceController : BaseController
    {
        public JsonResult GetResources()
        {
            return Json(new Dictionary<string, string> { 
                {"Action", Resource.Action},
                {"ApplicationRole_Description", Resource.ApplicationRole_Description},
                {"Controller", Resource.Controller},
                {"PermissionViewModel_Description", Resource.PermissionViewModel_Description}
                   //resources.PermissionViewModel_Description
            }, JsonRequestBehavior.AllowGet);
        }
    }
}