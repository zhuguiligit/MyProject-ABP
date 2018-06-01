using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Authorization;
using MyProject.Authorization;

namespace MyProject.Web.Controllers
{
    [AbpAuthorize(PermissionNames.Pages_Tasks)]
    public class TasksController : Controller
    {
        public ActionResult Index()
        {
            return new ContentResult {Content = "tasks"};
        }
    }
}