var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.OrganizeJobs_Api>("organizejobs-api");

builder.Build().Run();
