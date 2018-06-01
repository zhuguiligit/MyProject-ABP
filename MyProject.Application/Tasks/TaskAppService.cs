using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using MyProject.Authorization;

namespace MyProject.Tasks
{
    [AbpAuthorize(PermissionNames.Pages_Tasks)]
    public class TaskAppService : MyProjectAppServiceBase, ITaskAppService
    {

    }
}
