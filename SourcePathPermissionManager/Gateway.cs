using System.Collections.Generic;

namespace SourcePathPermissionManager
{
    public interface Gateway
    {
       public Sourcepath findSourcepathById(string v);
       public void Save(User u);
        User findUser(string username);
        void grantPermission(Permission permission);
    }
}