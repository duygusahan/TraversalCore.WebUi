using TraversalCore.BusinessLayer.Abstract;
using TraversalCore.BusinessLayer.Concrete;
using TraversalCore.DataAccessLayer.Abstract;
using TraversalCore.DataAccessLayer.Context;
using TraversalCore.DataAccessLayer.EntityFramework;
using TraversalCore.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TraversalContext>();
builder.Services.AddIdentity<AppUser , AppRole>().AddEntityFrameworkStores<TraversalContext>();
builder.Services.AddScoped<IDestinationService , DestinationManager>(); 
builder.Services.AddScoped<IDestinationDal , EfDestinationDal>(); 

builder.Services.AddScoped<IFeatureBigImagesDal , EfFeatureBigImagesDal>();
builder.Services.AddScoped<IFeatureBigImagesService , FeatureBigImagesManager>();

builder.Services.AddScoped<IFeatureSmallImagesDal, EfFeatureSmallImagesDal>();
builder.Services.AddScoped<IFeatureSmallImagesService, FeatureSmallImagesManager>();

builder.Services.AddScoped<ISubAboutDal , EfSubAboutDal>();
builder.Services.AddScoped<ISubAboutService, SubAboutManager>();

builder.Services.AddScoped<ITestimonialDal , EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<ICommentDal , EfCommentDal>();
builder.Services.AddScoped<ICommentService , CommentManager>();

builder.Services.AddControllersWithViews();

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
