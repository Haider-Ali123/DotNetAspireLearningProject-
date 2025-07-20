var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.DotNetAspireCrud_ApiService>("apiservice");

builder.AddProject<Projects.DotNetAspireCrud_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
