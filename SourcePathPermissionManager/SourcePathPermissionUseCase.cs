using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourcePathPermissionManager
{
    public class SourcePathPermissionUseCase
    {
        public void grantPermission(User user, Permission permission, Sourcepath sourcepath)
        {
            Permission permissions = Context.permissionGateway.findPermissionForUserAndSourcepath(user, sourcepath);
            if(permissions.)
        }
    }
}
