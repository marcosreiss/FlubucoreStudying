using FlubuCore.Context;
using FlubuCore.Scripting;
using System;
using FlubuCore.Context.Attributes.BuildProperties;

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
    }
}
}
