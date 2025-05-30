using System;
using Temporalio.Workflows;

namespace TemporalDotNetProject;


[Workflow]
public class MyWorkflow
{
    [WorkflowRun]
    public Task<string> RunAsync(string input)
    {
        return Task.FromResult($"Hello, {input}!");
    }
}
