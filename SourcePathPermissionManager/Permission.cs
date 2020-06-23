using System.ComponentModel;

namespace SourcePathPermissionManager
{
    public class Permission
    {
        public enum PermissionLevel {READ, CONTRIBUTE, OWNER}
        private User user;
        private Sourcepath sourcepath;
        private PermissionLevel type;
        public Permission(PermissionLevel type, User user, Sourcepath sourcepath)
        {
            this.type = type;
            this.user = user;
            this.sourcepath = sourcepath;
        }
    }
}