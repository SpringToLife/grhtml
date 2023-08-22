using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel

{
  public class MarcheFilmData
  {
    
      [System.ComponentModel.Description("$$Librairie")]
      [IgnoreDataMember]
      public string Library { get; set; } = "Services.MarcheFilm.MarcheFilmClient, Services";

      [System.ComponentModel.Description("$$LibrairieDirecte")]
      [IgnoreDataMember]
      public string LibraryDirect { get; set; } = "WcfService.MarcheFilm, WcfService";

      [DataMember()]
      [System.ComponentModel.Description("$$OldValue")]
      [IgnoreDataMember]
      public MarcheFilmData OldData { get; set; }

      [System.ComponentModel.Description("Identifiant=IdFilm")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("$$IdUtilisateurModification=IdUtilisateurModification")]
      [DataMember()]
      public int? IdUtilisateurModification { get; set; }

      [System.ComponentModel.Description("Date de création=DateCreation")]
      [DataMember()]
      public DateTime DateCreation { get; set; }

      [System.ComponentModel.Description("Date de Modification=DateModification")]
      [DataMember()]
      public DateTime DateModification { get; set; }

      [System.ComponentModel.Description("$$Phonetique")]
      [DataMember()]
      public string Phonetique { get; set; }

      [System.ComponentModel.Description("Id. Cinando=IdCinando")]
      [DataMember()]
      public int? IdCinando { get; set; }

      [System.ComponentModel.Description("Date Cinando=DateCinando")]
      [DataMember()]
      public DateTime? DateCinando { get; set; }

      [System.ComponentModel.Description("$$IdSociete")]
      [DataMember()]
      public int? IdSociete { get; set; }

      [System.ComponentModel.Description("Société=Societes")]
      [DataMember()]
      public SocieteData Societe { get; set; }

      // <System.ComponentModel.Description("$$IdSocieteVente")>
      // <DataMember()>
      // Property IdSocieteVente As Integer?

      // <System.ComponentModel.Description("Société de vente=SocieteVente")>
      // <DataMember()>
      // Property SocieteVente As SocieteData

      [System.ComponentModel.Description("Année=Annee")]
      [DataMember()]
      public string Annee { get; set; }

      [System.ComponentModel.Description("Titre VA=Titre")]
      [DataMember()]
      public string Titre { get; set; }

      [System.ComponentModel.Description("Titre VO=TitreVo")]
      [DataMember()]
      public string TitreVo { get; set; }

      [System.ComponentModel.Description("Titre privé=TitrePrive")]
      [DataMember()]
      public string TitrePrive { get; set; }

      [System.ComponentModel.Description("Durée=Duree")]
      [DataMember()]
      public int? Duree { get; set; }

      [System.ComponentModel.Description("Durée trailer=DureeTrailer")]
      [DataMember()]
      public int? DureeTrailer { get; set; }

      [System.ComponentModel.Description("$$IdGenre")]
      [DataMember()]
      public int? IdGenre { get; set; }

      [System.ComponentModel.Description("Genre=mGenres")]
      [DataMember()]
      public MarcheGenreFilmData Genre { get; set; }

      [System.ComponentModel.Description("$$IdTypeFilm")]
      [DataMember()]
      public int? IdTypeFilm { get; set; }

      [System.ComponentModel.Description("Type=mTypesFilms")]
      [DataMember()]
      public MarcheTypeFilmData TypeFilm { get; set; }

      [System.ComponentModel.Description("Format Image=FormatImage")]
      [DataMember()]
      public string FormatImage { get; set; }

      [System.ComponentModel.Description("Format Son=FormatSon")]
      [DataMember()]
      public string FormatSon { get; set; }

      [System.ComponentModel.Description("Cryptage=Cryptage")]
      [DataMember()]
      public bool? Cryptage { get; set; }

      [System.ComponentModel.Description("Proj. secrète?=Confidentiel")]
      [DataMember()]
      public bool? Confidentiel { get; set; }

      [System.ComponentModel.Description("3D?=Relief")]
      [DataMember()]
      public bool? Relief { get; set; }

      [System.ComponentModel.Description("Fps=Fps")]
      [DataMember()]
      public string Fps { get; set; }

      [System.ComponentModel.Description("Budget=Budget")]
      [DataMember()]
      public string Budget { get; set; }

      [System.ComponentModel.Description("$$IdFestival")]
      [DataMember()]
      public int? IdFestival { get; set; }


      [System.ComponentModel.Description("$$IdPersonne")]
      [DataMember()]
      public int? IdPersonne { get; set; }

      [System.ComponentModel.Description("$$IdPays")]
      [DataMember()]
      public string IdPays { get; set; }

      [System.ComponentModel.Description("Pays")]
      [DataMember()]
      public string Pays { get; set; }

      [System.ComponentModel.Description("Année prod=AnneeProd")]
      [DataMember()]
      public string AnneeProd { get; set; }

      [System.ComponentModel.Description("Trailer?=Trailer")]
      [DataMember()]
      public bool? Trailer { get; set; }

      [System.ComponentModel.Description("Section=Section")]
      [DataMember()]
      public string Section { get; set; }

      [System.ComponentModel.Description("Non dématérialisé=NonDemat")]
      [DataMember()]
      public bool? NonDemat { get; set; }

      [System.ComponentModel.Description("Market Premiere?=MarketPremiere")]
      [DataMember()]
      public bool? MarketPremiere { get; set; }

      [System.ComponentModel.Description("Présenté en sélection?=Selection")]
      [DataMember()]
      public bool? Selection { get; set; }
      // <System.ComponentModel.Description("Réalisateurs groupés")>
      // <DataMember()>
      // Property Realisateursstring As String
      // Get
      // If Realisateurs Is Nothing Then Return ""
      // Dim _Realisateursstring As String = ""
      // For Each _Personne As PersonneData In Realisateurs
      // _Realisateursstring += _Personne.FullName + ", "
      // Next
      // If _Realisateursstring <> "" Then
      // Return _Realisateursstring.Substring(0, _Realisateursstring.Length - 2)
      // Else
      // Return ""
      // End If
      // End Get
      // Set(value As String)

      // End Set
      // End Property

      [System.ComponentModel.Description("Réalisateur Nom=RealisateurNom")]
      [DataMember()]
      public string RealisateurNom { get; set; }

      [System.ComponentModel.Description("Réalisateur Prénom=RealisateurPrenom")]
      [DataMember()]
      public string RealisateurPrenom { get; set; }

      [System.ComponentModel.Description("Réalisateur")]
      [DataMember()]
      public string Realisateur
      {
        get
        {
          return (RealisateurPrenom + " " + RealisateurNom).Trim();
        }
        set
        {
        }
      }

      [System.ComponentModel.Description("Caché Cinando?=Cache")]
      [DataMember()]
      public bool? Cache { get; set; }

      [System.ComponentModel.Description("$$Projections")]
      [DataMember()]
      public List<MarcheProjectionData> Projections { get; set; }

      [System.ComponentModel.Description("$$Copies")]
      [DataMember()]
      public List<MarcheCopieData> Copies { get; set; }

      [System.ComponentModel.Description("Date de sortie=DateSortie")]
      [DataMember()]
      public DateTime? DateSortie { get; set; }

      [System.ComponentModel.Description("Territoire=Territoire")]
      [DataMember()]
      public string Territoire { get; set; }

      [System.ComponentModel.Description("Site web=SiteWeb")]
      [DataMember()]
      public string SiteWeb { get; set; }

      //[System.ComponentModel.Description("Token")]
      //[DataMember()]
      //public string Token
      //{
      //  get
      //  {
      //    if (Id == null || Id < 1000)
      //      return "";
      //    else
      //    {
      //      string _Ret = (Id * 2).ToString();
      //      _Ret = new string(_Ret.ToArray().Reverse().ToArray());
      //      _Ret = Strings.Chr(System.Convert.ToInt32(_Ret.Substring(0, 1)) + 65) + _Ret.Substring(1);
      //      _Ret = _Ret.Substring(0, 2) + Strings.Chr(System.Convert.ToInt32(_Ret.Substring(2, 1)) + 112) + _Ret.Substring(3);
      //      return _Ret.Replace("I", "K");
      //    }
      //  }
      //  set
      //  {
      //  }
      //}

      [System.ComponentModel.Description("$$$Sc")]
      [DataMember()]
      public bool Sc { get; set; }
    }

    [DataContract()]
    public class MarcheFilmSectionData
    {
      [DataMember()]
      public int? IdSection { get; set; }

      [DataMember()]
      public string Section { get; set; }
    }

    [DataContract()]
    public class MarcheFilmSupportData
    {
      [System.ComponentModel.Description("$$Id")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [System.ComponentModel.Description("Libellé Fr.=LibelleFr")]
      [DataMember()]
      public string LibelleFr { get; set; }

      [System.ComponentModel.Description("Libellé Us.=LibelleUs")]
      [DataMember()]
      public string LibelleUs { get; set; }
    }

    [DataContract()]
    public class MarcheFilmStatutData
    {
      [System.ComponentModel.Description("$$IdStatut")]
      [DataMember()]
      public string IdStatut { get; set; }

      [System.ComponentModel.Description("Statut=Statut")]
      [DataMember()]
      public string Statut { get; set; }

      [System.ComponentModel.Description("$$Couleur")]
      [DataMember()]
      public string Couleur { get; set; }

      [System.ComponentModel.Description("Libelle Fr.=LibelleFr")]
      [DataMember()]
      public string LibelleFr { get; set; }

      [System.ComponentModel.Description("Libelle Us=LibelleUs")]
      [DataMember()]
      public string LibelleUs { get; set; }

      [System.ComponentModel.Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }
    }

    [DataContract()]
    public class MarcheGenreFilmData
    {
      [System.ComponentModel.Description("$$IdGenre")]
      [DataMember()]
      public int IdGenre { get; set; }

      [System.ComponentModel.Description("$$IdCinando")]
      [DataMember()]
      public int IdCinando { get; set; }

      [System.ComponentModel.Description("Visible?=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [System.ComponentModel.Description("Libellé fr=LibelleFr")]
      [DataMember()]
      public string LibelleFr { get; set; }

      [System.ComponentModel.Description("Libellé us=LibelleUs")]
      [DataMember()]
      public string LibelleUs { get; set; }
    }

    [DataContract()]
    public class MarcheTypeFilmData
    {
      [System.ComponentModel.Description("$$IdTypeFilm")]
      [DataMember()]
      public int IdTypeFilm { get; set; }

      [System.ComponentModel.Description("Type=TypeFilm")]
      [DataMember()]
      public string TypeFilm { get; set; }
    }

  
}
