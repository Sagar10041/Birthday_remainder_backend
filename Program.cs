var builder = WebApplication.CreateBuilder(args); // initalized builder


builder.Services.AddEndpointsApiExplorer();// these two lines are for adding swagger services to builder
builder.Services.AddSwaggerGen();

var app = builder.Build(); // builder is builded

if (app.Environment.IsDevelopment()) // block for swagger if not required can be omitted

{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.Run(); // for running the builder ultimately runs the project
