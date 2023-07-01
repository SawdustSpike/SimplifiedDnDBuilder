using Simple_DnD_Builder.Repositories.Implementations;
using Simple_DnD_Builder.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IAbilityScoreRepository, AbilityScoreRepository>();
builder.Services.AddTransient<IAlignmentRepository, AlignmentRepository>();
builder.Services.AddTransient<ICharClassRepository, CharClassRepository>();
builder.Services.AddTransient<ILanguageRepository, LanguageRepository>();
builder.Services.AddTransient<IRaceRepository, RaceRepository>();
builder.Services.AddTransient<ISkillRepository, SkillRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
