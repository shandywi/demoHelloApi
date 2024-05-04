var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hi Human, please type the name of your destination planet!");
app.MapGet("/merkurius", () => "You are landing on merkurius!");
app.MapGet("/venus", () => "You are landing on venus!");
app.MapGet("/earth", () => "You are landing on earth!");

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStatusCodePages();

app.Run();
