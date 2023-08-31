using FlubuCore.Context;
using FlubuCore.Scripting;
using FlubuCore.Tasks.NetCore;  
using System;
using FlubuCore.Context.Attributes.BuildProperties;
using FlubuCore;
using FlubuCore.Targeting;
using FlubuCore.Context.FluentInterface.TaskExtensions;

namespace BuildScript
{
    public class MyBuildScript : DefaultBuildScript
{   
    protected override void ConfigureTargets(ITaskContext context)
    {
        var compile = context.CreateTarget("compile")
            .SetDescription("Compiles the solution.")
            .SetAsDefault()
            .AddCoreTask(x => x.Build("TestandoFlubuCore.sln"));

        var publicar = context.CreateTarget("publish")
                .SetDescription("Publish the solution")
                .AddCoreTask(x => x.Publish("TestandoFlubuCore.sln", "C:\\work\\TestandoFlubuCore", "release"));
            

        var nuGetpackage = context.CreateTarget("nuGetPack")
                .SetDescription("Create a NuGet Package")
                .AddCoreTask(x => x.Pack());
            // .AddCoreTask(x => x.NugetPush("C:\\work\\TestandoFlubuCore\\bin\\Debug"));
               
                

        var zipPackage = context.CreateTarget("zipPack")
                .SetDescription("creating a zip package")
                .AddCoreTask(x => x.CreateZipPackageFromProjects("zipFileName.zip", "myFramework", ""));





    }

      

    

}
}
