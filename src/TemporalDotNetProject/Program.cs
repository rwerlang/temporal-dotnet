using TemporalDotNetProject;
using Temporalio.Client;
using Temporalio.Worker;

var temporalUrl = Environment.GetEnvironmentVariable("TEMPORAL_URL");

Console.WriteLine("Connecting to Temporal server at: " + temporalUrl);

var client = await TemporalClient.ConnectAsync(new()
{
    TargetHost = temporalUrl
});

Console.WriteLine("Connected to Temporal server.");


using var worker = new TemporalWorker(
    client,
    new TemporalWorkerOptions ("my-task-queue")
        .AddAllActivities(new MyActivity())
        .AddWorkflow<MyWorkflow>()
);

Console.WriteLine("Running worker ...");

var task = worker.ExecuteAsync(default);
var wfId = DateTime.Now.Ticks.ToString();

var handle = await client.StartWorkflowAsync(
    (MyWorkflow wf) => wf.RunAsync("test"),
    new(wfId, "my-task-queue")
);

Console.WriteLine("Started workflow with ID: " + handle.Id);

var result = await handle.GetResultAsync();
Console.WriteLine("Workflow result: " + result);

Console.WriteLine("Done");
await Task.Delay(1000);

