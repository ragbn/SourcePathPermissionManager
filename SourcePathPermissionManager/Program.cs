using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace SourcePathPermissionManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context.gateway = new MockGateway();

            Sourcepath sourcepaths = Context.gateway.findSourcepathById("SourcePath");

            Context.gateway.Save(new User("username"));
        }

        public bool createPermissionForContributing(string username, string sourcepathID)
        {
            User user = Context.gateway.findUser(username);
            Sourcepath sourcepath = Context.gateway.findSourcepathById(sourcepathID);
            Permission permission = new Permission(user, sourcepath);
            Context.gateway.grantPermission(permission);
            return useCase.isContributeAccessEnabledOnSourcepath(user, sourcepath);
        }
    }
}
