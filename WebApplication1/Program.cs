var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();
app.MapRazorPages();


app.Run();
