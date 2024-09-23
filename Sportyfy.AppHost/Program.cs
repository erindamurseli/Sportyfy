var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Sportyfy>("sportyfy");

builder.Build().Run();
