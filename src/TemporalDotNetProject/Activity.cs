using System;
using Temporalio.Activities;

namespace TemporalDotNetProject;



public class MyActivity
{
    [Activity]
    public Task<string> GreetAsync(string name) => Task.FromResult($"Hi {name}, from an activity!");
}
