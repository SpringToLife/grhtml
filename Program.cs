using GrapesJsEditorHtml.DataContext;
using GrapesJsEditorHtml.Controllers;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using GrapesJsEditorHtml.ViewModel;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
namespace GrapesJsEditorHtml
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);
      builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

      builder.Services.AddDistributedMemoryCache();
      builder.Services.Configure<RequestLocalizationOptions>(options =>
      {
        var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("en"),
                new CultureInfo("fr")
            };

        options.DefaultRequestCulture = new RequestCulture("en");
        options.SupportedCultures = supportedCultures;
        options.SupportedUICultures = supportedCultures;
      });

      // Add services to the container.
      builder.Services.AddMvc();

      builder.Services.AddSession(options =>
      {
        options.IdleTimeout = TimeSpan.FromMinutes(5);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
      });

      // Add HttpClient
      builder.Services.AddHttpClient();
      builder.Services.AddControllersWithViews();

      builder.Services.AddDbContext<GrapesJsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("GrapesConnectionString")));

      builder.Services.AddDirectoryBrowser();
      var app = builder.Build();
      app.UseResponseCaching();

      //app.Environment.WebRootFileProvider = new PhysicalFileProvider(
      //        Path.Combine(app.Environment.ContentRootPath, "build"));

      app.UseDefaultFiles();

      app.UseStaticFiles(new StaticFileOptions()
      {
        HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
        OnPrepareResponse = (context) =>
        {
          var headers = context.Context.Response.GetTypedHeaders();
          headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
          {
            Public = true,
            MaxAge = TimeSpan.FromDays(1)
          };
        }
      });

      //app.UseSpaStaticFiles(new StaticFileOptions
      //{
      //  FileProvider = new PhysicalFileProvider(
      //        Path.Combine(app.Environment.ContentRootPath, "build")),
      //  RequestPath = "/Static",
      //  HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
      //  OnPrepareResponse = (context) =>
      //  {
      //    var headers = context.Context.Response.GetTypedHeaders();
      //    headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
      //    {
      //      Public = true,
      //      MaxAge = TimeSpan.FromDays(1)
      //    };
      //  }
      //});
      //app.UseSpa(spa =>
      //{
      //  //spa.Options.SourcePath = "";

      //  if (app.Environment.IsDevelopment())
      //  {
      //    spa.UseReactDevelopmentServer(npmScript: "start");
      //  }
      //});
      // Configure the HTTP request pipeline.
      if (!app.Environment.IsDevelopment())
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
        app.UseHttpsRedirection();
      }

      app.UseHttpsRedirection();
      var options = new DefaultFilesOptions();
      options.DefaultFileNames.Clear();
      options.DefaultFileNames.Add("index.html");
      app.UseDefaultFiles(options);


      app.UseStaticFiles();



      app.UseCors(builder => builder
         .AllowAnyHeader()
         .AllowAnyMethod()
         .AllowAnyOrigin());
      app.UseCors("AllowAllHeaders");
      app.UseRouting();





      app.UseSession();
      app.MapControllerRoute(
          name: "Get",
           pattern: "Get/{id}",
          defaults: new { controller = "Helps", action = "Get" }
          );
      app.MapControllerRoute(
         name: "TransEn",
          pattern: "TransEn",
         defaults: new { controller = "Helps", action = "TransEn" }
         );
      app.MapControllerRoute(
         name: "TransFr",
          pattern: "TransFr",
         defaults: new { controller = "Helps", action = "TransFr" }
     );
      app.MapControllerRoute(
       name: "Save",
        pattern: "Save/",
       defaults: new { controller = "Helps", action = "Save" }
       );
      app.MapFallbackToFile("index.html");

      app.UseMiddleware<GrapesJsEditorHtml.Middleware>();


      app.Run();
    }
  }
}
