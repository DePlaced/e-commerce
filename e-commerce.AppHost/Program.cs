var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.productAPI>("productapi");

builder.Build().Run();
