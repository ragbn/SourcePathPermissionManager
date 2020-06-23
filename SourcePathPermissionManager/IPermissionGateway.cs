using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourcePathPermissionManager
{
    public interface IPermissionGateway
    {
        Permission grant(Permission permission);
        Permission findPermissionForUserAndSourcepath(User user, Sourcepath sourcepath);
    }
}
