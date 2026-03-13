var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PersonalFinanceAPI>("personalfinanceapi");

builder.Build().Run();
