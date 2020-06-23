using System;
using System.Collections.Generic;
using System.Text;

namespace SourcePathPermissionManager
{
    class MockGateway : Gateway
    {
        private List<Sourcepath> sourcepaths;
        private List<User> users;
        private List<Permission> permissions;
        public MockGateway()
        {
            sourcepaths = new List<Sourcepath>();
            users = new List<User>();
            permissions = new List<Permission>();
        }

        public void Save(User u)
        {
            throw new NotImplementedException();
        }

        public Sourcepath findSourcepathById(string sourcepathId)
        {
            foreach (Sourcepath sourcepath in sourcepaths)
            {
                if (sourcepath.getId().Equals(sourcepathId))
                    return sourcepath;
                
            }
            return null;
        }

        public User findUser(string username)
        {
            throw new NotImplementedException();
        }

        public void grantPermission(Permission permission)
        {
            permissions.Add(permission);
        }
    }
}
