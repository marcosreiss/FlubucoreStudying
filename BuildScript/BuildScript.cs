using FlubuCore.Context;
using FlubuCore.Scripting;
using FlubuCore.Tasks.NetCore;  
using System;
using FlubuCore.Context.Attributes.BuildProperties;
using FlubuCore;
using FlubuCore.Targeting;

namespace BuildScript
{
    public class MyBuildScript : DefaultBuildScript
{   
    protected override void ConfigureTargets(ITaskContext context)
    {
        var compile = context.CreateTarget("compile")
            .SetDescription("Compiles the solution.")
            .SetAsDefault()
            .AddCoreTask(x => x.Build("TestandoFlubuCore.sln"))
            .AddCoreTask(x => x.Pack())
            .AddCoreTask(x => x.NugetPush("C:\\work\\TestandoFlubuCore\\bin\\Debug"))
            ;

            

           
    }

      

    

}
}
