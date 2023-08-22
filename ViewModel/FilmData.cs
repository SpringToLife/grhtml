
using Microsoft.VisualBasic;

using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using static GrapesJsEditorHtml.ViewModel.InscriptionFilmData.FormulaireSelectionData;

namespace GrapesJsEditorHtml.ViewModel
{

  public class LoadFilmDataFilter
  {
    [DataMember()]
    public bool ExcludePersonnesFilm { get; set; }
    [DataMember()]
    public bool ExcludeSocietesesFilm { get; set; }
    [DataMember()]
    public bool ExcludeImageFilm { get; set; }

    [DataMember()]
    public bool ExcludeFilmFestival { get; set; } // on ne compte pas les films de festival

    [DataMember()]
    public bool ExcludeCinefondation { get; set; } // on ne compte pas les films de CF

    [DataMember()]
    public bool ExcludeAllforAvisSelector { get; set; } // on ne compte pas les détails des films, mais seulement dAvisSectionneurs

    [DataMember()]
    public bool ExcludeCompteCreateur { get; set; } // on ne charge pas le compte du createur
  }


  [DataContract()]
  public class PayementInscriptionFilm
  {
    [DataMember()]
    public InscriptionFilmData InscriptionEnCours { get; set; }
    [DataMember()]
    public int IdTarif { get; set; }

    [DataMember()]
    public int Qte { get; set; } = 1;

    [DataMember()]
    public string PrixUnitaire { get; set; }

    [DataMember()]
    public string PrixHT { get; set; }

    [DataMember()]
    public string TauxTva { get; set; }

    [DataMember()]
    public string Tva { get; set; }

    [DataMember()]
    public string TotalTTC { get; set; }

    [DataMember()]
    public int SessionTarif { get; set; }

    [DataMember()]
    public double SessionTotal { get; set; }
  }

  [DataContract()]
  public class FilmData
  {

    [System.ComponentModel.Description("Actif")]
    [DataMember()]
    public bool? Actif { get; set; }
      
    [System.ComponentModel.Description("Identifiant=IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }

    [System.ComponentModel.Description("Id. Soif=IdSoif")]
    [DataMember()]
    public Guid? IdSoif { get; set; }

    [System.ComponentModel.Description("Date de création=DateCreation")]
    [DataMember()]
    public DateTime? DateCreation { get; set; }

    [System.ComponentModel.Description("Date de Modification=DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }

    [System.ComponentModel.Description("Date Sortie Fr=DateSortie")]
    [DataMember()]
    public DateTime? DateSortie { get; set; }

    [System.ComponentModel.Description("Date Sortie Us=DateSortieUs")]
    [DataMember()]
    public DateTime? DateSortieUs { get; set; }

    [System.ComponentModel.Description("Titre Original=TitreOriginal")]
    [DataMember()]
    public string TitreOriginal { get; set; }

    [System.ComponentModel.Description("Titre Original Alphabet Original=TitreOriginalAlphabetOriginal")]
    [DataMember()]
    public string TitreOriginalAlphabetOriginal { get; set; }

    [System.ComponentModel.Description("Titre Anglais=TitreAnglais")]
    [DataMember()]
    public string TitreAnglais { get; set; }

    [System.ComponentModel.Description("Titre Francais=TitreFrancais")]
    [DataMember()]
    public string TitreFrancais { get; set; }

    [System.ComponentModel.Description("$$Phonétique=Phonetique")]
    [DataMember()]
    [IgnoreDataMember()]
    public string Phonetique { get; set; }

    [System.ComponentModel.Description("Durée (mn)=Duree")]
    [DataMember()]
    public int? Duree { get; set; }


    [System.ComponentModel.Description("$$Durée (h)")]
    public string DureeHeure
    {
      get
      {
        if (Duree == null)
          return "N/A";
        else if (Duree >= 60)
          return Math.Truncate(System.Convert.ToDouble(Duree) / (double)60).ToString() + "h" + (Duree - Math.Truncate(System.Convert.ToDouble(Duree) / (double)60) * 60).ToString().PadLeft(2, System.Convert.ToChar("0"));
        else
          return Duree.ToString() + "mn";
      }
      set
      {
      }
    }


    [System.ComponentModel.Description("Année De Festival=Annee")]
    [DataMember()]
    public int? Annee { get; set; }

    [System.ComponentModel.Description("Année De Production=AnneeDeProduction")]
    [DataMember()]
    public int? AnneeDeProduction { get; set; }

    [System.ComponentModel.Description("$$Mois de production=MoisDeProduction")]
    [DataMember()]
    public int? MoisDeProduction { get; set; }

    //[System.ComponentModel.Description("Mois De Production")]
    //[DataMember()]
    //public string MoisDeProductionStr
    //{
    //  get
    //  {
    //    // Return MoisDeProduction.ToString
    //    // Debug.WriteLine("---------------Boucle infini???? ")
    //    if (MoisDeProduction == null || MoisDeProduction == 0)
    //      return "";
    //    else
    //      return (DateTime)"2000-" + MoisDeProduction.ToString() + "-01".ToString("MMMM");
    //  }
    //  set
    //  {
    //  }
    //}

    [System.ComponentModel.Description("Date de Production")]
    [DataMember()]
    public string DateProduction
    {
      get
      {
        // Return MoisDeProduction.ToString
        // Debug.WriteLine("---------------Boucle infini???? ")
        if (MoisDeProduction == null || MoisDeProduction == 0 || AnneeDeProduction == null)
          return "";
        else
          return MoisDeProduction.ToString().PadLeft(2, System.Convert.ToChar("0")) + "/" + AnneeDeProduction.ToString();
      }
      set
      {
      }
    }


    [System.ComponentModel.Description("$$Id. Categorie=IdCategorie")]
    [DataMember()]
    public int? IdCategorie { get; set; }

    [System.ComponentModel.Description("Catégorie=dCategories_Categorie")]
    [DataMember()]
    public string Categorie { get; set; }

    [System.ComponentModel.Description("$$CategorieUS")]
    [DataMember()]
    public string CategorieUS { get; set; }

    [System.ComponentModel.Description("Est Un Film D'Ecole De Cinema=EstUnFilmDEcoleDeCinema")]
    [DataMember()]
    public bool? EstUnFilmDEcoleDeCinema { get; set; }

    [System.ComponentModel.Description("$$Code inscription=CodeInscriptionEcole")]
    [DataMember()]
    public string CodeInscriptionEcole { get; set; } // pour accès Ecole

    [System.ComponentModel.Description("$$Code barre link=CodeBarreLink")]
    [DataMember()]
    public string CodeBarreLink { get; set; } // pour accès Ecole


    [System.ComponentModel.Description("Synopsis Francais=SynopsisFr")]
    [DataMember()]
    public string SynopsisFr { get; set; }

    [System.ComponentModel.Description("Synopsis Anglais=SynopsisEn")]
    [DataMember()]
    public string SynopsisEn { get; set; }

    [System.ComponentModel.Description("$$PaysFilm")]
    [DataMember()]
    [IgnoreDataMember()]
    public List<PaysFilmData> PaysFilms { get; set; }

    [System.ComponentModel.Description("Pays Film=Pays")]
    [DataMember()]
    public string PaysFilmsString { get; set; }

    [System.ComponentModel.Description("$$PaysFilmsStringUs")]
    [DataMember()]
    public string PaysFilmsStringUs { get; set; }

    [System.ComponentModel.Description("$$GenresFilm")]
    [DataMember()]
    [IgnoreDataMember()]
    public List<GenreFilmData> GenresFilm { get; set; }

    [System.ComponentModel.Description("Genres Film=Genres")]
    [DataMember()]
    public string GenresFilmString { get; set; }

    [System.ComponentModel.Description("$$Genres Us=GenresFilmStringUs")]
    [DataMember()]
    public string GenresFilmStringUs { get; set; }

    [System.ComponentModel.Description("$$IdFonction")]
    [DataMember()]
    public int? IdFonction { get; set; }

    [System.ComponentModel.Description("Fonction=dFonctions_Fonction")]
    [DataMember()]
    public string Fonction { get; set; }

    [System.ComponentModel.Description("Fonction Autre=FonctionAutre")]
    [DataMember()]
    public string FonctionAutre { get; set; }

    [System.ComponentModel.Description("$$PersonnesFilm")]
    [DataMember()]
    [IgnoreDataMember()]
    public List<PersonneFilmData> PersonnesFilm { get; set; }

    [System.ComponentModel.Description("Réalisateurs=Realisateurs")]
    [DataMember()]
    public string Realisateurs { get; set; }

    [System.ComponentModel.Description("$$RealisateursTri")]
    [DataMember()]
    [IgnoreDataMember()]
    public string RealisateursTri { get; set; }

    [System.ComponentModel.Description("Contacts=Contacts")]
    [DataMember()]
    public string Contacts { get; set; }

    // Get
    // Dim _Ret As String = ""
    // If PersonnesFilm IsNot Nothing Then
    // For Each _Personne As PersonneFilmData In PersonnesFilm
    // If _Personne.EstContact = False AndAlso (_Personne.FonctionEquipe = "Réalisateur" Or _Personne.IdFonctionPersonne = eFonctionPersonneFilm.Realisateur) Then
    // '  If _Ret <> "" Then _Ret += ";"
    // '  _Ret += _Personne.Personne.FullName
    // _Ret += _Personne.NomComplet + ";"
    // End If
    // Next
    // End If
    // If _Ret <> "" Then _Ret = _Ret.Substring(0, _Ret.LastIndexOf(";"))
    // Return _Ret
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [System.ComponentModel.Description("RealisateursCivilite=RealisateursCivilite")]
    [DataMember()]
    public string RealisateursCivilite { get; set; }


    [System.ComponentModel.Description("$$IdMainEcole")]
    [DataMember()]
    public int? IdMainEcole { get; set; }

    [System.ComponentModel.Description("$$IdMainProd")]
    [DataMember()]
    public int? IdMainProd { get; set; }


    public SocieteData SocieteProd { get; set; }


    public SocieteData Ecole { get; set; }

    [System.ComponentModel.Description("$$Langues")]
    [DataMember()]
    [IgnoreDataMember()]
    public List<LangueFilmData> Langues { get; set; }

    [System.ComponentModel.Description("Langues Film=Langues")]
    [DataMember()]
    public string LanguesString { get; set; }

    [System.ComponentModel.Description("$$LanguesstringUs")]
    [DataMember()]
    public string LanguesStringUS { get; set; }

    [System.ComponentModel.Description("$$LanguesSousTitre")]
    [DataMember()]
    [IgnoreDataMember()]
    public List<LangueFilmData> LanguesSousTitre { get; set; }

    [System.ComponentModel.Description("Langues Sous-Titre=SousTitre")]
    [DataMember()]
    public string LanguesSousTitreString { get; set; }

    [System.ComponentModel.Description("Est Version Definitive=EstVersionDefinitive")]
    [DataMember()]
    public bool? EstVersionDefinitive { get; set; }

    [System.ComponentModel.Description("Est restauré=EstRestaure")]
    [DataMember()]
    public bool? EstRestaure { get; set; }

    // <System.ComponentModel.Description("$$IdModeRestauration")>
    // <DataMember()>
    // Property IdModeRestauration As Integer?

    [System.ComponentModel.Description("Restauration Mode=ModeRestauration")]
    [DataMember()]
    public string ModeRestauration { get; set; }


    [System.ComponentModel.Description("Restauration responsable=ResponsableRestauration")]
    [DataMember()]
    public string ResponsableRestauration { get; set; }

    // <System.ComponentModel.Description("$$InformationsRestauration")>
    // <DataMember()>
    // Property InformationsRestauration As String

    [System.ComponentModel.Description("Restauration Notes Internes=AutresInformations")]
    [DataMember()]
    public string AutresInformations { get; set; }

    [System.ComponentModel.Description("Restauration Autres Informations Fr=AutresInformationsFr")]
    [DataMember()]
    public string AutresInformationsFr { get; set; }

    [System.ComponentModel.Description("Restauration Autres Informations En=AutresInformationsEn")]
    [DataMember()]
    public string AutresInformationsEn { get; set; }

    [System.ComponentModel.Description("Dédoublonné=Dedoublonne")]
    [DataMember()]
    public bool? Dedoublonne { get; set; }

    [System.ComponentModel.Description("Dialogues=Dialogues")]
    [DataMember()]
    public bool? Dialogues { get; set; }

    [System.ComponentModel.Description("Sous-Titres?=SousTitres")]
    [DataMember()]
    public bool? SousTitres { get; set; }

    [System.ComponentModel.Description("$$IdContactAccred")]
    [DataMember()]
    public int? IdContactAccred { get; set; }

    [System.ComponentModel.Description("$$IdImage")]
    [DataMember()]
    public int? IdImage { get; set; }

    [System.ComponentModel.Description("$$dImages")]
    [DataMember()]
    [IgnoreDataMember()]
    public ImageFilmData ImageFilm { get; set; }

    [System.ComponentModel.Description("Déjà Sélectionné Autre Festival?=DejaSelectionneAutreFestival")]
    [DataMember()]
    public bool? DejaSelectionneAutreFestival { get; set; }

    [System.ComponentModel.Description("$$AutreFestival")]
    [DataMember()]
    public string AutreFestival { get; set; }

    [System.ComponentModel.Description("Déjà Diffusé Tv Ou Cinema?=DejaDiffuseTvOuCinema")]
    [DataMember()]
    public bool? DejaDiffuseTvOuCinema { get; set; }


    [System.ComponentModel.Description("Conditions Diffuse Tv Ou Cinema=ConditionsDiffuseTvOuCinema")]
    [DataMember()]
    public string ConditionsDiffuseTvOuCinema { get; set; }


    [System.ComponentModel.Description("Déjà Diffusé Sur Internet?=DejaDiffuseSurInternet")]
    [DataMember()]
    public bool? DejaDiffuseSurInternet { get; set; }

    [System.ComponentModel.Description("Conditions Diffuse Sur Internet=ConditionsDejaDiffuseSurInternet")]
    [DataMember()]
    public string ConditionsDejaDiffuseSurInternet { get; set; }


    [System.ComponentModel.Description("Diffusion Premiere Mondiale?=DiffusionPremiereMondiale")]
    [DataMember()]
    public bool? DiffusionPremiereMondiale { get; set; }

    [System.ComponentModel.Description("Site Web=SiteWeb")]
    [DataMember()]
    public string SiteWeb { get; set; }

    // <System.ComponentModel.Description("Site Web En.=SiteWebSecondaire")>
    // <DataMember()>
    // Property SiteWebSecondaire As String
    [System.ComponentModel.Description("En savoir + Fr=EnSavoirPlusFr")]
    [DataMember()]
    public string EnSavoirPlusFr { get; set; }

    [System.ComponentModel.Description("En savoir + En=EnSavoirPlusEn")]
    [DataMember()]
    public string EnSavoirPlusEn { get; set; }

    [System.ComponentModel.Description("Commentaire=Commentaire")]
    [DataMember()]
    public string Commentaire { get; set; }

    [System.ComponentModel.Description("Commentaire Casting=CommentaireCasting")]
    [DataMember()]
    public string CommentaireCasting { get; set; }

    [System.ComponentModel.Description("Twitter=Twitter")]
    [DataMember()]
    public string Twitter { get; set; }

    [System.ComponentModel.Description("Facebook=Facebook")]
    [DataMember()]
    public string Facebook { get; set; }


    // <System.ComponentModel.Description("$$ReseauxSociaux")>
    // <DataMember()>
    // <IgnoreDataMember()>
    // Property ReseauxSociaux As List(Of ReseauSocialFilmData)

    // <System.ComponentModel.Description("Reseaux Sociaux=ReseauxSociaux")>
    // <DataMember()>
    // Property ReseauxSociauxString As String
    // Get

    // Dim _Ret As String = ""
    // If Not IsNothing(ReseauxSociaux) Then
    // For Each _ReseauSocial As ReseauSocialFilmData In ReseauxSociaux
    // _Ret += _ReseauSocial.ReseauSocialetUrl + ";"
    // Next
    // End If
    // Return _Ret
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [System.ComponentModel.Description("$$IdContact")]
    [DataMember()]
    public int? IdContact { get; set; }

    [System.ComponentModel.Description("Est Auto Produit?=EstAutoProduit")]
    [DataMember()]
    public bool? EstAutoProduit { get; set; }

    [System.ComponentModel.Description("Etalonnage Image?=EtalonnageImage")]
    [DataMember()]
    public bool? EtalonnageImage { get; set; }

    [System.ComponentModel.Description("Mixage Son?=MixageSon")]
    [DataMember()]
    public bool? MixageSon { get; set; }

    [System.ComponentModel.Description("Generiques Definitifs?=GeneriquesDefinitifs")]
    [DataMember()]
    public bool? GeneriquesDefinitifs { get; set; }

    [System.ComponentModel.Description("Effets Speciaux Terminés?=EffetsSpeciauxTermines")]
    [DataMember()]
    public bool? EffetsSpeciauxTermines { get; set; }

    [System.ComponentModel.Description("$$SocietesFilm")]
    [DataMember()]
    [IgnoreDataMember()]
    public List<SocieteFilmData> SocietesFilm { get; set; } = new List<SocieteFilmData>();

    [System.ComponentModel.Description("$$VideoDownloadState")]
    [DataMember()]
    public int? VideoDownloadState { get; set; }

    [System.ComponentModel.Description("IdVideoHoster")]
    [DataMember()]
    public string IdVideoHoster { get; set; }

    [System.ComponentModel.Description("$$InputKeyS3")]
    [DataMember()]
    public string InputKeyS3 { get; set; }

    [System.ComponentModel.Description("$$OutputKeyS3")]
    [DataMember()]
    public string OutputKeyS3 { get; set; }

    // <System.ComponentModel.Description("$$ReuploadS3FromBO")>
    // <DataMember()>
    // Property ReuploadS3FromBO As Boolean?

    [System.ComponentModel.Description("$$ReuploadS3FromFO")]
    [DataMember()]
    public bool? ReuploadS3FromFO { get; set; }

    // <System.ComponentModel.Description("$$ReuploadS3FromFODone")>
    // <DataMember()>
    // Property ReuploadS3FromFODone As Boolean?

    [System.ComponentModel.Description("Visibilite Film Apres Sfc?=VisibiliteFilmApresSfc")]
    [DataMember()]
    public bool? VisibiliteFilmApresSfc { get; set; }

    [System.ComponentModel.Description("Est 1er Film Du Real.?=EstPremierFilmDuRealisateur")]
    [DataMember()]
    public bool? EstPremierFilmDuRealisateur { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Id Cinando=IdCinando")]
    [IgnoreDataMember()]
    public int IdCinando { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    [IgnoreDataMember()]
    public FilmData OldData { get; set; }

    [System.ComponentModel.Description("Notes Internes=NotesInternes")]
    [DataMember()]
    public string NotesInternes { get; set; }

    [System.ComponentModel.Description("$$ReportData")]
    [IgnoreDataMember]
    public string ReportData { get; set; } = "GetFilmReport";

    [System.ComponentModel.Description("$$InscriptionsFilm")]
    [DataMember()]
    public List<InscriptionFilmData> InscriptionsFilm { get; set; } = new List<InscriptionFilmData>();

    [DataMember()]
    [System.ComponentModel.Description("$$CommunicationFilmData")]
    [IgnoreDataMember()]
    public CommunicationFilmData CommunicationFilmData { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Projection")]
    [IgnoreDataMember()]
    public ProgramSeanceData Projection { get; set; }

    //private List<ContactFilmData> FContactsFilm;
    //[DataMember()]
    //[System.ComponentModel.Description("$$ContactsFilm")]
    //[IgnoreDataMember()]
    //public List<ContactFilmData> ContactsFilm
    //{
    //  get
    //  {
    //    if (FContactsFilm != null)
    //      return FContactsFilm;
    //    List<ContactFilmData> _ContactsFilm = new List<ContactFilmData>();
    //    if (PersonnesFilm != null)
    //    {
    //      foreach (var _personne in PersonnesFilm)
    //      {
    //        // If Not IsNothing(_personne.IdFonctionPersonne) AndAlso (_personne.IdFonctionPersonne = FilmData.eFonctionPersonneFilm.Autre Or _personne.IdFonctionPersonne = FilmData.eFonctionPersonneFilm.Autoproducteur Or _personne.IdFonctionPersonne = FilmData.eFonctionPersonneFilm.Realisateur) Then
    //        if (_personne.EstContact)
    //        {
    //          ContactFilmData _ContactFilm = new ContactFilmData();
    //          _ContactFilm.PersonneFilm = _personne;
    //          _ContactFilm.Ordre = _personne.FonctionObject?.Ordre;
    //          _ContactsFilm.Add(_ContactFilm);
    //        }
    //      }
    //    }
    //    if (SocietesFilm != null)
    //    {
    //      foreach (var _societe in SocietesFilm)
    //      {
    //        ContactFilmData _ContactFilm = new ContactFilmData();
    //        _ContactFilm.SocieteFilm = _societe;
    //        _ContactFilm.Ordre = _societe.Fonction?.Ordre;
    //        _ContactsFilm.Add(_ContactFilm);
    //      }
    //    }
    //    if (_ContactsFilm == null || _ContactsFilm.Count == 0)
    //      return _ContactsFilm;
    //    else
    //    {
    //      List<ContactFilmData> _List = (from _C in _ContactsFilm
    //                                     orderby _C.Ordre, _C.SocieteFilm?.Ordre, _C.PersonneFilm?.Ordre, _C.Nom
    //                                     select _C).ToList;
    //      return _List;
    //    }
    //  }
    //  set
    //  {
    //  }
    //}


    //[DataMember()]
    //[System.ComponentModel.Description("$$ContactsFilm")]
    //[IgnoreDataMember()]
    //public List<MembreCastingFilmData> CastingFilm
    //{
    //  get
    //  {
    //    if (PersonnesFilm == null)
    //      return null;

    //    List<MembreCastingFilmData> _CastingFilm = new List<MembreCastingFilmData>();
    //    // Dim _Ordre As Integer = 1
    //    List<PersonneFilmData> _PersonnesFilm = (from _P in PersonnesFilm
    //                                             where _P.EstContact == false
    //                                             orderby IIf(_P.FonctionPersonneObject == null, 9999, _P.FonctionPersonneObject?.Ordre), _P.Ordre
    //                                             select _P).ToList;
    //    foreach (var _personne in _PersonnesFilm)
    //    {
    //      if ((!Information.IsNothing(_personne.IdFonctionPersonne) && _personne.EstContact == false && (_personne.IdFonctionPersonne == FilmData.eFonctionPersonneFilm.EquipeArtistique | _personne.IdFonctionPersonne == FilmData.eFonctionPersonneFilm.Interprete | _personne.IdFonctionPersonne == FilmData.eFonctionPersonneFilm.Realisateur) | !Information.IsNothing(_personne.IdFonctionEquipePersonne)))
    //      {
    //        MembreCastingFilmData _MembreCastingFilm = new MembreCastingFilmData();
    //        _MembreCastingFilm.PersonneFilm = _personne;
    //        _MembreCastingFilm.Film = null;
    //        _MembreCastingFilm.PersonneFilm.Film = null;
    //        // If _MembreCastingFilm.OrdreEquipe = 0 Then
    //        // _MembreCastingFilm.Ordre = _Ordre
    //        // _Ordre += 1  ' ne pas toucher a l'ordre car ca se repercute dans personnesfilm
    //        // End If
    //        _CastingFilm.Add(_MembreCastingFilm);
    //      }
    //    }
    //    return _CastingFilm;
    //  }
    //  set
    //  {
    //  }
    //}


    [DataMember()]
    [System.ComponentModel.Description("$$SecondScreenSubtitles")]
    public bool SecondScreenSubtitles
    {
      get
      {
        FilmData Film = this;
        if (Information.IsNothing(Film) && Information.IsNothing(Film.Langues))
          return false;
        if (Film.Langues != null && Film.Langues.Count > 1)
          return true;
        if (Film.Langues != null && Film.Langues.Count == 1)
        {
          if (Film.Langues.First().Langue != null && Film.Langues.First().Langue.IdLangue == "FR")
            return false;
          else if (Film.Langues.First().Langue != null && Film.Langues.First().Langue.IdLangue == "EN")
            return false;
          else
            return true;
        }
        return false;
      }
      set
      {
      }
    }


    public enum eVideoDownloadState
    {
      [System.ComponentModel.Description("InProgress")]
      InProgress = -1,
      [System.ComponentModel.Description("Ok")]
      Ok = 0,
      [System.ComponentModel.Description("WrongFilmFile")]
      WrongFilmFile = 1,
      [System.ComponentModel.Description("WrongAspectRatio")]
      WrongAspectRatio = 2,
      [System.ComponentModel.Description("InterlaceError")]
      InterlaceError = 3,
      [System.ComponentModel.Description("NoSound")]
      NoSound = 4,
      [System.ComponentModel.Description("NotComplete")]
      NotComplete = 5,
      [System.ComponentModel.Description("OtherIssue")]
      OtherIssue = 6
    }

    public enum eSectionSelection
    {
      CannesClassics = 1,
      Cinefondation = 2,
      EnCompetitionLM = 3,
      EnCompetitionCM = 4,
      ShortFilmCorner = 5,
      UnCertainRegard = 6,
      HorsCompetition = 7,
      CannesJunior = 8,
      ChacunSonCinema = 9,
      CinemaDeLaPlage = 10,
      CinemasEnFrance = 11,
      CopieRestauree = 12,
      CourtsMetrages = 13,
      DiversSectionParallele = 14,
      Hommage = 15,
      LAirDuTemps = 17,
      LePasseCompose = 18,
      LesYeuxFertiles = 19,
      ManifestationsExterieures = 20,
      PerspectivesCinemaFrancais = 21,
      QuinzaineDesRealisateurs = 22,
      Retrospective = 23,
      SeancesSpeciales = 24,
      SemaineDeLaCritique = 25,
      SeancesDeMinuit = 26,
      CannesPremiere = 37,
      LaCinef = 38
    }

    public enum eSectionInscription
    {
      [System.ComponentModel.Description("Cannes Classics")]
      CC = 1,
      [System.ComponentModel.Description("La Cinef")]
      CF = 8 // 
  ,
      [System.ComponentModel.Description("Sélection officielle longs métrages")]
      LM = 3 // 
  ,
      [System.ComponentModel.Description("Sélection officielle courts métrages")]
      CM = 4 // 
  ,
      [System.ComponentModel.Description("Short Film Corner")]
      SFC = 5 // 
  ,
      [System.ComponentModel.Description("Section parallèle")]
      SP = 6 // 
    }

    public enum eSectionInscriptionPossible
    {
      [System.ComponentModel.Description("Inscription possible")]
      OK = 1,
      // Les statuts d'interdiction d'inscriptions:
      [System.ComponentModel.Description("Inscription impossible")]
      NOK = -1,
      [System.ComponentModel.Description("Année de production ancienne")]
      AnneePrecedant = -12,
      [System.ComponentModel.Description("Cinéfondation. Durée du film doit etre inférieur à 60 min")]
      CF_DureeSuperieur60 = -21,
      [System.ComponentModel.Description("Cinéfondation. Le film doit avoir été réalisé au cours des 18 mois précédant le Festival de Cannes")]
      CF_DateProduction18Mois = -22,
      [System.ComponentModel.Description("Cinéfondation. Le film doit avoir été réalisé dans le cadre d'une école de Cinéma.")]
      CF_NotEcoleCinema = -23,
      [System.ComponentModel.Description("Cinéfondation. Les documentaires ne sont pas acceptés à la Cinéfondation.")]
      CF_FilmDocInterdit = -24,
      [System.ComponentModel.Description("Sélection officielle longs métrages. Durée du film doit etre suppérieur à 60 min")]
      LM_DureeInferieur60 = -31 // 
  ,
      [System.ComponentModel.Description("Sélection officielle longs métrages. Le film ne doit pas être une copie restaurée")]
      LM_FilmRestaure = -32 // 
  ,
      [System.ComponentModel.Description("Sélection officielle courts métrages. Durée du film doit etre inférieur ou égale à 15 min")]
      CM_DureeSuperieur15 = -41,
      [System.ComponentModel.Description("Sélection officielle courts métrages. Le film ne doit pas avoir été réalisé dans le cadre d'une école de Cinéma.")]
      CM_FilmEcole = -42,
      [System.ComponentModel.Description("Short Film Corner. Durée du film doit etre inférieur ou égale à 35 min")]
      SFC_DureeSuperieur35 = -51 // 
  ,


      // <System.ComponentModel.Description("Cannes Classics")>
      // CC = -6

      [System.ComponentModel.Description("Sélection officielle longs métrages. Durée du film doit etre suppérieur à 60 min")]
      CC_DureeInferieur60 = -61 // 
  ,
      [System.ComponentModel.Description("Section parallèle")]
      SP = -6 // 
    }

    // Public Enum eMillesimeSections
    // <System.ComponentModel.Description("MillesimSection LM")>
    // LM = 1
    // <System.ComponentModel.Description("MillesimSection SFC")>
    // SFC = 2
    // <System.ComponentModel.Description("MillesimSection CM")>
    // CM = 3
    // <System.ComponentModel.Description("MillesimSection CF")>
    // CF = 4
    // <System.ComponentModel.Description("MillesimSection Cannes Clasiques")>
    // CC = 5
    // <System.ComponentModel.Description("MillesimSection Parallèle")>
    // SP = 6
    // <System.ComponentModel.Description("MillesimSection Superviseur")>
    // SUP = 7
    // End Enum

    // Sur la base:
    // IdMillesimeSec     IdSectionIns     SectionIns
    // 1   3	Sélection officielle longs métrages
    // 2   5	Short Film Corner
    // 3   4	Sélection officielle courts métrages
    // 4   2	Cinéfondation
    // 5   1	Cannes Classics

    public enum eStatutAvisSelectionneurFilm
    {
      [System.ComponentModel.Description("A saisir")]
      A_saisir = 1,
      [System.ComponentModel.Description("Enregistré ")]
      Enregistre = 2,
      [System.ComponentModel.Description("Validé ")]
      Valide = 3,
      [System.ComponentModel.Description("Accepté le film SFC ")]
      AccepterSFC = 4,
      [System.ComponentModel.Description("Refusé le film SFC ")]
      RefuserSFC = 5
    }

    public enum eStatutFilm
    {
      [System.ComponentModel.Description("En cours d'inscription - Etape Ecole")]
      EtapeEcole = -13,
      [System.ComponentModel.Description("En cours d'inscription - Etape 1")]
      Etape1 = -12,
      [System.ComponentModel.Description("En cours d'inscription - Etape 2")]
      Etape2 = -11,
      [System.ComponentModel.Description("En cours d'inscription - Etape 3")]
      Etape3 = -10,
      [System.ComponentModel.Description("En cours d'inscription - Etape 4")]
      Etape4 = -9,
      [System.ComponentModel.Description("En cours d'inscription - Etape 5")]
      Etape5 = -8,
      [System.ComponentModel.Description("En cours d'inscription - Etape 6")]
      Etape6 = -7,
      [System.ComponentModel.Description("En cours d'inscription - Etape 7")]
      Etape7 = -6,
      [System.ComponentModel.Description("En cours d'inscription - Etape 8")]
      Etape8 = -5,
      [System.ComponentModel.Description("En cours d'inscription - Etape 8 bis")]
      Etape8bis = -4,
      [System.ComponentModel.Description("En cours d'inscription - Etape 9 (Validation Ecole CF)")]
      Etape9 = -3,
      [System.ComponentModel.Description("En cours d'inscription")]
      EnCoursDInscription = 10000 // -1
  ,
      [System.ComponentModel.Description("En attente de support")]
      EnAttenteDeSupport = 20000 // 0
  ,
      // <System.ComponentModel.Description("A traiter")>
      // ATraiter = 1
      [System.ComponentModel.Description("En cours de traitement")]
      EnCoursDeTraitement = 30000 // 2
  ,
      [System.ComponentModel.Description("Refusé")]
      Refuse = 40000 // 3
  ,
      [System.ComponentModel.Description("Sélectionné")]
      Selectionne = 50000 // 4
  ,
      [System.ComponentModel.Description("Annulé")]
      Annule = 60000 // 5
  ,
      [System.ComponentModel.Description("AcceptéSFC")]
      AccepteSFC = 70000,
      HorsDelais = -1
    }

    public enum eSousEtatFilm
    {
      [System.ComponentModel.Description("En cours d'inscription - Non finalisée")]
      EnCoursDInscription_NonFinalisee = 10100 // 0
  ,
      [System.ComponentModel.Description("En cours d'inscription - Non Finalisee - Etape 2 (New workflow)")]
      EnCoursDInscription_NonFinalisee_Etape2 = 10140,
      [System.ComponentModel.Description("En cours d'inscription - Non Finalisee - Etape 3 (New workflow)")]
      EnCoursDInscription_NonFinalisee_Etape3 = 10150,
      [System.ComponentModel.Description("En cours d'inscription - Non Finalisee - Etape 4 (New workflow)")]
      EnCoursDInscription_NonFinalisee_Etape4 = 10160,
      [System.ComponentModel.Description("En cours d'inscription - A payer")]
      EnCoursDInscription_APayer = 10200 // 1
  ,
      // not used anymore
      // <System.ComponentModel.Description("En cours d'inscription - Inscription tardive")>
      // EnCoursDInscription_InscriptionTardive = 10300 '2
      // <System.ComponentModel.Description("En Attente De Transmission - Film à envoyer")>
      // EnAttenteDeTransmission_FilmAEnvoyer = 20100 '3
      [System.ComponentModel.Description("En attente de transmission - Film non téléchargé payé")]
      EnAttenteDeTransmission_FilmAEnvoyer = 20200 // 4
  ,
      [System.ComponentModel.Description("En attente de transmission - Film En Transfert")]
      EnAttenteDeTransmission_FilmEnTransfert = 20300 // 25
  ,
      [System.ComponentModel.Description("En attente de transmission -  Film téléchargé en attente d'encodage")]
      EnAttenteDeTransmission_FilmTéléchargéEnAttentedEncodage = 20400 // 26
  ,
      // <System.ComponentModel.Description("En attente de transmission -  Film téléchargé en encodage")>
      // EnAttenteDeTransmission_FilmTéléchargéEnEncodage = 20500 '27
      // new Tech-Event
      [System.ComponentModel.Description("En attente de transmission -  Film téléchargé erreur encodage")]
      EnAttenteDeTransmission_FilmTéléchargéErreurEncodage = 20600 // 28
  ,
      [System.ComponentModel.Description("En attente de transmission - Film téléchargé non vérifié")]
      EnAttenteDeTransmission_FilmTéléchargeNonVérifié = 20700 // 8
  ,

      // <System.ComponentModel.Description("En cours de traitement - Film téléchargé validé")>
      // EnCoursDeTraitement_FilmTéléchargéEtValidé = 30100 '5 

      [System.ComponentModel.Description("En cours de traitement - Film reçu")]
      EnCoursDeTraitement_FilmReçu = 30200  // 6 ' ATraiter_FilmReçu = 6
  ,
      [System.ComponentModel.Description("En cours de traitement - Film vu")]
      EnCoursDeTraitement_FilmVu = 30400 // 11
  ,

      // new Tech-Event
      [System.ComponentModel.Description("En cours de traitement - Film à visionner")]
      EnCoursDeTraitement_FilmAVisionner = 30300 // 30
  ,
      [System.ComponentModel.Description("En cours de traitement - Film à refuser")]
      EnCoursDeTraitement_FilmARefuser = 30500,
      [System.ComponentModel.Description("En cours de traitement - Film à refuser special")]
      EnCoursDeTraitement_FilmARefuserSpecial = 30600,
      [System.ComponentModel.Description("En cours de traitement - Film à sélectionner")]
      EnCoursDeTraitement_FilmASelectionner = 30700,
      [System.ComponentModel.Description("Refusé")]
      Refuse_Refuse = 40100 // 18
  ,
      [System.ComponentModel.Description("Refusé - A rembourser")]
      Refuse_RefuseARembourser = 40200 // 20
  ,
      [System.ComponentModel.Description("Refusé - Remboursé")]
      Refuse_RefuseRembourse = 40300 // 21
  ,

      // new Tech-Event
      [System.ComponentModel.Description("Sélectionné - Dossier fermé")]
      Selectionne_DossierFerme = 50100 // 31
  ,
      [System.ComponentModel.Description("Sélectionné - A compléter")]
      Selectionne_ACompleter = 50200 // 22
  ,
      [System.ComponentModel.Description("Sélectionné SFC - Dossier fermé")]
      SelectionneSfc_DossierFerme = 70100 // 31
  ,
      [System.ComponentModel.Description("Sélectionné SFC - A compléter")]
      SelectionneSfc_ACompleter = 70200 // 22
  ,




      // new Tech-Event
      [System.ComponentModel.Description("Annulé")]
      Annule_annule = 60100 // 29
    }

    public enum eEtatTraduction
    {
      [System.ComponentModel.Description("A traduire")]
      A_traduire = 0,
      [System.ComponentModel.Description("Est Traduit")]
      EstTraduit = 1,
      [System.ComponentModel.Description("Ne Pas traduire")]
      NePastraduire = 2,
      [System.ComponentModel.Description("En cours")]
      EnCours = 3
    }

    public enum eSupportTransmission
    {
      [System.ComponentModel.Description("DVD (DVD Standard)")]
      DVD = 1,
      [System.ComponentModel.Description("Blu-ray (+1 DVD Standard)")]
      BluRay = 2,
      [System.ComponentModel.Description("HDCAM / HDCAM SR")]
      HDCAM = 3,
      [System.ComponentModel.Description("16mm")]
      seizeMM = 4,
      [System.ComponentModel.Description("35mm")]
      TrenteCinqMM = 5,
      [System.ComponentModel.Description("70mm")]
      SoixanteDixMM = 6,
      [System.ComponentModel.Description("Beta")]
      Beta = 7,
      [System.ComponentModel.Description("Beta Numérique (Pal, NTSC)")]
      BetaNumerique = 8,
      [System.ComponentModel.Description("Beta SP (Pal, NTSC)")]
      BetaSP = 9,
      [System.ComponentModel.Description("DCP")]
      DCP = 10,
      [System.ComponentModel.Description("Autre support")]
      AutreSupport = 11,
      [System.ComponentModel.Description("VHS")]
      VHS = 12,
      [System.ComponentModel.Description("Fichier")]
      Fichier = 13,
      [System.ComponentModel.Description("Lien")]
      Lien = 14
    }
    public enum eFonctionSocieteFilm
    {
      [System.ComponentModel.Description("Société de production")]
      SocieteProduction = 1,
      [System.ComponentModel.Description("Société de distribution")]
      SocieteDistribution = 3,
      [System.ComponentModel.Description("Société Ventes Internationales")]
      SocieteVentesInternationales = 2,
      [System.ComponentModel.Description("Ecole")]
      Ecole = 4,
      [System.ComponentModel.Description("Société de co-production")]
      Societe_CoProduction = 5,
      [System.ComponentModel.Description("Société de presse française")]
      Societe_Presse_Francaise = 6,
      [System.ComponentModel.Description("Société de presse internationale")]
      Societe_Presse_Internationale = 7
    }

    public enum eModeTransmissionFilm
    {
      [System.ComponentModel.Description("Envoi Physique")]
      EnvoiPhysique = 1,
      [System.ComponentModel.Description("Téléchargement")]
      Téléchargement = 2,
      [System.ComponentModel.Description("LienVisualisation")]
      LienVisualisation = 3,
      [System.ComponentModel.Description("Aucun")]
      Aucun = 4,
      [System.ComponentModel.Description("Dcp")]
      Dcp = 5
    }


    public enum eFonctionPersonneFilm
    {
      [System.ComponentModel.Description("Réalisateur")]
      Realisateur = 1,
      [System.ComponentModel.Description("Interprète")]
      Interprete = 2,
      [System.ComponentModel.Description("Equipe Artistique")]
      EquipeArtistique = 3,
      [System.ComponentModel.Description("AutoProducteur")]
      Autoproducteur = 4,
      [System.ComponentModel.Description("Autre")]
      Autre = 5
    }

    public enum eFonctionEquipeFilm
    {
      [System.ComponentModel.Description("Animation")]
      Animation = 1,
      [System.ComponentModel.Description("Assistant réalisateur")]
      AssistantRealisateur = 2,
      [System.ComponentModel.Description("Costumes")]
      Costumes = 3,
      [System.ComponentModel.Description("Décors")]
      Decors = 4,
      [System.ComponentModel.Description("Directeur de la photographie")]
      DirecteurPhotographie = 5,
      [System.ComponentModel.Description("Ingénieur du son")]
      IngenieurSon = 6,
      [System.ComponentModel.Description("Mixeur")]
      Mixeur = 7,
      [System.ComponentModel.Description("Montage")]
      Montage = 8,
      [System.ComponentModel.Description("Musique")]
      Musique = 9,
      [System.ComponentModel.Description("Producteur")]
      Producteur = 10,
      [System.ComponentModel.Description("Producteur exécutif")]
      ProducteurExecutif = 11,
      [System.ComponentModel.Description("Scénario / Dialogues")]
      ScenarioDialogues = 12,
      [System.ComponentModel.Description("Son")]
      Son = 13
    }
  }

  [DataContract()]
  public class CommunicationFilmData
  {
    [System.ComponentModel.Description("CodeInscription")]
    [DataMember()]
    public string CodeInscription { get; set; }

    [System.ComponentModel.Description("EmailNotification")]
    [DataMember()]
    public string EmailNotification { get; set; }

    // Au cas de chargement du film avec le dossier associé (donc Liste des inscriptions, on pourrait charger la liste des codes et Email pour chaque section comme ci-dessous...)

    [System.ComponentModel.Description("CodeSupport")]
    [DataMember()]
    public string CodeSupport { get; set; }

    [System.ComponentModel.Description("EmailNotificationCF")]
    [DataMember()]
    public string EmailNotificationCF { get; set; }

    [System.ComponentModel.Description("CodeInscriptionCF")]
    [DataMember()]
    public string CodeInscriptionCF { get; set; }

    [System.ComponentModel.Description("EmailNotificationCM")]
    [DataMember()]
    public string EmailNotificationCM { get; set; }

    [System.ComponentModel.Description("CodeInscriptionCM")]
    [DataMember()]
    public string CodeInscriptionCM { get; set; }

    [System.ComponentModel.Description("EmailNotificationSFC")]
    [DataMember()]
    public string EmailNotificationSFC { get; set; }

    [System.ComponentModel.Description("CodeInscriptionSFC")]
    [DataMember()]
    public string CodeInscriptionSFC { get; set; }

    [System.ComponentModel.Description("EmailNotificationLM")]
    [DataMember()]
    public string EmailNotificationLM { get; set; }

    [System.ComponentModel.Description("CodeInscriptionLM")]
    [DataMember()]
    public string CodeInscriptionLM { get; set; }

    [System.ComponentModel.Description("EmailNotificationCC")]
    [DataMember()]
    public string EmailNotificationCC { get; set; }

    [System.ComponentModel.Description("CodeInscriptionCC")]
    [DataMember()]
    public string CodeInscriptionCC { get; set; }

    [System.ComponentModel.Description("EmailNotificationSP")]
    [DataMember()]
    public string EmailNotificationSP { get; set; }

    [System.ComponentModel.Description("CodeInscriptionSP")]
    [DataMember()]
    public string CodeInscriptionSP { get; set; }

    [System.ComponentModel.Description("Ecole")]
    [DataMember()]
    public SocieteFilmData Ecole { get; set; }

    [System.ComponentModel.Description("CompteCreateur")]
    [DataMember()]
    public CompteData CompteCreateur { get; set; }

    [System.ComponentModel.Description("Liste mails prévenant d'une nouvelle inscription finalisée=EmailNotificationFinInscription")]
    [DataMember()]
    public string EmailNotifFinInscription { get; set; }

    // un mail générique pour toutes les sections, qui remplace les 5 mail ci-dessus
    [System.ComponentModel.Description("Liste mails prévenant d'une nouvelle inscription Validée par un sélectionneur=EmailNotificationValidationAvis")]
    [DataMember()]
    public string EmailNotifValidationAvis { get; set; }
  }

  [DataContract()]
  public class PaysFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }


    [System.ComponentModel.Description("Pays")]
    [DataMember()]
    public PaysData Pays { get; set; }

    [System.ComponentModel.Description("Ordre")]
    [DataMember()]
    public int? Ordre { get; set; }
  }

  [DataContract()]
  public class LangueFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }


    [System.ComponentModel.Description("Langue")]
    [DataMember()]
    public LangueData Langue { get; set; }
  }

  [DataContract()]
  public class ImageFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("AutreFormat")]
    [DataMember()]
    public string AutreFormat { get; set; }

    [System.ComponentModel.Description("Couleur")]
    [DataMember()]
    public bool? Couleur { get; set; }

    [System.ComponentModel.Description("NoirEtBlanc")]
    [DataMember()]
    public bool? NoirEtBlanc { get; set; }

    [System.ComponentModel.Description("EstEn3D")]
    [DataMember()]
    public bool? EstEn3D { get; set; }

    [System.ComponentModel.Description("EstEn2D")]
    [DataMember()]
    public bool? EstEn2D { get; set; }

    [System.ComponentModel.Description("IdFormatTournage")]
    [DataMember()]
    public int? IdFormatTournage { get; set; }

    [System.ComponentModel.Description("IdFormatPellicule")]
    [DataMember()]
    public int? IdFormatPellicule { get; set; }

    [System.ComponentModel.Description("IdFormatVideo")]
    [DataMember()]
    public int? IdFormatVideo { get; set; }

    [System.ComponentModel.Description("IdFormatFps")]
    [DataMember()]
    public int? IdFormatFps { get; set; }

    [System.ComponentModel.Description("IdSupportExistant")]
    [DataMember()]
    public int? IdSupportExistant { get; set; }

    [System.ComponentModel.Description("ListIdSupportExistant")]
    [DataMember()]
    public List<ImageSupportFilmData> ListSupportExistant { get; set; }
  }

  [DataContract()]
  public class ImageSupportFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdImage")]
    [DataMember()]
    public int? IdImage { get; set; }

    [System.ComponentModel.Description("IdImageSoif")]
    [DataMember()]
    public int? IdImageSoif { get; set; }


    [System.ComponentModel.Description("IdSupportExistant")]
    [DataMember()]
    public int? IdSupportExistant { get; set; }

    [System.ComponentModel.Description("SupportExistant")]
    [DataMember()]
    public string SupportExistant { get; set; }
  }


  // <DataContract>
  // Public Class DossierInscriptionFilmData

  // <System.ComponentModel.Description("Identifiant=IdDossierInscription")>
  // <DataMember()>
  // Property Id As Integer?

  // <System.ComponentModel.Description("$$IdSoif")>
  // <DataMember()>
  // Property IdSoif As Guid

  // <System.ComponentModel.Description("$$IdFilm")>
  // <DataMember()>
  // Property IdFilm As Integer?

  // <System.ComponentModel.Description("$$StatutDossier")>
  // <DataMember()>
  // Property StatutDossier As Integer?

  // <System.ComponentModel.Description("Code=CodeDossier")>
  // <DataMember()>
  // Property CodeDossier As String


  // <System.ComponentModel.Description("$$IdCopieProjection")>
  // <DataMember()>
  // Property IdCopieProjection As Integer?

  // <System.ComponentModel.Description("$$IdOperation")>
  // <DataMember()>
  // Property IdOperation As Integer?

  // <System.ComponentModel.Description("$$EtatTraduction")>
  // <DataMember()>
  // Property EtatTraduction As Integer?

  // <System.ComponentModel.Description("Traduction")>
  // <DataMember()>
  // Property Traduction As String
  // Get
  // If EtatTraduction = 0 Then
  // Return "A traduire"
  // ElseIf EtatTraduction = 1 Then
  // Return "Traduit"
  // Else
  // Return "Ne pas traduire"
  // End If
  // End Get
  // Set(value As String)
  // If value = "A traduire" Then
  // EtatTraduction = 0
  // ElseIf value = "Traduit" Then
  // EtatTraduction = 1
  // Else
  // EtatTraduction = 2
  // End If
  // End Set
  // End Property

  // <System.ComponentModel.Description("$$TelechargementsObligatoiresDone")>
  // <DataMember()>
  // Property TelechargementsObligatoiresDone As Boolean?

  // <System.ComponentModel.Description("$$InscriptionsFilm")>
  // <DataMember()>
  // Property InscriptionsFilm As New List(Of InscriptionFilmData)

  // <System.ComponentModel.Description("$$Sélection")>
  // <DataMember()>
  // Property Selection As InscriptionFilmData

  // <System.ComponentModel.Description("$$CopieProjection")>
  // <DataMember()>
  // Property CopieProjection As CopieProjectionData


  // <System.ComponentModel.Description("$$FormulairesSelection")>
  // <DataMember()>
  // Property FormulairesSelection As New List(Of FormulaireSelectionData)


  // Public Property UploadsCompleted() As Boolean
  // Get
  // Dim DossierInscription As DossierInscriptionFilmData = Me
  // If DossierInscription.TelechargementsObligatoiresDone.HasValue AndAlso DossierInscription.TelechargementsObligatoiresDone.Value = True Then
  // Return True
  // Else
  // Return False
  // End If
  // End Get
  // Set(value As Boolean)
  // End Set
  // End Property
  // End Class

  [DataContract]
  public class InscriptionFilmData
  {
    [System.ComponentModel.Description("$$Librairie")]
    [IgnoreDataMember]
    public string Library { get; set; } = "Services.Film.FilmClient, Services";

    [System.ComponentModel.Description("$$LibrairieDirecte")]
    [IgnoreDataMember]
    public string LibraryDirect { get; set; } = "WcfService.Film, WcfService";

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    [IgnoreDataMember()]
    public InscriptionFilmData OldData { get; set; }

    [System.ComponentModel.Description("Identifiant=IdInscriptionFilm")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$IdSoif")]
    [DataMember()]
    public double IdSoif { get; set; }

    [System.ComponentModel.Description("Code=Code")]
    [DataMember()]
    public string Code { get; set; }

    [System.ComponentModel.Description("Code Support=CodeSupport")]
    [DataMember()]
    public string CodeSupport { get; set; }

    [System.ComponentModel.Description("Date sélection=DateSelection")]
    [DataMember()]
    public DateTime? DateSelection { get; set; }

    [System.ComponentModel.Description("Date création=DateCreation")]
    [DataMember()]
    public DateTime? DateCreation { get; set; }

    [System.ComponentModel.Description("Date internet=DateWeb")]
    [DataMember()]
    public DateTime? DateWeb { get; set; }

    [System.ComponentModel.Description("Date modification=DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }

    [System.ComponentModel.Description("Date annulation=DateAnnulation")]
    [DataMember()]
    public DateTime? DateAnnulation { get; set; }

    [System.ComponentModel.Description("Créé par=CreePar")]
    [DataMember()]
    public string CreePar { get; set; }

    [System.ComponentModel.Description("Modifié par=ModifiePar")]
    [DataMember()]
    public string ModifiePar { get; set; }

    [System.ComponentModel.Description("Annulé par=AnnulePar")]
    [DataMember()]
    public string AnnulePar { get; set; }

    [System.ComponentModel.Description("$$Statut")]
    [DataMember()]
    public int? Statut { get; set; }

    [System.ComponentModel.Description("Statut=dStatutsFilms_StatutFilm")]
    [DataMember()]
    public string StatutStr { get; set; }

    [System.ComponentModel.Description("$$Statut=StatutInscription")]
    [DataMember()]
    public StatutFilmData StatutInscription { get; set; }

    [System.ComponentModel.Description("$$Sous-Statut=SousEtatEnum")]
    [DataMember()]
    public int? SousEtatEnum { get; set; }

    [System.ComponentModel.Description("$$Sous-Statut=dSousEtatFilms_SousEtatFilm")]
    [DataMember()]
    public SousEtatFilmData SousEtat { get; set; }

    [System.ComponentModel.Description("Sous-Statut=dSousEtatFilms_SousEtatFilm")]
    [DataMember()]
    public string SousEtatEnumStr { get; set; }

    [System.ComponentModel.Description("$$IdMillesimeSection")]
    [DataMember()]
    public int? IdMillesimeSection { get; set; }

    [System.ComponentModel.Description("Millésime Section=dMillesimeSectionInscriptions")]
    [DataMember()]
    public MillesimeSectionInscriptionData MillesimeSectionInscription { get; set; }

    [System.ComponentModel.Description("Film Ingeste?=FilmIngeste")]
    [DataMember()]
    public bool FilmIngeste { get; set; }

    [System.ComponentModel.Description("Kdm Reçu?=KdmRecu")]
    [DataMember()]
    public bool? KdmRecu { get; set; }

    [System.ComponentModel.Description("Fichier valide?=FichierValide")]
    [DataMember()]
    public bool? FichierValide { get; set; }

    // <System.ComponentModel.Description("Exoneré ?=Exonere")>
    // <DataMember()>
    // Property Exonere As Boolean?

    [System.ComponentModel.Description("Payé ?=Paye")]
    [DataMember()]
    public bool? Paye { get; set; }

    [System.ComponentModel.Description("$$Accès étudiant ?=AccesEtudiant")]
    [DataMember()]
    public bool? AccesEtudiant { get; set; }

    [System.ComponentModel.Description("Code promo=CodePromo")]
    [DataMember()]
    public string CodePromo { get; set; }

    [System.ComponentModel.Description("$$IdGala")]
    [DataMember()]
    public int? IdGala { get; set; }

    [System.ComponentModel.Description("Nb. Accreditations=NbAccreditations")]
    [DataMember()]
    public int? NbAccreditations { get; set; }

    [System.ComponentModel.Description("Nb. Gratuits=NbGratuits")]
    [DataMember()]
    public int? NbGratuits { get; set; }

    [System.ComponentModel.Description("Programmes Sfc=Favoris")]
    [DataMember()]
    public string Favoris { get; set; }

    [System.ComponentModel.Description("Publie Vod?=PublieVod")]
    [DataMember()]
    public bool PublieVod { get; set; }

    [System.ComponentModel.Description("$$IdSectionSelection")]
    [DataMember()]
    public int? IdSectionSelection { get; set; }


    [System.ComponentModel.Description("$$Section sélection=dSectionSelections")]
    [DataMember()]
    public SectionSelectionFilmData SectionSelection { get; set; }


    [System.ComponentModel.Description("Section Sélection=dSectionSelections_Libelle")]
    [DataMember()]
    public string SectionSelectionFR
    {
      get
      {
        if (SectionSelection != null)
          return SectionSelection.Libelle;
        return null;
      }
      set
      {
      }
    }

    [System.ComponentModel.Description("$$Section Sélection En")]
    [DataMember()]
    public string SectionSelectionEn
    {
      get
      {
        if (SectionSelection != null)
          return SectionSelection.LibelleUs;
        return null;
      }
      set
      {
      }
    }

    [System.ComponentModel.Description("$$SousSection sélection=dSousSectionSelections")]
    [DataMember()]
    public SousSectionSelectionFilmData SousSectionSelection { get; set; }

    [System.ComponentModel.Description("Sous-section sélection")]
    [DataMember()]
    public string SousSectionSelectionFr
    {
      get
      {
        if (SousSectionSelection != null)
          return SousSectionSelection.Libelle;
        return null;
      }
      set
      {
      }
    }


    [System.ComponentModel.Description("$$SousSection Sélection En")]
    [DataMember()]
    public string SousSectionSelectionEn
    {
      get
      {
        if (SousSectionSelection != null)
          return SousSectionSelection.LibelleUs;
        return null;
      }
      set
      {
      }
    }

    [System.ComponentModel.Description("$$Section d'inscription FR")]
    [DataMember()]
    public string SectionInscriptionFR
    {
      get
      {
        if (MillesimeSectionInscription?.SectionInscriptionDonnee != null)
          return MillesimeSectionInscription.SectionInscriptionDonnee.SectionInscriptionFR;
        return null;
      }
      set
      {
      }
    }

    [System.ComponentModel.Description("$$Section d'inscription EN")]
    [DataMember()]
    public string SectionInscriptionEN
    {
      get
      {
        if (MillesimeSectionInscription?.SectionInscriptionDonnee != null)
          return MillesimeSectionInscription.SectionInscriptionDonnee.SectionInscriptionEN;
        return null;
      }
      set
      {
      }
    }

    [System.ComponentModel.Description("Accredités validés?=AccreditesValides")]
    [DataMember()]
    public bool AccreditesValides { get; set; }

    [System.ComponentModel.Description("Archive?=Archive")]
    [DataMember()]
    public bool? Archive { get; set; }

    [System.ComponentModel.Description("$$Paye")]
    [DataMember()]
    public string IdStatutPaiement { get; set; } = "N";

    [System.ComponentModel.Description("Statut paiement=aStatutsPaiements_Libelle")]
    [DataMember()]
    public string StatutPaiement { get; set; }

    [System.ComponentModel.Description("$$IdSocieteFacturee")]
    [DataMember()]
    public int? IdSocieteFacturee { get; set; }

    [System.ComponentModel.Description("$$IdFacture")]
    [DataMember()]
    public int? IdFacture { get; set; }

    [System.ComponentModel.Description("$$IdReglement")]
    [DataMember()]
    public int? IdReglement { get; set; }

    [System.ComponentModel.Description("Montant=Montant")]
    [DataMember()]
    public double? Montant { get; set; }

    [System.ComponentModel.Description("Refus envoyé?=EmailDeRefusEnvoye")]
    [DataMember()]
    public bool? EmailDeRefusEnvoye { get; set; }

    [System.ComponentModel.Description("Confirmation inscr. envoyé=EmailConfirmationInscriptionEnvoye")]
    [DataMember()]
    public bool EmailConfirmationInscriptionEnvoye { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$CommunicationFilmData")]
    public CommunicationFilmData CommunicationFilmData { get; set; }

    [System.ComponentModel.Description("$$IdModeTransmission")]
    [DataMember()]
    public int? IdModeTransmission { get; set; }

    [System.ComponentModel.Description("$$IdSupportTransmission")]
    [DataMember()]
    public int? IdSupportTransmission { get; set; }

    [System.ComponentModel.Description("Support Transmission")]
    [DataMember()]
    public SupportTransmissionFilmData SupportTransmission { get; set; }

    [System.ComponentModel.Description("$$IdSousSectionSelection")]
    [DataMember()]
    public int? IdSousSectionSelection { get; set; }

    [System.ComponentModel.Description("Publié?=EtatPublication")]
    [DataMember()]
    public bool? EtatPublication { get; set; } = false;

    // <System.ComponentModel.Description("$$Confidentialites")>
    // <DataMember()>
    // Property Confidentialites As Integer?

    [System.ComponentModel.Description("A ne pas communiquer?=IsFilmVuANePasCommuniquer")]
    [DataMember()]
    public bool IsFilmVuANePasCommuniquer { get; set; }

    [System.ComponentModel.Description("En attente décision?=IsFilmEnAttenteDeDecision")]
    [DataMember()]
    public bool? IsFilmEnAttenteDeDecision { get; set; }

    [System.ComponentModel.Description("A refuser?=IsFilmARefuser")]
    [DataMember()]
    public bool? IsFilmARefuser { get; set; }

    [System.ComponentModel.Description("A ne pas refuser?=IsFilmANePasRefuser")]
    [DataMember()]
    public bool? IsFilmANePasRefuser { get; set; }

    [System.ComponentModel.Description("Reco. Sfc?=IsFilmARefuserSfc")]
    [DataMember()]
    public bool? IsRecoSfc { get; set; }

    [System.ComponentModel.Description("A accepter?=IsFilmAAccepter")]
    [DataMember()]
    public bool? IsFilmAAccepter { get; set; }

    [System.ComponentModel.Description("Lien=LienDeTelechargement")]
    [DataMember()]
    public string LienDeTelechargement { get; set; }

    [System.ComponentModel.Description("Login=LoginDeTelechargement")]
    [DataMember()]
    public string LoginDeTelechargement { get; set; }

    [System.ComponentModel.Description("Password=PasswordDeTelechargement")]
    [DataMember()]
    public string PasswordDeTelechargement { get; set; }

    [System.ComponentModel.Description("Commentaires téléchargement=CommentairesDeTelechargement")]
    [DataMember()]
    public string CommentairesDeTelechargement { get; set; }

    [System.ComponentModel.Description("Commentaires Inscription=Commentaires")]
    [DataMember()]
    public string Commentaires { get; set; }

    [System.ComponentModel.Description("$$LoginPersonneQuiSelectionne")]
    [DataMember()]
    public string LoginPersonneQuiSelectionne { get; set; }

    [System.ComponentModel.Description("Sélectionné par=NomPersonneQuiSelectionne")]
    [DataMember()]
    public string NomPersonneQuiSelectionne { get; set; }

    [System.ComponentModel.Description("Notes internes=NotesInterne")]
    [DataMember()]
    public string NotesInterne { get; set; }

    [System.ComponentModel.Description("Remarques Internes=RemarquesInternes")]
    [DataMember()]
    public string RemarquesInternes { get; set; }

    [System.ComponentModel.Description("Commentaire sélectionneurs=CommentaireSelectionneurs")]
    [DataMember()]
    public string CommentaireSelectionneurs { get; set; }

    [System.ComponentModel.Description("Utilisateur En Charge=UtilisateurEnCharge")]
    [DataMember()]
    public string UtilisateurEnCharge { get; set; }

    [System.ComponentModel.Description("Film=dFilms")]
    [DataMember()]
    public FilmData Film { get; set; }

    [System.ComponentModel.Description("$$LienStt")]
    [DataMember()]
    public string LienStt { get; set; }

    [System.ComponentModel.Description("Liste sections=ListeSections")]
    [DataMember()]
    public string ListeSections { get; set; }

    [System.ComponentModel.Description("A Synchro VL?=ASynchro")]
    [DataMember()]
    public bool ASynchro { get; set; }

    [System.ComponentModel.Description("Synchro Erreur VL?=SynchroErreur")]
    [DataMember()]
    public bool SynchroErreur { get; set; }

    [System.ComponentModel.Description("$$IdFilm")]
    [DataMember()]
    public int IdFilm { get; set; }

    [System.ComponentModel.Description("$$IdCopieProjection")]
    [DataMember()]
    public int? IdCopieProjection { get; set; }

    [System.ComponentModel.Description("$$IdOperation")]
    [DataMember()]
    public int? IdOperation { get; set; }

    [System.ComponentModel.Description("$$EtatTraduction")]
    [DataMember()]
    public int? EtatTraduction { get; set; }

    [System.ComponentModel.Description("Traduction")]
    [DataMember()]
    public string Traduction
    {
      get
      {
        if (EtatTraduction == 0)
          return "A traduire";
        else if (EtatTraduction == 1)
          return "Traduit";
        else
          return "Ne pas traduire";
      }
      set
      {
        if (value == "A traduire")
          EtatTraduction = 0;
        else if (value == "Traduit")
          EtatTraduction = 1;
        else
          EtatTraduction = 2;
      }
    }

    [System.ComponentModel.Description("$$TelechargementsObligatoiresDone")]
    [DataMember()]
    public bool? TelechargementsObligatoiresDone { get; set; }

    // <System.ComponentModel.Description("$$Sélection")>
    // <DataMember()>
    // Property Selection As InscriptionFilmData

    [System.ComponentModel.Description("$$CopieProjection")]
    [DataMember()]
    public CopieProjectionData CopieProjection { get; set; }

    [System.ComponentModel.Description("$$FormulairesSelection")]
    [DataMember()]
    public List<FormulaireSelectionData> FormulairesSelection { get; set; } = new List<FormulaireSelectionData>();

    //  public bool IsDossierFinalise
    //  {
    //    get
    //    {
    //      InscriptionFilmData InscriptionFilm = this;

    //      bool _return = false;
    //      int count = 0;

    //      // If SecondScreenSubtitles() AndAlso Film.DossierInscription.FormulairesSelection?.Count <> 5 Then
    //      // Return False
    //      // Else
    //      // count = 5
    //      // End If
    //      // If Not SecondScreenSubtitles() AndAlso Film.DossierInscription.FormulairesSelection?.Count <> 4 Then
    //      // Return False
    //      // Else
    //      // count = 4
    //      // End If

    //      if (InscriptionFilm.IdSectionSelection != null)
    //      {
    //        if (InscriptionFilm.IdSectionSelection == FilmData.eSectionSelection.ShortFilmCorner)
    //          count = 4;
    //        else
    //          count = 8;
    //      }

    //      int noOfLockedForms = InscriptionFilm.FormulairesSelection.Where(f => !Information.IsNothing(f.DateValidation)).Count();
    //      if (noOfLockedForms == count && count > 0 && InscriptionFilm.TelechargementsObligatoiresDone == true)
    //        _return = true;

    //      return _return;
    //    }
    //    set
    //    {
    //    }
    //  }
    //}


    [DataContract]
    public class AwsLogData
    {
      [System.ComponentModel.Description("$$Identifiant")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("$$IdFilm")]
      [DataMember()]
      public int? IdFilm { get; set; }
      [System.ComponentModel.Description("Date de création=DateCreation")]
      [DataMember()]
      public DateTime? DateCreation { get; set; }

      [System.ComponentModel.Description("TypeMessage=TypeMessage")]
      [DataMember()]
      public string TypeMessage { get; set; }

      [System.ComponentModel.Description("$$Message")]
      [DataMember()]
      public string Message { get; set; }

      [System.ComponentModel.Description("$$IdUtilisateur")]
      [DataMember()]
      public int? IdUtilisateur { get; set; }
    }

    [DataContract]
    public class SectionInscriptionData
    {
      [System.ComponentModel.Description("$$IdSectionInscription")]
      [DataMember()]
      public int? IdSectionInscription { get; set; }

      [System.ComponentModel.Description("Section inscription=SectionInscription")]
      [DataMember()]
      public string SectionInscription { get; set; }

      [System.ComponentModel.Description("$$Section inscription FR")]
      [DataMember()]
      public string SectionInscriptionFR { get; set; }

      [System.ComponentModel.Description("$$Section inscription EN")]
      [DataMember()]
      public string SectionInscriptionEN { get; set; }

      [System.ComponentModel.Description("$$Couleur")]
      [DataMember()]
      public string Couleur { get; set; }

      [System.ComponentModel.Description("Code=Code")]
      [DataMember()]
      public string Code { get; set; }

      // <System.ComponentModel.Description("$$TypeSectionInscription")>
      // <DataMember()>
      // Property TypeSectionInscription As Integer?


      [System.ComponentModel.Description("$$ConditionsInscription")]
      [DataMember()]
      public string ConditionsInscription { get; set; }

      [System.ComponentModel.Description("$$Reglement")]
      [DataMember()]
      public string Reglement { get; set; }

      [System.ComponentModel.Description("$$AdresseEnvoiSupport")]
      [DataMember()]
      public string AdresseEnvoiSupport { get; set; }


      [System.ComponentModel.Description("Groupes autorisé=Groupes")]
      [DataMember()]
      public string Groupes { get; set; } = "";

      [System.ComponentModel.Description("Groupe par défaut=GroupesDefaut")]
      [DataMember()]
      public string GroupesDefaut { get; set; } = "";

      [System.ComponentModel.Description("Groupe de gestion=GroupesGestion")]
      [DataMember()]
      public string GroupesGestion { get; set; } = "";

      [System.ComponentModel.Description("Signature Email=SignatureMail")]
      [DataMember()]
      public string SignatureMail { get; set; } = "";

      [System.ComponentModel.Description("$$MessageCloture")]
      [DataMember()]
      public string MessageCloture { get; set; }

      [System.ComponentModel.Description("$$MessageClotureUs")]
      [DataMember()]
      public string MessageClotureUs { get; set; }


      [System.ComponentModel.Description("$$IdCampagneReupload")]
      [DataMember()]
      public int? IdCampagneReupload { get; set; }

      [System.ComponentModel.Description("$$IdCampagneContactPrincipal")]
      [DataMember()]
      public int? IdCampagneContactPrincipal { get; set; }

      [System.ComponentModel.Description("$$IdCampagneReception")]
      [DataMember()]
      public int? IdCampagneReception { get; set; }

      [System.ComponentModel.Description("$$IdCampagneRefus")]
      [DataMember()]
      public int? IdCampagneRefus { get; set; }

      [System.ComponentModel.Description("$$IdCampagneRefusRecoSfc")]
      [DataMember()]
      public int? IdCampagneRefusRecoSfc { get; set; }

      [System.ComponentModel.Description("$$IdCampagnePaiement")]
      [DataMember()]
      public int? IdCampagnePaiement { get; set; }

      [System.ComponentModel.Description("$$IdCampagneSelection")]
      [DataMember()]
      public int? IdCampagneSelection { get; set; }

      [System.ComponentModel.Description("$$IdCampagneSelectionneur")]
      [DataMember()]
      public int? IdCampagneSelectionneur { get; set; }

      [System.ComponentModel.Description("$$IdCampagneRemboursementOk")]
      [DataMember()]
      public int? IdCampagneRemboursementOk { get; set; }

      [System.ComponentModel.Description("$$IdCampagneRemboursementEchec")]
      [DataMember()]
      public int? IdCampagneRemboursementEchec { get; set; }
    }


    [DataContract]
    public class MillesimeSectionInscriptionData
    {
      [System.ComponentModel.Description("$$IdMillesimeSectionInscription")]
      [DataMember()]
      public int? IdMillesimeSectionInscription { get; set; }

      [System.ComponentModel.Description("$$IdSectionInscription")]
      [DataMember()]
      public int? IdSectionInscription { get; set; }

      [System.ComponentModel.Description("Section Inscription=dSectionInscriptions")]
      [DataMember()]
      public SectionInscriptionData SectionInscriptionDonnee { get; set; }

      [System.ComponentModel.Description("$$SectionInscription_NOSAVE")]
      [DataMember()]
      public string SectionInscription_NOSAVE { get; set; }

      [System.ComponentModel.Description("$$IdFestival")]
      [DataMember()]
      public int? IdFestival { get; set; }

      [System.ComponentModel.Description("Année=Annee")]
      [DataMember()]
      public string Annee { get; set; }

      [System.ComponentModel.Description("Date Ouverture Inscriptions=DateOuvertureInscriptions")]
      [DataMember()]
      public DateTime? DateOuvertureInscriptions { get; set; }

      [System.ComponentModel.Description("Date Fermeture Inscriptions=DateFermetureInscriptions")]
      [DataMember()]
      public DateTime? DateFermetureInscriptions { get; set; }


      [System.ComponentModel.Description("Date Fin Completion Dossier=DateFinCompletionDossier")]
      [DataMember()]
      public DateTime? DateFinCompletionDossier { get; set; }


      [System.ComponentModel.Description("Date Fin Telechargement complémentaire=DateFinTelechargement")]
      [DataMember()]
      public DateTime? DateFinTelechargement { get; set; }


      [System.ComponentModel.Description("Date Limite réception support=DateLimiteReceptionSupport")]
      [DataMember()]
      public DateTime? DateLimiteReceptionSupport { get; set; } // à ne pas confondre avec la date des telechargements complementaires (pour le dossier du selectionné), si le mode d'envoi est Téléchargement


      [System.ComponentModel.Description("Prix Fixe=PrixFixe")]
      [DataMember()]
      public double? PrixFixe { get; set; }


      [System.ComponentModel.Description("Prix Fixe à paritir de la 2 ème inscription=PrixFixeSupp")]
      [DataMember()]
      public double? PrixFixeSupp { get; set; }

      [System.ComponentModel.Description("Prix Minute première inscription=PrixMinute")]
      [DataMember()]
      public double? PrixMinute { get; set; }

      [System.ComponentModel.Description("Prix Minute à paritir de la 2 ème inscription=PrixMinuteSupp")]
      [DataMember()]
      public double? PrixMinuteSupp { get; set; }


      [System.ComponentModel.Description("Email notif. avis sélectionneur=EmailNotifAvisSelectionneur")]
      [DataMember()]
      public string EmailNotifAvisSelectionneur { get; set; }

      [System.ComponentModel.Description("Date création=DateCreation")]
      [DataMember()]
      public DateTime? DateCreation { get; set; }

      [System.ComponentModel.Description("Date modification=DateModification")]
      [DataMember()]
      public DateTime? DateModification { get; set; }

      [System.ComponentModel.Description("Active?=EstActive")]
      [DataMember()]
      public bool EstActive { get; set; }

      [System.ComponentModel.Description("Visible?=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [System.ComponentModel.Description("Millesime mode transmissions=MillesimeModeTransmissions")]
      [DataMember()]
      public List<MillesimeModeTransmissionFilmData> MillesimeModeTransmissions { get; set; }


      [System.ComponentModel.Description("Liste des mails destinataires")]
      [DataMember()]
      public string ListeDiffusion { get; set; }

      [System.ComponentModel.Description("Email Support=EmailContactSupport")]
      [DataMember()]
      public string EmailContactSupport { get; set; } // utilisé provisoirement la colonne AdresseEnvoi


      [System.ComponentModel.Description("$$$Url tardif")]
      [DataMember()]
      public string UrlTardif
      {
        get
        {
          if (IdSectionInscription != null)
          {
            if (SectionInscriptionDonnee != null && (SectionInscriptionDonnee.Code == "CF" || SectionInscriptionDonnee.Code == "LCF"))
              return "https://moncompte.festival-cannes.fr?tunnel=LCF&DelayedSectionId=" + IdMillesimeSectionInscription.ToString();
            else
              return "https://moncompte.festival-cannes.fr?tunnel=F&DelayedSectionId=" + IdMillesimeSectionInscription.ToString();
          }
          else
            return "";
        }
        set
        {
        }
      }
    }


    [DataContract()]
    public class MillesimeModeTransmissionFilmData
    {
      [System.ComponentModel.Description("$$Id")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("Mode transmission=dModeTransmissions")]
      [DataMember()]
      public ModeTransmissionFilmData ModeTransmission { get; set; }

      [System.ComponentModel.Description("$$IdMillesimeSectionInscription")]
      [DataMember()]
      public int? IdMillesimeSectionInscription { get; set; }

      [System.ComponentModel.Description("Frais=Frais")]
      [DataMember()]
      public double? Frais { get; set; }

      [System.ComponentModel.Description("$$LibelleFr")]
      [DataMember()]
      public string LibelleAvecFraisFr { get; set; }

      [System.ComponentModel.Description("$$LibelleUs")]
      [DataMember()]
      public string LibelleAvecFraisUs { get; set; }

      [System.ComponentModel.Description("Actif")]
      [DataMember()]
      public bool Actif { get; set; }
    }


    [DataContract]
    public class FormulaireSelectionData
    {
      [System.ComponentModel.Description("$$Identifiant")]
      [DataMember()]
      public int? Id { get; set; }

      [DataMember()]
      [System.ComponentModel.Description("$$IdInscriptionFilm")]
      public int IdInscriptionFilm { get; set; }

      //[System.ComponentModel.Description("Libellé")]
      //[DataMember()]
      //public string LibelleFormulaire
      //{
      //  get
      //  {
      //    switch (IndexFormulaire)
      //    {
      //      case eIndexFormulaireSelection.ValidationDonnees:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.ValidationDonnees);
      //        }

      //      case eIndexFormulaireSelection.Attestation:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.Attestation);
      //        }

      //      case eIndexFormulaireSelection.Societes:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.Societes);
      //        }

      //      case eIndexFormulaireSelection.Realisateurs:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.Realisateurs);
      //        }

      //      case eIndexFormulaireSelection.Hebergement:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.Hebergement);
      //        }

      //      case eIndexFormulaireSelection.ProjectionEtCopie:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.ProjectionEtCopie);
      //        }

      //      case eIndexFormulaireSelection.EnvoiPrior:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.EnvoiPrior);
      //        }

      //      case eIndexFormulaireSelection.EnvoiComplementaire:
      //        {
      //          return Utils.Util.GetEnumDescription(eIndexFormulaireSelection.EnvoiComplementaire);
      //        }

      //      default:
      //        {
      //          return "Unknow";
      //        }
      //    }
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("$$UrlFormulaire")]
      //[DataMember()]
      //public string UrlFormulaire
      //{
      //  get
      //  {
      //    switch (IndexFormulaire)
      //    {
      //      case eIndexFormulaireSelection.Attestation:
      //        {
      //          return "/festival/Film/SuiviFilmAttestation.aspx";
      //        }

      //      case eIndexFormulaireSelection.Realisateurs:
      //        {
      //          return "/festival/Film/SuiviFilmRealisateurs.aspx";
      //        }

      //      case eIndexFormulaireSelection.Societes:
      //        {
      //          return "/festival/Film/SuiviFilmSocietes.aspx";
      //        }

      //      case eIndexFormulaireSelection.ProjectionEtCopie:
      //        {
      //          return "/festival/Film/SuiviFilmCopieProjection.aspx";
      //        }

      //      case eIndexFormulaireSelection.ValidationDonnees:
      //        {
      //          return "/festival/Film/SuiviFilmValidationDonnees.aspx";
      //        }

      //      case eIndexFormulaireSelection.Hebergement:
      //        {
      //          return "/festival/Film/SuiviFilmHebergement.aspx";
      //        }

      //      case eIndexFormulaireSelection.EnvoiPrior:
      //        {
      //          return "/festival/Film/SuiviFilmEnvoiPrior.aspx";
      //        }

      //      case eIndexFormulaireSelection.EnvoiComplementaire:
      //        {
      //          return "/festival/Film/SuiviFilmEnvoiComplementaire.aspx";
      //        }

      //      default:
      //        {
      //          return "Unknow";
      //        }
      //    }
      //  }
      //  set
      //  {
      //  }
      //}

      [System.ComponentModel.Description("Date Modification")]
      [DataMember()]
      public DateTime? DateModification { get; set; }

      [System.ComponentModel.Description("Date complétion")]
      [DataMember()]
      public DateTime? DateValidation { get; set; }

      [System.ComponentModel.Description("$$IndexFormulaire")]
      [DataMember()]
      public int IndexFormulaire { get; set; }

      [System.ComponentModel.Description("$$EstVerouillé")]
      [DataMember()]
      public bool EstVerouille { get; set; }

      //  [System.ComponentModel.Description("$$Ordre")]
      //  [DataMember()]
      //  public int Ordre
      //  {
      //    get
      //    {
      //      switch (IndexFormulaire)
      //      {
      //        case eIndexFormulaireSelection.Attestation:
      //          {
      //            return 2;
      //          }

      //        case eIndexFormulaireSelection.Realisateurs:
      //          {
      //            return 4;
      //          }

      //        case eIndexFormulaireSelection.Societes:
      //          {
      //            return 3;
      //          }

      //        case eIndexFormulaireSelection.ProjectionEtCopie:
      //          {
      //            return 8;
      //          }

      //        case eIndexFormulaireSelection.ValidationDonnees:
      //          {
      //            return 1;
      //          }

      //        case eIndexFormulaireSelection.Hebergement:
      //          {
      //            return 5;
      //          }

      //        case eIndexFormulaireSelection.EnvoiPrior:
      //          {
      //            return 6;
      //          }

      //        case eIndexFormulaireSelection.EnvoiComplementaire:
      //          {
      //            return 7;
      //          }

      //        default:
      //          {
      //            return 10;
      //          }
      //      }
      //    }
      //    set
      //    {
      //    }
      //  }
      //}


      public enum eIndexFormulaireSelection
      {
        [System.ComponentModel.Description("Vérification des informations")]
        ValidationDonnees = 0,
        [System.ComponentModel.Description("Attestations/Autorisations")]
        Attestation = 1,
        [System.ComponentModel.Description("Sociétés")]
        Societes = 2,
        [System.ComponentModel.Description("Réalisateur(s)")]
        Realisateurs = 3,
        [System.ComponentModel.Description("Hébergement")]
        Hebergement = 4,
        [System.ComponentModel.Description("Projections et copies")]
        ProjectionEtCopie = 5,
        [System.ComponentModel.Description("Envois prioritaires")]
        EnvoiPrior = 6,
        [System.ComponentModel.Description("Envois complementaires")]
        EnvoiComplementaire = 7,
        [System.ComponentModel.Description("Infos Détaillees")]
        InfosDetaillees = 11,
        [System.ComponentModel.Description("Autre")]
        Autre = 100
      }



      public class CopieProjectionData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? Id { get; set; }

        [System.ComponentModel.Description("IdFormatFps")]
        [DataMember()]
        public int? IdFormatFps { get; set; }

        [System.ComponentModel.Description("IdFormatVideo")]
        [DataMember()]
        public int? IdFormatVideo { get; set; }

        [System.ComponentModel.Description("AutreFormat")]
        [DataMember()]
        public string AutreFormat { get; set; }

        [System.ComponentModel.Description("IdFormatSon")]
        [DataMember()]
        public int? IdFormatSon { get; set; }

        [System.ComponentModel.Description("AutreFormatSonNum")]
        [DataMember()]
        public string AutreFormatSonNum { get; set; }

        [System.ComponentModel.Description("NombreDeBobines")]
        [DataMember()]
        public int? NombreDeBobines { get; set; }

        [System.ComponentModel.Description("Metrage")]
        [DataMember()]
        public string Metrage { get; set; }

        [System.ComponentModel.Description("ValeurDuFilm")]
        [DataMember()]
        public double? ValeurDuFilm { get; set; }

        [System.ComponentModel.Description("Transporteur")]
        [DataMember()]
        public string Transporteur { get; set; }

        [System.ComponentModel.Description("AdresseExpeditionApresFestival")]
        [DataMember()]
        public string AdresseExpeditionApresFestival { get; set; }

        [System.ComponentModel.Description("IdSousTitresElectronique")]
        [DataMember()]
        public int? IdSousTitresElectronique { get; set; }

        [System.ComponentModel.Description("DateEnvoiSousTitreDUNE")]
        [DataMember()]
        public DateTime? DateEnvoiSousTitreDUNE { get; set; }

        [System.ComponentModel.Description("DateEnvoiVideoDUNE")]
        [DataMember()]
        public DateTime? DateEnvoiVideoDUNE { get; set; }

        [System.ComponentModel.Description("SousTitresElectronique")]
        [DataMember()]
        public SousTitresElectroniqueData SousTitresElectronique { get; set; }

        [System.ComponentModel.Description("DateDepart")]
        [DataMember()]
        public DateTime? DateDepart { get; set; }

        [System.ComponentModel.Description("TransitaireArrivee")]
        [DataMember()]
        public string TransitaireArrivee { get; set; }

        [System.ComponentModel.Description("TransitaireDepart")]
        [DataMember()]
        public string TransitaireDepart { get; set; }

        [System.ComponentModel.Description("DateArriveeCopiePresentation")]
        [DataMember()]
        public DateTime? DateArriveeCopiePresentation { get; set; }

        [System.ComponentModel.Description("DateArriveeCopieSecours")]
        [DataMember()]
        public DateTime? DateArriveeCopieSecours { get; set; }

        [System.ComponentModel.Description("DateArriveeFichierSousTitrageElectronique")]
        [DataMember()]
        public DateTime? DateArriveeFichierSousTitrageElectronique { get; set; }

        [System.ComponentModel.Description("IdFormatPellicule")]
        [DataMember()]
        public int? IdFormatPellicule { get; set; }

        [System.ComponentModel.Description("PelliculeTriacétate")]
        [DataMember()]
        public bool PelliculeTriacétate { get; set; }

        [System.ComponentModel.Description("TypeFormatCopie")]
        [DataMember()]
        public int? TypeFormatCopie { get; set; }

        [System.ComponentModel.Description("Est35mm")]
        [DataMember()]
        public bool Est35mm { get; set; }

        [System.ComponentModel.Description("EstDcp")]
        [DataMember()]
        public bool EstDcp { get; set; }

        [System.ComponentModel.Description("DcpCrypte")]
        [DataMember()]
        public bool DcpCrypte { get; set; }

        [System.ComponentModel.Description("Dématerialisé?=Dematerialise")]
        [DataMember()]
        public bool Dematerialise { get; set; }

        [System.ComponentModel.Description("NomCpl")]
        [DataMember()]
        public string NomCpl { get; set; }

        [System.ComponentModel.Description("IdFormatDcp")]
        [DataMember()]
        public int? IdFormatDcp { get; set; }

        [System.ComponentModel.Description("IdFormatDcpFps")]
        [DataMember()]
        public int? IdFormatDcpFps { get; set; }

        [System.ComponentModel.Description("IdFormatSonDcp")]
        [DataMember()]
        public int? IdFormatSonDcp { get; set; }

        [System.ComponentModel.Description("DureeTicks")]
        [DataMember()]
        public Int64 DureeTicks { get; set; }

        [System.ComponentModel.Description("DureeMinute")]
        [DataMember()]
        public Int64 DureeMinute
        {
          get
          {
            TimeSpan Span = new TimeSpan(DureeTicks);
            return Span.Days * 60 * 24 + Span.Hours * 60 + Span.Minutes;
          }
          set
          {
            TimeSpan Span = new TimeSpan(0, 0, System.Convert.ToInt32(value), System.Convert.ToInt32(DureeSeconde), 0);
            DureeTicks = Span.Ticks;
          }
        }

        [System.ComponentModel.Description("DureeSeconde")]
        [DataMember()]
        public Int64 DureeSeconde
        {
          get
          {
            TimeSpan Span = new TimeSpan(DureeTicks);
            return Span.Seconds;
          }
          set
          {
            TimeSpan Span = new TimeSpan(0, 0, System.Convert.ToInt32(DureeMinute), System.Convert.ToInt32(value), 0);
            DureeTicks = Span.Ticks;
          }
        }


        // <System.ComponentModel.Description("ResponsableCopie")>
        // <DataMember()>
        // Property ResponsableCopie As String

        [System.ComponentModel.Description("NomResponsable")]
        [DataMember()]
        public string NomResponsable { get; set; }

        [System.ComponentModel.Description("PrenomResponsable")]
        [DataMember()]
        public string PrenomResponsable { get; set; }

        [System.ComponentModel.Description("FullName")]
        public string FullName
        {
          get
          {
            return (PrenomResponsable + " " + NomResponsable).Trim();
          }
          set
          {
          }
        }

        [System.ComponentModel.Description("EntrepriseResponsable")]
        [DataMember()]
        public string EntrepriseResponsable { get; set; }

        [System.ComponentModel.Description("EmailResponsable")]
        [DataMember()]
        public string EmailResponsable { get; set; }

        [System.ComponentModel.Description("PortableResponsable")]
        [DataMember()]
        public string PortableResponsable { get; set; }

        [System.ComponentModel.Description("IsResponsablePendantFestivalMemePersonne")]
        [DataMember()]
        public bool? IsResponsablePendantFestivalMemePersonne { get; set; }

        [System.ComponentModel.Description("NomResponsablePendantFestival")]
        [DataMember()]
        public string NomResponsablePendantFestival { get; set; }

        [System.ComponentModel.Description("PrenomResponsablePendantFestival")]
        [DataMember()]
        public string PrenomResponsablePendantFestival { get; set; }

        [System.ComponentModel.Description("EmailResponsablePendantFestival")]
        [DataMember()]
        public string EmailResponsablePendantFestival { get; set; }

        [System.ComponentModel.Description("PortableResponsablePendantFestival")]
        [DataMember()]
        public string PortableResponsablePendantFestival { get; set; }

        [System.ComponentModel.Description("ResponsableSeraPresentCannes")]
        [DataMember()]
        public bool ResponsableSeraPresentCannes { get; set; }

        [System.ComponentModel.Description("AdresseExpeditionApresFestival")]
        [DataMember()]
        public string Laboratoire { get; set; }
        [System.ComponentModel.Description("LaboratoireContactNom")]
        [DataMember()]
        public string LaboratoireContactNom { get; set; }

        [System.ComponentModel.Description("LaboratoireContactTelephone")]
        [DataMember()]
        public string LaboratoireContactTelephone { get; set; }

        [System.ComponentModel.Description("LaboratoireContactEmail")]
        [DataMember()]
        public string LaboratoireContactEmail { get; set; }

        [System.ComponentModel.Description("LaboratoireContactPortable")]
        [DataMember()]
        public string LaboratoireContactPortable { get; set; }

        // <System.ComponentModel.Description("AutorisationProjectionCannesCinephiles")>
        // <DataMember()>
        // Property AutorisationProjectionCannesCinephiles As Boolean

        // <System.ComponentModel.Description("AuthorisationCreationDvdCourtMetrage")>
        // <DataMember()>
        // Property AuthorisationCreationDvdCourtMetrage As Boolean

        [System.ComponentModel.Description("AutorisationSfcLogotype")]
        [DataMember()]
        public bool AutorisationSfcLogotype { get; set; }

        [System.ComponentModel.Description("AutorisationProjectionLicorne")]
        [DataMember()]
        public bool AutorisationProjectionLicorne { get; set; }

        [System.ComponentModel.Description("AutorisationDVDCourtsMetrages_RepriseParis")]
        [DataMember()]
        public bool AutorisationDVDCourtsMetrages_RepriseParis { get; set; }

        [System.ComponentModel.Description("AutorisationPalmedOr_GrandPrix")]
        [DataMember()]
        public bool AutorisationPalmedOr_GrandPrix { get; set; }

        [System.ComponentModel.Description("AttestationCameradOr")]
        [DataMember()]
        public bool AttestationCameradOr { get; set; }

        [System.ComponentModel.Description("AutorisationRepriseRefletsMedicis")]
        [DataMember()]
        public bool AutorisationRepriseRefletsMedicis { get; set; }


        // 4 nouvelles autorisations depuis le changement du designe dossier du sélectionné
        [System.ComponentModel.Description("AttestationGestionDroits")]
        [DataMember()]
        public bool AttestationGestionDroits { get; set; }


        [System.ComponentModel.Description("AutorisationReprise")]
        [DataMember()]
        public bool AutorisationReprise { get; set; }

        [System.ComponentModel.Description("AutorisationDiffusionSite")]
        [DataMember()]
        public bool AutorisationDiffusionSite { get; set; }


        [System.ComponentModel.Description("AutorisationDiffusionSFC")]
        [DataMember()]
        public bool AutorisationDiffusionSFC { get; set; }



        // Obsolète pour CF. Il faut maintenant utliser les memes que pour les autres sections

        [System.ComponentModel.Description("Cinef_Authorisation_DiffusionSiteFestival")]
        [DataMember()]
        public bool Cinef_Authorisation_DiffusionSiteFestival { get; set; }

        [System.ComponentModel.Description("Cinef_Authorisation_DiffusionBandesAnnoncesMedia")]
        [DataMember()]
        public bool Cinef_Authorisation_DiffusionBandesAnnoncesMedia { get; set; }

        [System.ComponentModel.Description("Cinef_Authorisation_DiffusionAuShortFilmCorner")]
        [DataMember()]
        public bool Cinef_Authorisation_DiffusionAuShortFilmCorner { get; set; }

        [System.ComponentModel.Description("Cinef_Authorisation_DvdCompilationCm")]
        [DataMember()]
        public bool Cinef_Authorisation_DvdCompilationCm { get; set; }

        [System.ComponentModel.Description("Cinef_Authorisation_RepriseParis")]
        [DataMember()]
        public bool Cinef_Authorisation_RepriseParis { get; set; }
      }

      [Serializable]
      [DataContract()]
      public class SousTitresElectroniqueData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? Id { get; set; }

        [System.ComponentModel.Description("LaboPreparationNom=LaboPreparationNom")]
        [DataMember()]
        public string LaboPreparationNom { get; set; }

        [System.ComponentModel.Description("LaboPreparationEmail=LaboPreparationEmail")]
        [DataMember()]
        public string LaboPreparationEmail { get; set; }

        [System.ComponentModel.Description("LaboPreparationTelephone=LaboPreparationTelephone")]
        [DataMember()]
        public string LaboPreparationTelephone { get; set; }

        [System.ComponentModel.Description("LaboPreparationTelephonePortable=LaboPreparationTelephonePortable")]
        [DataMember()]
        public string LaboPreparationTelephonePortable { get; set; }

        [System.ComponentModel.Description("LaboPreparationContact=LaboPreparationContact")]
        [DataMember()]
        public string LaboPreparationContact { get; set; }

        [System.ComponentModel.Description("LaboSousTitrageNom=LaboSousTitrageNom")]
        [DataMember()]
        public string LaboSousTitrageNom { get; set; }

        [System.ComponentModel.Description("LaboSousTitrageEmail=LaboSousTitrageEmail")]
        [DataMember()]
        public string LaboSousTitrageEmail { get; set; }

        [System.ComponentModel.Description("LaboSousTitrageTelephone=LaboSousTitrageTelephone")]
        [DataMember()]
        public string LaboSousTitrageTelephone { get; set; }

        [System.ComponentModel.Description("LaboSousTitrageTelephonePortable=LaboSousTitrageTelephonePortable")]
        [DataMember()]
        public string LaboSousTitrageTelephonePortable { get; set; }

        [System.ComponentModel.Description("LaboSousTitrageContact=LaboSousTitrageContact")]
        [DataMember()]
        public string LaboSousTitrageContact { get; set; }

        [System.ComponentModel.Description("ChargePostProdNom=ChargePostProdNom")]
        [DataMember()]
        public string ChargePostProdNom { get; set; }

        [System.ComponentModel.Description("ChargePostProdEntreprise=ChargePostProdEntreprise")]
        [DataMember()]
        public string ChargePostProdEntreprise { get; set; }

        [System.ComponentModel.Description("ChargePostProdTelephone=ChargePostProdTelephone")]
        [DataMember()]
        public string ChargePostProdTelephone { get; set; }

        [System.ComponentModel.Description("ChargePostProdTelephonePortable=ChargePostProdTelephonePortable")]
        [DataMember()]
        public string ChargePostProdTelephonePortable { get; set; }

        [System.ComponentModel.Description("ChargePostProdEmail=ChargePostProdEmail")]
        [DataMember()]
        public string ChargePostProdEmail { get; set; }

        [System.ComponentModel.Description("Labo35mmSousTitrageNom=Labo35mmSousTitrageNom")]
        [DataMember()]
        public string Labo35mmSousTitrageNom { get; set; }

        [System.ComponentModel.Description("Labo35mmSousTitrageEmail=Labo35mmSousTitrageEmail")]
        [DataMember()]
        public string Labo35mmSousTitrageEmail { get; set; }

        [System.ComponentModel.Description("Labo35mmSousTitrageTelephone=Labo35mmSousTitrageTelephone")]
        [DataMember()]
        public string Labo35mmSousTitrageTelephone { get; set; }

        [System.ComponentModel.Description("Labo35mmSousTitrageTelephonePortable=Labo35mmSousTitrageTelephonePortable")]
        [DataMember()]
        public string Labo35mmSousTitrageTelephonePortable { get; set; }

        [System.ComponentModel.Description("Labo35mmSousTitrageContact=Labo35mmSousTitrageContact")]
        [DataMember()]
        public string Labo35mmSousTitrageContact { get; set; }

        [System.ComponentModel.Description("Labo35mmPreparationNom=Labo35mmPreparationNom")]
        [DataMember()]
        public string Labo35mmPreparationNom { get; set; }

        [System.ComponentModel.Description("Labo35mmPreparationEmail=Labo35mmPreparationEmail")]
        [DataMember()]
        public string Labo35mmPreparationEmail { get; set; }

        [System.ComponentModel.Description("Labo35mmPreparationTelephone=Labo35mmPreparationTelephone")]
        [DataMember()]
        public string Labo35mmPreparationTelephone { get; set; }

        [System.ComponentModel.Description("Labo35mmPreparationTelephonePortable=Labo35mmPreparationTelephonePortable")]
        [DataMember()]
        public string Labo35mmPreparationTelephonePortable { get; set; }

        [System.ComponentModel.Description("Labo35mmPreparationContact=Labo35mmPreparationContact")]
        [DataMember()]
        public string Labo35mmPreparationContact { get; set; }
      }

      [Serializable]
      [DataContract()]
      public class FormatFpsData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? IdFormatFps { get; set; }

        [System.ComponentModel.Description("FormatFps=FormatFps")]
        [DataMember()]
        public string FormatFps { get; set; }

        [System.ComponentModel.Description("EstArchive=EstArchive")]
        [DataMember()]
        public bool EstArchive { get; set; }

        [System.ComponentModel.Description("$$Actif")]
        [DataMember()]
        public bool Actif_NOSAVE
        {
          get
          {
            return !EstArchive;
          }
          set
          {
            EstArchive = !value;
          }
        }
      }

      [Serializable]
      [DataContract()]
      public class FormatPelliculeData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? IdFormatPellicule { get; set; }

        [System.ComponentModel.Description("FormatPellicule=FormatPellicule")]
        [DataMember()]
        public string FormatPellicule { get; set; }

        [System.ComponentModel.Description("FormatPelliculeUs")]
        [DataMember()]
        public string FormatPelliculeUs { get; set; }


        [System.ComponentModel.Description("FpsRequis=FpsRequis")]
        [DataMember()]
        public bool FpsRequis { get; set; }

        [System.ComponentModel.Description("EstArchive=EstArchive")]
        [DataMember()]
        public bool EstArchive { get; set; }

        [System.ComponentModel.Description("IdParent")]
        [DataMember()]
        public int? IdParent { get; set; }

        [System.ComponentModel.Description("$$Actif")]
        [DataMember()]
        public bool Actif_NOSAVE
        {
          get
          {
            return !EstArchive;
          }
          set
          {
            EstArchive = !value;
          }
        }
      }

      [Serializable]
      [DataContract()]
      public class FormatSonData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? IdFormatSon { get; set; }

        [System.ComponentModel.Description("Libelle=Libelle")]
        [DataMember()]
        public string Libelle { get; set; }
        [System.ComponentModel.Description("LibelleUs=LibelleUs")]
        [DataMember()]
        public string LibelleUs { get; set; }

        [System.ComponentModel.Description("EstAutre=EstAutre")]
        [DataMember()]
        public bool EstAutre { get; set; }

        [System.ComponentModel.Description("EstArchive=EstArchive")]
        [DataMember()]
        public bool EstArchive { get; set; }

        [System.ComponentModel.Description("$$Actif")]
        [DataMember()]
        public bool Actif_NOSAVE
        {
          get
          {
            return !EstArchive;
          }
          set
          {
            EstArchive = !value;
          }
        }

        [System.ComponentModel.Description("IdParent")]
        [DataMember()]
        public int? IdParent { get; set; }
      }

      [Serializable]
      [DataContract()]
      public class FormatVideoData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? IdFormatVideo { get; set; }

        [System.ComponentModel.Description("FormatVideo=FormatVideo")]
        [DataMember()]
        public string FormatVideo { get; set; }

        [System.ComponentModel.Description("FormatVideoUs=FormatVideoUs")]
        [DataMember()]
        public string FormatVideoUs { get; set; }

        [System.ComponentModel.Description("FpsRequis=FpsRequis")]
        [DataMember()]
        public bool FpsRequis { get; set; }

        [System.ComponentModel.Description("EstArchive=EstArchive")]
        [DataMember()]
        public bool EstArchive { get; set; }

        [System.ComponentModel.Description("$$Actif")]
        [DataMember()]
        public bool Actif_NOSAVE
        {
          get
          {
            return !EstArchive;
          }
          set
          {
            EstArchive = !value;
          }
        }
      }


      // <DataContract()>
      // Public Class SectionSelectionData
      // <System.ComponentModel.Description("$$IdSectionSelection")>
      // <DataMember()>
      // Property IdSectionSelection As Integer?

      // <System.ComponentModel.Description("Libelle")>
      // <DataMember()>
      // Property Libelle As String

      // <System.ComponentModel.Description("LibelleUs")>
      // <DataMember()>
      // Property LibelleUs As String



      // <System.ComponentModel.Description("NbrMaxAccreditation")>
      // <DataMember()>
      // Property NbrMaxAccreditation As Integer

      // <System.ComponentModel.Description("NbrMaxAccompagnants")>
      // <DataMember()>
      // Property NbrMaxAccompagnants As Integer

      // 'TODO   add the other column if needed
      // End Class

      [DataContract()]
      public class FilmographieData
      {
        [System.ComponentModel.Description("Identifiant")]
        [DataMember()]
        public int? Id { get; set; }

        [System.ComponentModel.Description("$$Ordre")]
        [DataMember()]
        public int Ordre { get; set; }

        [System.ComponentModel.Description("TitreOriginal=TitreOriginal")]
        [DataMember()]
        public string TitreOriginal { get; set; }

        [System.ComponentModel.Description("TitreAnglais=TitreAnglais")]
        [DataMember()]
        public string TitreAnglais { get; set; }

        [System.ComponentModel.Description("TitreFrancais=TitreFrancais")]
        [DataMember()]
        public string TitreFrancais { get; set; }

        [System.ComponentModel.Description("Duree=Duree")]
        [DataMember()]
        public int Duree { get; set; }

        [System.ComponentModel.Description("Annee=Annee")]
        [DataMember()]
        public int? Annee { get; set; }

        [System.ComponentModel.Description("DateProduction=DateProduction")]
        [DataMember()]
        public DateTime? DateProduction { get; set; }

        [System.ComponentModel.Description("Details=Details")]
        [DataMember()]
        public string Details { get; set; }

        [System.ComponentModel.Description("SortiesSalles=SortiesSalles")]
        [DataMember()]
        public int SortiesSalles { get; set; }

        [System.ComponentModel.Description("Distributeur=Distributeur")]
        [DataMember()]
        public string Distributeur { get; set; }

        [System.ComponentModel.Description("$$TypeFilm")]
        [DataMember()]
        public int? TypeFilm { get; set; }

        [System.ComponentModel.Description("Type=dTypesFilmsFilmographies")]
        [DataMember()]
        public TypeFilmFilmographieData TypeFilmFilmo { get; set; }

        [System.ComponentModel.Description("$$IdCategorie")]
        [DataMember()]
        public int? IdCategorie { get; set; }

        [System.ComponentModel.Description("Catégorie=dCategories")]
        [DataMember()]
        public CategorieFilmData Categorie { get; set; }

        [System.ComponentModel.Description("IdRealisateur")]
        [DataMember()]
        public int? IdRealisateur { get; set; }

        [System.ComponentModel.Description("$$TitreReport ")]
        [DataMember()]
        public string TitreReport
        {
          get
          {
            string _Ret = TitreOriginal;
            string _Tf = TitreFrancais;
            string _Ta = TitreAnglais;
            if (_Tf == TitreOriginal)
              _Tf = "";
            if (_Ta == TitreOriginal || _Ta == _Tf)
              _Ta = "";

            if (_Tf != "")
            {
              if (_Ta != "")
                _Ret += " (" + _Tf + " / " + _Ta + ")";
              else
                _Ret += " (" + _Tf + ")";
            }
            else if (_Ta != "")
              _Ret += " (" + _Ta + ")";
            return _Ret;
          }
          set
          {
          }
        }
      }

      [DataContract]
      public class StatutAvisSelectionneurFilmData
      {
        [System.ComponentModel.Description("$$Identifiant")]
        [DataMember()]
        public int? IdStatutAvisSelectionneur { get; set; }

        [System.ComponentModel.Description("Libellé=StatutAvisSelectionneur")]
        [DataMember()]
        public string StatutAvisSelectionneur { get; set; }

        [System.ComponentModel.Description("Libellé Us=StatutAvisSelectionneurUs")]
        [DataMember()]
        public string StatutAvisSelectionneurUs { get; set; }
      }


      [DataContract]
      public class StatutEcoleData
      {
        [NotMapped]
        public const string _suffixstatutecole = "Société.";
        [System.ComponentModel.Description("$$Identifiant")]
        [DataMember()]
        public int? IdStatutEcole { get; set; }

        [System.ComponentModel.Description("Visible=Visible")]
        [DataMember()]
        public bool Visible { get; set; }

        [System.ComponentModel.Description("$$Workflow")]
        [DataMember()]
        public bool Workflow { get; set; }

        [System.ComponentModel.Description("$$IdCampagne")]
        [DataMember()]
        public int? IdCampagne { get; set; }

        [System.ComponentModel.Description("Ordre=Ordre")]
        [DataMember()]
        public int? Ordre { get; set; }

        [System.ComponentModel.Description("Statuts suivants=StatutSuivant")]
        [DataMember()]
        public string StatutSuivant { get; set; }

        [System.ComponentModel.Description("Statut école=StatutEcole")]
        [DataMember()]
        public string StatutEcole { get; set; }
      }

      [DataContract]
      public class AvisSelectionneurFilmData
      {


        [System.ComponentModel.Description("$$Identifiant")]
        [DataMember()]
        public int? Id { get; set; }

        [System.ComponentModel.Description("$$IdInscriptionFilm")]
        [DataMember()]
        public int? IdInscriptionFilm { get; set; }

        [System.ComponentModel.Description("InscriptionFilm=dInscriptionFilms")]
        [DataMember()]
        public InscriptionFilmData InscriptionFilm { get; set; }

        [System.ComponentModel.Description("$$IdCompteSelectionneur")]
        [DataMember()]
        public int? IdCompteSelectionneur { get; set; }

        [System.ComponentModel.Description("Date d'affectation=DateCreation")]
        [DataMember()]
        public DateTime? DateCreation { get; set; }

        [System.ComponentModel.Description("Date de modification=DateModification")]
        [DataMember()]
        public DateTime? DateModification { get; set; }

        [System.ComponentModel.Description("$$CompteSelectionneur")]
        [DataMember()]
        public CompteData CompteSelectionneur { get; set; }

        [System.ComponentModel.Description("Nom Sélectionneur=Personnes_Nom")]
        [DataMember()]
        public string NomSelectionneur { get; set; }

        [System.ComponentModel.Description("Rôle Sélectionneur")]
        [DataMember()]
        public string RoleSelectionneur { get; set; }
        // Get
        // If CompteSelectionneur IsNot Nothing Then
        // Return CompteSelectionneur.Roles
        // End If
        // Return Nothing
        // End Get
        // End Property


        [System.ComponentModel.Description("Date validation=DateSaisie")]
        [DataMember()]
        public DateTime? DateSaisie { get; set; }

        [System.ComponentModel.Description("Date visionnage=DateVisionnage")]
        [DataMember()]
        public DateTime? DateVisionnage { get; set; }

        [System.ComponentModel.Description("Commentaire=Commentaire")]
        [DataMember()]
        public string Commentaire { get; set; }

        [System.ComponentModel.Description("Recommandation=Recommandation")]
        [DataMember()]
        public string Recommandation { get; set; }


        [System.ComponentModel.Description("Probleme Support=ProblemeSupport")]
        [DataMember()]
        public bool? ProblemeSupport { get; set; }

        [System.ComponentModel.Description("Commentaire Support=CommentaireSupport")]
        [DataMember()]
        public string CommentaireSupport { get; set; }

        [System.ComponentModel.Description("Favorable SFC?=IsFavorableSFC")]
        [DataMember()]
        public bool? IsFavorableSFC { get; set; }

        [System.ComponentModel.Description("Prioritaire?=Prioritaire")]
        [DataMember()]
        public bool? Prioritaire { get; set; }


        [System.ComponentModel.Description("$$IdStatutAvisSelectionneur")]
        [DataMember()]
        public int? IdStatutAvisSelectionneur { get; set; }

        [System.ComponentModel.Description("Statut Avis=dStatutsAvisSelectionneurs")]
        [DataMember()]
        public StatutAvisSelectionneurFilmData Statut { get; set; }

        [System.ComponentModel.Description("$$Date Envoi=DateEnvoi")]
        [DataMember()]
        public DateTime? DateEnvoi { get; set; }

        [System.ComponentModel.Description("Autres sélectionneurs")]
        [DataMember()]
        public string AutresSelectionneurs { get; set; }

        [System.ComponentModel.Description("Autre avis")]
        [DataMember()]
        public List<AvisSelectionneurFilmData> AutresAvis { get; set; }

        [System.ComponentModel.Description("AutresRecommandation")]
        [DataMember()]
        public string AutresRecommandations { get; set; }

        [DataMember()]
        [System.ComponentModel.Description("$$OldValue")]
        [IgnoreDataMember()]
        public AvisSelectionneurFilmData OldData { get; set; }
      }

      [DataContract]
      public class AvisSelectionneurFilmCountData
      {
        [DataMember()]
        public int IdSectionInscription { get; set; }

        [DataMember()]
        public int IdMillesimeSectionInscription { get; set; }

        [DataMember()]
        public string SectionFr { get; set; }

        [DataMember()]
        public string SectionUs { get; set; }

        [DataMember()]
        public string StatutFr { get; set; }

        [DataMember()]
        public string StatutUs { get; set; }

        [DataMember()]
        public int Nombre { get; set; }
      }

      [DataContract()]
      public class ReceptionSupportFilmData
      {
        [System.ComponentModel.Description("$$Identifiant")]
        [DataMember()]
        public int? Id { get; set; }

        [System.ComponentModel.Description("$$IdInscriptionFilm")]
        [DataMember()]
        public int? IdInscriptionFilm { get; set; }

        [System.ComponentModel.Description("$$IdUtilisateurReceptionneur")]
        [DataMember()]
        public int? IdUtilisateurReceptionneur { get; set; }

        [System.ComponentModel.Description("Login Réceptionneur=LoginReceptionneur")]
        [DataMember()]
        public string LoginReceptionneur { get; set; }

        [System.ComponentModel.Description("$$DateCreation")]
        [DataMember()]
        public DateTime? DateCreation { get; set; }

        [System.ComponentModel.Description("$$DateModification")]
        [DataMember()]
        public DateTime? DateModification { get; set; }

        [System.ComponentModel.Description("Est Support Principal=EstSupportPrincipal")]
        [DataMember()]
        public bool EstSupportPrincipal { get; set; }

        [System.ComponentModel.Description("Date de Réception=DateReception")]
        [DataMember()]
        public DateTime? DateReception { get; set; }

        [System.ComponentModel.Description("Lien=LienDeTelechargement")]
        [DataMember()]
        public string LienDeTelechargement { get; set; }

        [System.ComponentModel.Description("Login=LoginDeTelechargement")]
        [DataMember()]
        public string LoginDeTelechargement { get; set; }

        [System.ComponentModel.Description("Password=PasswordDeTelechargement")]
        [DataMember()]
        public string PasswordDeTelechargement { get; set; }

        [System.ComponentModel.Description("Commentaires visualisation=CommentairesDeTelechargement")]
        [DataMember()]
        public string CommentairesDeTelechargement { get; set; }

        [System.ComponentModel.Description("Mode transmission")]
        [DataMember()]
        public string ModeTransmission { get; set; }

        [System.ComponentModel.Description("$$IdModeTransmission")]
        [DataMember()]
        public int? IdModeTransmission { get; set; }


        [System.ComponentModel.Description("$$IdSupportTransmission")]
        [DataMember()]
        public int? IdSupportTransmission { get; set; }

        [System.ComponentModel.Description("Support transmission")]
        [DataMember()]
        public string SupportTransmission { get; set; }
      }

      [DataContract()]
      public class ContactFilmData
      {
        [System.ComponentModel.Description("$$PersonneFilm")]
        [DataMember()]
        public PersonneFilmData PersonneFilm { get; set; }

        [System.ComponentModel.Description("$$SocieteFilm")]
        [DataMember()]
        public SocieteFilmData SocieteFilm { get; set; }

        //[System.ComponentModel.Description("$$Id")]
        //[DataMember()]
        //public string Id
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      return "P" + PersonneFilm.Id.ToString;
        //    else if (!IsNothing(SocieteFilm))
        //      return "S" + SocieteFilm.Id.ToString;
        //    else
        //      return "U";
        //  }
        //  set
        //  {
        //  }
        //}

        //[System.ComponentModel.Description("Fonction")]
        //[DataMember()]
        //public string Fonction
        //{
        //  get
        //  {
        //    if (EstCreateur && (PersonneFilm.IdFonctionPersonne == null || PersonneFilm.IdFonctionPersonne == FilmData.eFonctionPersonneFilm.Autre) && PersonneFilm.IdFonction == null)
        //    {
        //      string _Fonc = "Créateur";
        //      if (PersonneFilm.Film.Fonction == "Autre")
        //        _Fonc += " (" + PersonneFilm.Film.FonctionAutre + ")";
        //      else
        //        _Fonc += " (" + PersonneFilm.Film.Fonction + ")";
        //      return _Fonc;
        //    }
        //    else if (PersonneFilm?.FonctionObject != null)
        //    {
        //      if (PersonneFilm.FonctionObject.Fonction == "Autre")
        //        return "Autre (" + PersonneFilm.FonctionAutre + ")";
        //      else
        //        return PersonneFilm.FonctionObject.Fonction;
        //    }
        //    else if (!IsNothing(PersonneFilm))
        //      return PersonneFilm.FonctionPersonne;
        //    else if (!IsNothing(SocieteFilm))
        //      return SocieteFilm.FonctionSociete;
        //    else
        //      return "";
        //  }
        //  set
        //  {
        //  }
        //}

        //[System.ComponentModel.Description("Nom")]
        //[DataMember()]
        //public string Nom
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      return PersonneFilm.NomComplet;
        //    else if (!IsNothing(SocieteFilm))
        //      return SocieteFilm.NomComplet;
        //    else
        //      return "";
        //  }
        //  set
        //  {
        //  }
        //}

        //[System.ComponentModel.Description("$$FonctionetNomComplet")]
        //[DataMember()]
        //public string FonctionetNomComplet
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      return PersonneFilm.FonctionetNomComplet;
        //    else if (!IsNothing(SocieteFilm))
        //      return SocieteFilm.FonctionetNomComplet;
        //    else
        //      return "";
        //  }
        //  set
        //  {
        //  }
        //}


        //[System.ComponentModel.Description("Contact Principal?")]
        //[DataMember()]
        //public bool EstContactPrincipal
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      return PersonneFilm.EstContactPrincipal;
        //    else if (!IsNothing(SocieteFilm))
        //      return SocieteFilm.EstContactPrincipal;
        //    else
        //      return false;
        //  }
        //  set
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      PersonneFilm.EstContactPrincipal = value;
        //    else if (!IsNothing(SocieteFilm))
        //      SocieteFilm.EstContactPrincipal = value;
        //  }
        //}

        //[System.ComponentModel.Description("Accès fiche film")]
        //[DataMember()]
        //public bool AccesFicheFilm
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      return PersonneFilm.AccesFicheFilm;
        //    else
        //      return false;
        //  }
        //  set
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      PersonneFilm.AccesFicheFilm = value;
        //  }
        //}

        [System.ComponentModel.Description("Créateur?")]
        [DataMember()]
        public bool EstCreateur
        {
          get
          {
            if (PersonneFilm?.Film?.IdContact != null)
            {
              if (PersonneFilm.Film.IdContact == PersonneFilm.IdPersonne)
                return true;
              else
                return false;
            }
            else
              return false;
          }
          set
          {
          }
        }


        [System.ComponentModel.Description("$$Ordre")]
        [DataMember()]
        public int? Ordre { get; set; }
      }

      [DataContract()]
      public class MembreCastingFilmData
      {
        [System.ComponentModel.Description("$$PersonneFilm")]
        [DataMember()]
        public PersonneFilmData PersonneFilm { get; set; }

        //[System.ComponentModel.Description("$$Id")]
        //[DataMember()]
        //public string Id
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm))
        //      return "P" + PersonneFilm.Id.ToString;
        //    else
        //      return "U";
        //  }
        //  set
        //  {
        //  }
        //}



        //[System.ComponentModel.Description("Civilité")]
        //[DataMember()]
        //public string Civilite
        //{
        //  get
        //  {
        //    if (!IsNothing(PersonneFilm) && !IsNothing(PersonneFilm.Personne) && !IsNothing(PersonneFilm.Personne.Civilite))
        //      return PersonneFilm.Personne.Civilite.Civilite;
        //    else
        //      return "";
        //  }
        //  set
        //  {
        //  }
        //}

        ////[System.ComponentModel.Description("Prénom")]
        ////[DataMember()]
        ////public string Prenom
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm) && !IsNothing(PersonneFilm.Personne))
        ////      return PersonneFilm.Personne.Prenom;
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("Nom")]
        ////[DataMember()]
        ////public string Nom
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm) && !IsNothing(PersonneFilm.Personne))
        ////      return PersonneFilm.Personne.Nom;
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        [System.ComponentModel.Description("Nationalité")]
        [DataMember()]
        public string Nationalite
        {
          get
          {
            if (PersonneFilm?.Personne != null)
              return PersonneFilm.Personne.Nationalite;
            else
              return "";
          }
          set
          {
          }
        }

        ////[System.ComponentModel.Description("Nationalité 2")]
        ////[DataMember()]
        ////public string Nationalite2
        ////{
        ////  get
        ////  {
        ////    if (PersonneFilm?.Personne != null)
        ////      return PersonneFilm.Personne.Nationalite2;
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("Fonction")]
        ////[DataMember()]
        ////public string Fonction
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm))
        ////    {
        ////      if (PersonneFilm.FonctionEquipe == "")
        ////        return PersonneFilm.FonctionPersonne;
        ////      else
        ////        return PersonneFilm.FonctionEquipe;
        ////    }
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("$$FonctionUs")]
        ////[DataMember()]
        ////public string FonctionUs
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm))
        ////    {
        ////      if (PersonneFilm.FonctionEquipe == "")
        ////        return PersonneFilm.FonctionPersonneUs;
        ////      else
        ////        return PersonneFilm.FonctionEquipe;
        ////    }
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("Date de naissance")]
        ////[DataMember()]
        ////public DateTime? NaissanceDate
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm) && !IsNothing(PersonneFilm.Personne) && !IsNothing(PersonneFilm.Personne.NaissanceDate))
        ////      return PersonneFilm.Personne.NaissanceDate;
        ////    else
        ////      return default(Date?);
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("Role")]
        ////[DataMember()]
        ////public string Role
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm))
        ////      return PersonneFilm.Role;
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("RoleUs")]
        ////[DataMember()]
        ////public string RoleUs
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm))
        ////      return PersonneFilm.RoleUs;
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}

        ////[System.ComponentModel.Description("Fonction + Nom")]
        ////[DataMember()]
        ////public string FonctionetNomComplet
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm))
        ////      return PersonneFilm.FonctionetNomComplet;
        ////    else
        ////      return "";
        ////  }
        ////  set
        ////  {
        ////  }
        ////}


        ////[System.ComponentModel.Description("$$Ordre=OrdreEquipe")]
        ////[DataMember()]
        ////public int? Ordre
        ////{
        ////  get
        ////  {
        ////    if (!IsNothing(PersonneFilm))
        ////      return PersonneFilm.Ordre;
        ////    else
        ////      return -1;
        ////  }
        ////  set
        ////  {
        ////    if (PersonneFilm != null)
        ////      PersonneFilm.Ordre = value;
        ////  }
        ////}

        [System.ComponentModel.Description("$$IdFilm")]
        [DataMember()]
        public int? IdFilm
        {
          get
          {
            return PersonneFilm?.IdFilm;
          }
          set
          {
          }
        }

        [System.ComponentModel.Description("Film")]
        [DataMember()]
        public FilmData Film
        {
          get
          {
            return PersonneFilm?.Film;
          }
          set
          {
          }
        }
      }

      [DataContract()]
      public class AutreFestivalFilmData
      {
        [System.ComponentModel.Description("$$Identifiant")]
        [DataMember()]
        public int? Id { get; set; }

        [System.ComponentModel.Description("$$Ordre")]
        [DataMember()]
        public int Ordre { get; set; }

        [System.ComponentModel.Description("$$IdFilm")]
        [DataMember()]
        public int? IdFilm { get; set; }

        [System.ComponentModel.Description("$$IdFilmInformation")]
        [DataMember()]
        public int? IdFilmInformation { get; set; } // IdFilmographie

        [System.ComponentModel.Description("Date création=DateCreation")]
        [DataMember()]
        public DateTime DateCreation { get; set; }

        [System.ComponentModel.Description("Date modification=DateModification")]
        [DataMember()]
        public DateTime DateModification { get; set; }

        [System.ComponentModel.Description("Nom=Nom")]
        [DataMember()]
        public string Nom { get; set; }

        [System.ComponentModel.Description("$$IdPays=IdPays")]
        [DataMember()]
        public string IdPays { get; set; }

        [System.ComponentModel.Description("Pays=Pays_Pays")]
        [DataMember()]
        public string Pays { get; set; }

        [System.ComponentModel.Description("Pays Us=Pays_PaysUs")]
        [DataMember()]
        public string PaysUs { get; set; }

        [System.ComponentModel.Description("Date Festival=DateFestival")]
        [DataMember()]
        public DateTime? DateFestival { get; set; }

        [System.ComponentModel.Description("Année")]
        [DataMember()]
        public string AnneeAutreFestival { get; set; }

        [System.ComponentModel.Description("Section=Section")]
        [DataMember()]
        public string Section { get; set; }

        [System.ComponentModel.Description("Récompenses=Recompenses")]
        [DataMember()]
        public string Recompenses { get; set; }

        [System.ComponentModel.Description("Commentaires=Commentaires")]
        [DataMember()]
        public string Commentaires { get; set; }
      }


      [DataContract()]
      public class FilmHistoriqueData
      {
        [System.ComponentModel.Description("Action")]
        [DataMember()]
        public string TypeEntite { get; set; }

        [System.ComponentModel.Description("Année")]
        [DataMember()]
        public string Annee { get; set; }

        [System.ComponentModel.Description("Section/Categ")]
        [DataMember()]
        public string Section { get; set; }

        [System.ComponentModel.Description("Titre")]
        [DataMember()]
        public string Titre { get; set; }

        [System.ComponentModel.Description("Fonction")]
        [DataMember()]
        public string Fonction { get; set; }

        [System.ComponentModel.Description("Statut")]
        [DataMember()]
        public string Statut { get; set; }

        [System.ComponentModel.Description("Prix")]
        [DataMember()]
        public string Prix { get; set; }

        [System.ComponentModel.Description("$$IdFilm")]
        [DataMember()]
        public int? IdFilm { get; set; }

        [System.ComponentModel.Description("$$IdPersonne")]
        [DataMember()]
        public int? IdPersonne { get; set; }

        [System.ComponentModel.Description("IdSociete")]
        [DataMember()]
        public int? IdSociete { get; set; }

        [System.ComponentModel.Description("Societe")]
        [DataMember()]
        public SocieteData Societe { get; set; }

        [System.ComponentModel.Description("Film")]
        [DataMember()]
        public FilmData Film { get; set; }

        [System.ComponentModel.Description("Inscription")]
        [DataMember()]
        public InscriptionFilmData InscriptionFilm { get; set; }

        [System.ComponentModel.Description("Personne")]
        [DataMember()]
        public PersonneData Personne { get; set; }
      }

      [DataContract()]
      public class GalaData
      {
        [DataMember()]
        public int? IdGala { get; set; }

        [DataMember()]
        public string Libelle { get; set; }

        [DataMember()]
        public bool Visible { get; set; }
      }

      [DataContract()]
      public class EtatTraductionData
      {
        [DataMember()]
        public int IdTraduction { get; set; }

        [DataMember()]
        public string Libelle { get; set; }
      }

      [DataContract()]
      public class AutorisationData
      {
        [DataMember()]
        public int? IdAutorisation { get; set; }

        [DataMember()]
        public int? IdInscriptionFilm { get; set; }

        [DataMember()]
        public int? IdAccreditation { get; set; }

        [DataMember()]
        public int? IdProjet { get; set; }

        [DataMember()]
        public int IdCompte { get; set; }

        [System.ComponentModel.Description("$$$Libelle")]
        [DataMember()]
        public string Libelle { get; set; }

        [DataMember()]
        public string Autorisation { get; set; }

        [DataMember()]
        public DateTime? DateSignature { get; set; }

        [DataMember()]
        public string Texte { get; set; }

        [System.ComponentModel.Description("$$$Nom")]
        [DataMember()]
        public string Nom { get; set; }
      }

      [DataContract()]
      public class FormatTournageFilmData
      {
        [System.ComponentModel.Description("Identifiant=IdFormatTournage")]
        [DataMember()]
        public int? IdFormatTournage { get; set; }

        [System.ComponentModel.Description("FormatTournage=FormatTournage")]
        [DataMember()]
        public string FormatTournage { get; set; }

        [System.ComponentModel.Description("FormatTournageUs=FormatTournageUs")]
        [DataMember()]
        public string FormatTournageUs { get; set; }
      }

      [DataContract()]
      public class RechercheCatalogueData
      {
        [DataMember()]
        public int NbFilms { get; set; }

        [DataMember()]
        public List<InscriptionFilmData> Films { get; set; }
      }

      public class SuiviPersonneData
      {
        public List<PersonneData> Personnes { get; set; }
        public InscriptionFilmData Film { get; set; }
        public SocieteData Societe { get; set; }
        public MarcheCommandeData Stand { get; set; }
        public string Url { get; set; }
      }

      public class LogoFilmData
      {
        public int? IdSelectLogo { get; set; }
        public string Condition { get; set; }
        public string Url { get; set; }
        public string Libelle { get; set; }
      }
    }
  }
}

