



using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;

using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GrapesJsEditorHtml
{
  // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
  public class Middleware
  {
    private readonly RequestDelegate _next;


    public Middleware(RequestDelegate next)
    {

      _next = next;
    }


    public void SetCookie(string key, string value, int? expireTime, HttpContext context)
    {

      CookieOptions option = new CookieOptions();

      if (expireTime.HasValue)
        option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
      else
        option.Expires = DateTime.Now.AddMilliseconds(10);

      context.Response.Cookies.Append(key, value, option);
    }
    public async Task<(string, HttpResponseMessage)> GetStringWithResponseAsync(string url)
    {
      using (var client = new HttpClient())
      {
        HttpResponseMessage response = await client.GetAsync(url);
        string content = await response.Content.ReadAsStringAsync();
        return (content, response);
      }
    }

    public async Task Invoke(HttpContext context)

    {


      string CurrentUrl = Microsoft.AspNetCore.Http.Extensions.UriHelper.GetDisplayUrl(context.Request).ToLower();

      if (CurrentUrl.Contains("get"))
      {
        if (CurrentUrl.Contains("camp"))
        {

          var dvd = context.Request.Path.ToString().Replace("getcamp", "").Replace("/", "");
          context.Response.Cookies.Append(
          CookieRequestCultureProvider.DefaultCookieName,
          CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("fr-FR")),
          new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
          string substr = dvd;
          context.Session.Remove("idhelp");
          context.Session.SetString("idcamp", substr);
          context.Session.SetString("language", "FR");
          context.Response.Redirect(CurrentUrl);
        }
        else
        {

          var dvd = context.Request.Path.ToString().Replace("get", "").Replace("/", "");
          context.Response.Cookies.Append(
          CookieRequestCultureProvider.DefaultCookieName,
          CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("fr-FR")),
          new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
          string substr = dvd;
          context.Session.Remove("idcamp");
          context.Session.SetString("idhelp", substr);
          context.Session.SetString("language", "FR");
          context.Response.Redirect(CurrentUrl);
        }
      }
      if (CurrentUrl.Contains("loadlist"))
      {
        context.Response.Cookies.Append(
       CookieRequestCultureProvider.DefaultCookieName,
       CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("fr")),
       new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
        context.Response.Redirect(CurrentUrl);
      }

      if (CurrentUrl.Contains("transen"))
      {
        context.Response.Cookies.Append(
        CookieRequestCultureProvider.DefaultCookieName,
        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("en-US")),
        new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
        context.Session.SetString("language", "EN");
        context.Response.Redirect(CurrentUrl);
      }
      if (CurrentUrl.Contains("transfr"))
      {
        context.Response.Cookies.Append(
        CookieRequestCultureProvider.DefaultCookieName,
        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("fr-FR")),
        new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
        context.Session.SetString("language", "FR");
        context.Response.Redirect(CurrentUrl);
      }
      if (CurrentUrl.Contains("save"))
      {
        context.Response.Cookies.Append(
        CookieRequestCultureProvider.DefaultCookieName,
        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture("fr")),
        new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
        context.Response.Redirect(CurrentUrl);

      }
      await _next(context);

    }
  }
}



