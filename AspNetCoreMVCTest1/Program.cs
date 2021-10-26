using AspNetCoreMVCTest1.Codes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//registere vores service
//builder.Services.AddTransient<IHashing, Hashing>();
builder.Services.AddSingleton<IHashing, Hashing>();
//builder.Services.AddScoped<IHashing, Hashing>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Unexpected error - blame yourself! -  see https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ardeaprints.com%2Fdec2014%2F1%2Frabbit-chewing-electric-flex-10515551.html&psig=AOvVaw2Orkf83E4XlWrFGgFH7mqS&ust=1635327866714000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCJDtjZfl5_MCFQAAAAAdAAAAABAJ.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
