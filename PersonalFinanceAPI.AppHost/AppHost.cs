using Scalar.Aspire;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PersonalFinanceAPI>("personalfinanceapi");
// Add your services
var personalFinanceApiService = builder.AddProject<Projects.PersonalFinanceAPI>("personal-finance-api");

// Add API Reference
var scalar = builder.AddScalarApiReference();

// Register services with the API Reference
scalar.WithApiReference(personalFinanceApiService);

builder.Build().Run();
