using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GrapesJsEditorHtml.DataContext;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using IData;
using GrapesJsEditorHtml.Helpers;
using GrapesJsEditorHtml.ViewModel;

namespace GrapesJsEditorHtml.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class HelpsController : ControllerBase
  {
    private readonly IConfiguration _configuration;
    private readonly GrapesJsContext _context;
    private readonly HttpClient _httpClient;
    private readonly string _connectionString;


    public HelpsController(GrapesJsContext context, HttpClient httpclient, IConfiguration configuration)
    {
      _httpClient = httpclient;
      _context = context;
      _configuration = configuration;
      _connectionString = configuration.GetConnectionString("GrapesConnectionString");
    }

    [HttpGet("/LoadListChamp/")]
    public IActionResult GetListViewCompte()

    {

      string idcamp = null;
      string idhelp = null;
      string idlistetype = "";
      string dropdownHtml = "";
      string viewtable = "";
  
      using (SqlConnection connection = new SqlConnection(_connectionString))
      {



        if (HttpContext.Session.TryGetValue("idhelp", out byte[] idhelpBytes))
        {
          idhelp = Encoding.UTF8.GetString(idhelpBytes);

        }
        if (HttpContext.Session.TryGetValue("idcamp", out byte[] idcampBytes))
        {
          idcamp = Encoding.UTF8.GetString(idcampBytes);

        }
        if (idhelp != null)
        {
          string sql = "select * from Help,ListesTypes where Help.IdListeType=ListesTypes.IdListeType and Help.IdHelp=" + idhelp;
          connection.Open();
          using (SqlCommand command = new SqlCommand(sql, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
            {

              if (reader.Read())
              {
                idlistetype = reader.GetInt32(2).ToString();
                viewtable = reader.GetString(17).ToString();
              }
              connection.Close();
            }
          }
        }

        if (idcamp != null)
        {
          connection.Open();
          string sql2 = "select list.IdListeType,list.Type,camp.IdCampagne,list.[Table],list.Source,list.Racine,camp.Nom from eCampagnes camp inner join eConfig conf on conf.IdConfig=camp.IdConfig inner join ListesTypes list on list.IdListeType=conf.IdListeType where camp.Valide='Y' and camp.IdCampagne =" + idcamp;
          using (SqlCommand command2 = new SqlCommand(sql2, connection))
          {
            using (SqlDataReader reader = command2.ExecuteReader())
            {

              if (reader.Read())
              {
                idlistetype = reader.GetInt32(0).ToString();
                viewtable = reader.GetString(3).ToString();

              }
              connection.Close();
            }
          }
        }
      }


      switch (viewtable)
      {

        case "viewComptes":
          IData.CompteData compte = new IData.CompteData();
          DescriptionHelper _helper = new DescriptionHelper();
          List<Utils.PropertyData> _Propscompte = Utils.PropertyData.GetListProperties2(compte, "", "", "", true, false, 6, "", ParametrageListe.excludecompte);
          dropdownHtml = _helper.GenerateDropdownHtml(_Propscompte);
          break;

        case "viewAccreditations":
          IData.PersonneData pers = new IData.PersonneData();
          List<Utils.PropertyData> _Propsaccred = Utils.PropertyData.GetListProperties2(pers, "", "", "", true, false, 6, "", ParametrageListe.excludeaccred);
          DescriptionHelper _helper1 = new DescriptionHelper();
          dropdownHtml = _helper1.GenerateDropdownHtml(_Propsaccred);
          break;

        case "viewSocietes":
          IData.SocieteData soc = new IData.SocieteData();
          List<Utils.PropertyData> _Propssoc = Utils.PropertyData.GetListProperties2(soc, "", "", "", true, false, 6, "", ParametrageListe.excludesoc);
          DescriptionHelper _helper2 = new DescriptionHelper();
          dropdownHtml = _helper2.GenerateDropdownHtml(_Propssoc);
          break;

        case "viewDemandes":
          ViewModel.DemandeData dem = new ViewModel.DemandeData();
          List<Utils.PropertyData> _Propsdem = Utils.PropertyData.GetListProperties2(dem, "", "", "", false, false, 6, "", ParametrageListe.excludedem);
          DescriptionHelper _helper3 = new DescriptionHelper();
          foreach (var prop in _Propsdem)
          {
            if (prop.Description.Contains("Societe."))
            {
              prop.Description = prop.Description.Replace("Societe", "Société");
            }
            if (prop.Description.Contains("Accreditation."))
            {
              prop.Description = "Personne." + prop.Description.Replace("Accreditation", "Accréditation");
            }
            if (prop.Description.Contains("SocieteProd"))
            {
              prop.Description = prop.Description.Replace("SocieteProd", "Société de production");
            }
            if (prop.Description.Contains("SectionProgrammation"))
            {
              prop.Description = prop.Description.Replace("SectionProgrammation", "Section programmation");
            }
            if (prop.Description.Contains("StatutDiner"))
            {
              prop.Description = prop.Description.Replace("StatutDiner", "Statut diner");
            }
          }
          dropdownHtml = _helper3.GenerateDropdownHtml(_Propsdem);
          break;

        case "viewOperations":
          IData.OperationData ope = new IData.OperationData();
          List<Utils.PropertyData> _Propsope = Utils.PropertyData.GetListProperties2(ope, "", "", "", true, false, 6, "", ParametrageListe.excludeope);
          DescriptionHelper _helper4 = new DescriptionHelper();
          dropdownHtml = _helper4.GenerateDropdownHtml(_Propsope);
          break;

        case "viewCommandes":
          IData.MarcheCommandeData com = new IData.MarcheCommandeData();
          List<Utils.PropertyData> _Propscom = Utils.PropertyData.GetListProperties2(com, "", "", "", true, false, 6, "", ParametrageListe.excludecom);
          DescriptionHelper _helper5 = new DescriptionHelper();
          dropdownHtml = _helper5.GenerateDropdownHtml(_Propscom);
          break;

        case "viewInscriptionFilms":
          IData.InscriptionFilmData insc = new IData.InscriptionFilmData();
          List<Utils.PropertyData> _Propsinsc = Utils.PropertyData.GetListProperties2(insc, "", "", "", true, false, 6, "", ParametrageListe.excludeinsc);
          DescriptionHelper _helper6 = new DescriptionHelper();
          dropdownHtml = _helper6.GenerateDropdownHtml(_Propsinsc);
          break;

        case "viewMarcheProjections":
          IData.MarcheProjectionData proj = new IData.MarcheProjectionData();
          List<Utils.PropertyData> _Propsproj = Utils.PropertyData.GetListProperties2(proj, "", "", "", true, false, 6, "", ParametrageListe.excludeproj);
          DescriptionHelper _helper7 = new DescriptionHelper();
          dropdownHtml = _helper7.GenerateDropdownHtml(_Propsproj);
          break;
        case "viewMarcheProjectionsBdc":
          IData.MarcheBdcData bcd = new IData.MarcheBdcData();
          List<Utils.PropertyData> _Propsbcd = Utils.PropertyData.GetListProperties2(bcd, "", "", "", true, false, 6, "", ParametrageListe.excludebcd);
          DescriptionHelper _helper8 = new DescriptionHelper();
          dropdownHtml = _helper8.GenerateDropdownHtml(_Propsbcd);
          break;

        case "viewNotifications":
          IData.NotificationData notif = new IData.NotificationData();
          List<Utils.PropertyData> _Propsnotif = Utils.PropertyData.GetListProperties2(notif, "", "", "", true, false, 6, "");
          DescriptionHelper _helper9 = new DescriptionHelper();
          dropdownHtml = _helper9.GenerateDropdownHtml(_Propsnotif);
          break;
        case "viewbBillets":
          ViewModel.BilletData bil = new ViewModel.BilletData();
          List<Utils.PropertyData> _Propsbil = Utils.PropertyData.GetListProperties2(bil, "", "", "", true, false, 6, "", ParametrageListe.excludebil);
          DescriptionHelper _helper10 = new DescriptionHelper();
          foreach (var prop in _Propsbil)
          {
            if (prop.Description.Contains("Societe."))
            {
              prop.Description = prop.Description.Replace("Societe", "Société");
            }
            if (prop.Description.Contains("Accreditation."))
            {
              prop.Description = "Detenteur." + prop.Description.Replace("Accreditation", "Accréditation");
            }
            if (prop.Description.Contains("SocieteProd"))
            {
              prop.Description = prop.Description.Replace("SocieteProd", "Société de production");
            }
            if (prop.Description.Contains("SectionProgrammation"))
            {
              prop.Description = prop.Description.Replace("SectionProgrammation", "Section programmation");
            }
            if (prop.Description.Contains("StatutDiner"))
            {
              prop.Description = prop.Description.Replace("StatutDiner", "Statut diner");
            }
          }
          dropdownHtml = _helper10.GenerateDropdownHtml(_Propsbil);
          break;

        case "viewrsProjets":
          IData.RsProjetData rsdata = new IData.RsProjetData();
          List<Utils.PropertyData> _Propsrsdata = Utils.PropertyData.GetListProperties2(rsdata, "", "", "", true, false, 6, "", ParametrageListe.excludersdata);
          DescriptionHelper _helper11 = new DescriptionHelper();
          dropdownHtml = _helper11.GenerateDropdownHtml(_Propsrsdata);
          break;
      }

      return Ok(dropdownHtml);
    }

    [HttpGet("/Get/{id}")]
    public async Task<ActionResult> GetHelp(int id)
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
          connection.Open();
          string sql = "SELECT IdHelp, ContenuFr from Help WHERE IdHelp =" + id;

          using (SqlCommand command = new SqlCommand(sql, connection))
          {
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {

                string htmlContent = reader.GetString(1);
                var content = new StringContent(htmlContent, Encoding.UTF8, "text/html");
                return await Task.FromResult(new ContentResult
                {
                  ContentType = "text/html",
                  StatusCode = (int)HttpStatusCode.OK,
                  Content = await content.ReadAsStringAsync()
                });

              }
              connection.Close();
            }
          }
        }

      }

      catch { }
      
      return Ok();
    }

    [HttpGet("/GetCamp/{id}")]
    public async Task<ActionResult> GetCamp(int id)
    {
   
      try
      {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
          connection.Open();
          string sql = "select list.IdListeType,list.Type,camp.IdCampagne,Fichier from eCampagnes camp inner join eConfig conf on conf.IdConfig=camp.IdConfig inner join ListesTypes list on list.IdListeType=conf.IdListeType where camp.Valide='Y' and camp.IdCampagne =" + id;
          using (SqlCommand command = new SqlCommand(sql, connection))
          {
        
            using (SqlDataReader reader = command.ExecuteReader())
            {
              if (reader.Read())
              {
                string htmlContent = reader.GetString(3);
                var content = new StringContent(htmlContent, Encoding.UTF8, "text/html");
                return await Task.FromResult(new ContentResult
                {
                  ContentType = "text/html",
                  StatusCode = (int)HttpStatusCode.OK,
                  Content = await content.ReadAsStringAsync()
                });

              }
              connection.Close();
            }
         
          }
    
        }

      }

      catch { }
    
      return Ok();

    }
    [HttpGet("/TransEn")]
    public async Task<ActionResult> TransEn()
    {

      try
      {

        string idhelp = null;
        if (HttpContext.Session.TryGetValue("idhelp", out byte[] idhelpBytes))
        {
          idhelp = Encoding.UTF8.GetString(idhelpBytes);


          using (SqlConnection connection = new SqlConnection(_connectionString))
          {
            connection.Open();
            string sql = "SELECT IdHelp, ContenuUs from Help WHERE IdHelp =" + idhelp;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
              using (SqlDataReader reader = command.ExecuteReader())
              {
                if (reader.Read())
                {

                  string htmlContent = reader.GetString(1);
                  var content = new StringContent(htmlContent, Encoding.UTF8, "text/html");

                  return await Task.FromResult(new ContentResult
                  {
                    ContentType = "text/html",
                    StatusCode = (int)HttpStatusCode.OK,
                    Content = await content.ReadAsStringAsync()
                  });

                }
                connection.Close();
              }
            }
          }
        }
        else if (HttpContext.Session.TryGetValue("idcamp", out byte[] idcampBytes))
        {
          string idcamp = null;
          idcamp = Encoding.UTF8.GetString(idcampBytes);
          using (SqlConnection connection = new SqlConnection(_connectionString))
          {
            connection.Open();
            string sql = "select list.IdListeType,list.Type,camp.IdCampagne,FichierUs from eCampagnes camp inner join eConfig conf on conf.IdConfig=camp.IdConfig inner join ListesTypes list on list.IdListeType=conf.IdListeType where camp.Valide='Y' and camp.IdCampagne =" + idcamp;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
              using (SqlDataReader reader = command.ExecuteReader())
              {
                if (reader.Read())
                {

                  string htmlContent = reader.GetString(3);
                  var content = new StringContent(htmlContent, Encoding.UTF8, "text/html");

                  return await Task.FromResult(new ContentResult
                  {
                    ContentType = "text/html",
                    StatusCode = (int)HttpStatusCode.OK,
                    Content = await content.ReadAsStringAsync()
                  });

                }
                connection.Close();
              }
            }
          }
        }
      }

      catch { }
     
      return Ok();

    }
    [HttpGet("/TransFr")]
    public async Task<ActionResult> TransFr()
    {
      try
      {
        string idhelp = null;
        if (HttpContext.Session.TryGetValue("idhelp", out byte[] idhelpBytes))
        {
          idhelp = Encoding.UTF8.GetString(idhelpBytes);


          using (SqlConnection connection = new SqlConnection(_connectionString))
          {
            connection.Open();
            string sql = "SELECT IdHelp, ContenuFr from Help WHERE IdHelp =" + idhelp;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
              using (SqlDataReader reader = command.ExecuteReader())
              {
                if (reader.Read())
                {

                  string htmlContent = reader.GetString(1);
                  var content = new StringContent(htmlContent, Encoding.UTF8, "text/html");

                  return await Task.FromResult(new ContentResult
                  {
                    ContentType = "text/html",
                    StatusCode = (int)HttpStatusCode.OK,
                    Content = await content.ReadAsStringAsync()
                  });
                }
                connection.Close();
              }
            }
          }
        }

        else if (HttpContext.Session.TryGetValue("idcamp", out byte[] idcampBytes))
        {
          string idcamp = null;
          idcamp = Encoding.UTF8.GetString(idcampBytes);
          using (SqlConnection connection = new SqlConnection(_connectionString))
          {
            connection.Open();
            string sql = "select list.IdListeType,list.Type,camp.IdCampagne,Fichier from eCampagnes camp inner join eConfig conf on conf.IdConfig=camp.IdConfig inner join ListesTypes list on list.IdListeType=conf.IdListeType where camp.Valide='Y' and camp.IdCampagne =" + idcamp;
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
              using (SqlDataReader reader = command.ExecuteReader())
              {
                if (reader.Read())
                {

                  string htmlContent = reader.GetString(3);
                  var content = new StringContent(htmlContent, Encoding.UTF8, "text/html");

                  return await Task.FromResult(new ContentResult
                  {
                    ContentType = "text/html",
                    StatusCode = (int)HttpStatusCode.OK,
                    Content = await content.ReadAsStringAsync()
                  });

                }
                connection.Close();
              }
            }
          }
        }
      }

      catch { }
    
      return Ok();

    }


    [HttpPost("/Save/")]
    public async Task<ActionResult> CreatePost(IData.HelpData help)
    {
      string idhelp = null;
      if (HttpContext.Session.TryGetValue("idhelp", out byte[] idhelpBytes))
      {
        idhelp = Encoding.UTF8.GetString(idhelpBytes);

      }
      string lang = null;
      if (HttpContext.Session.TryGetValue("language", out byte[] languageBytes))
      {
        lang = Encoding.UTF8.GetString(languageBytes);

      }
      if (lang == "FR")
      {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
          await connection.OpenAsync();
          SqlCommand command = new SqlCommand("update Help set ContenuFr=@ContenuFr where IdHelp=@IdHelp", connection);
          command.Parameters.AddWithValue("@IdHelp", idhelp);
          command.Parameters.AddWithValue("@ContenuFr", help.ContenuFr);
          await command.ExecuteNonQueryAsync();
          connection.Close();
        }

        return Ok();
      }

      else
      {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
          await connection.OpenAsync();
          SqlCommand command = new SqlCommand("update Help set ContenuUs=@ContenuUs where IdHelp=@IdHelp", connection);
          command.Parameters.AddWithValue("@IdHelp", idhelp);
          command.Parameters.AddWithValue("@ContenuUs", help.ContenuUs);
          await command.ExecuteNonQueryAsync();
          connection.Close();
        }
        return Ok();
      }
    }
    [HttpPost("/SaveCamp/")]
    public async Task<ActionResult> CreatePostCamp(IData.MailerCampagneData campagne)
    {

      string idcamp = null;
      if (HttpContext.Session.TryGetValue("idcamp", out byte[] idcampBytes))
      {
            idcamp = Encoding.UTF8.GetString(idcampBytes);

      }

      string lang = null;
      if (HttpContext.Session.TryGetValue("language", out byte[] languageBytes))
      {
        lang = Encoding.UTF8.GetString(languageBytes);

      }
      if (lang == "FR")
      {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
          await connection.OpenAsync();
          SqlCommand command = new SqlCommand("update eCampagnes set Fichier=@Fichier where IdCampagne=@IdCamp", connection);
          command.Parameters.AddWithValue("@IdCamp", idcamp);
          command.Parameters.AddWithValue("@Fichier", campagne.Fichier);
          await command.ExecuteNonQueryAsync();
          connection.Close();
        }
        return Ok();
      }

      else
      {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
          await connection.OpenAsync();
          SqlCommand command = new SqlCommand("update eCampagnes set Fichier=@Fichier where IdCampagne=@IdCamp", connection);
          command.Parameters.AddWithValue("@IdCamp", idcamp);
          command.Parameters.AddWithValue("@Fichier", campagne.FichierUs);
          await command.ExecuteNonQueryAsync();
          connection.Close();
        }
        return Ok();
      }
    }

    private bool HelpExists(int id)
        {
            return _context._HelpDatas.Any(e => e.Id == id);
        }
    }
}
