using Microsoft.VisualBasic;
using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class SocieteFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? IdSocieteFilm { get; set; }

    [System.ComponentModel.Description("$$IdSoif")]
    [DataMember()]
    public int? IdSoif { get; set; }

    [System.ComponentModel.Description("$$IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }


    public FilmData Film { get; set; }


    [System.ComponentModel.Description("$$IdFonctionSociete")]
    [DataMember()]
    public int? IdFonctionSociete { get; set; }


    [System.ComponentModel.Description("$$dFonctionsSocietes")]
    [DataMember()]
    public FonctionSocieteFilmData Fonction { get; set; }

    [System.ComponentModel.Description("Fonction=dFonctionsSocieteFilms_FonctionSociete")]
    [DataMember()]
    public string FonctionSociete { get; set; }
    // Get
    // Dim StrFonction As String = ""
    // If Not IsNothing(IdFonctionSociete) Then
    // StrFonction = Utils.Util.GetEnumDescription(DirectCast(CInt(IdFonctionSociete), FilmData.eFonctionSocieteFilm))
    // End If
    // Return StrFonction
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    ////[System.ComponentModel.Description("$$NomComplet=NomComplet")]
    ////[DataMember()]
    ////public string NomComplet
    ////{
    ////  get
    ////  {
    ////    string StrNomComplet = "";
    ////    // nom de la Societe
    ////    if (!IsNothing(Societe))
    ////      StrNomComplet = Societe.Nom;
    ////    return StrNomComplet;
    ////  }
    ////  set
    ////  {
    ////  }
    ////}

    ////[System.ComponentModel.Description("$$FonctionetNomComplet")]
    ////[DataMember()]
    ////public string FonctionetNomComplet
    ////{
    ////  get
    ////  {
    ////    string StrFonctionetNomComplet = NomComplet;

    ////    // Fonction de la societe
    ////    if (!Information.IsNothing(IdFonctionSociete))
    ////      StrFonctionetNomComplet = FonctionSociete + " - " + StrFonctionetNomComplet;
    ////    return StrFonctionetNomComplet;
    ////  }
    ////  set
    ////  {
    ////  }
    ////}



    [System.ComponentModel.Description("Ordre")]
    [DataMember()]
    public int? Ordre { get; set; }

    [System.ComponentModel.Description("$$IdSociete")]
    [DataMember()]
    public int? IdSociete { get; set; }

  
    public SocieteData Societe { get; set; }

    [System.ComponentModel.Description("$$IdContact")]
    [DataMember()]
    public int? IdContact { get; set; }

    [System.ComponentModel.Description("$$ContactSocieteFilm")]
    [DataMember()]
    public PersonneData ContactSociete { get; set; }

    [System.ComponentModel.Description("Email Contact=EmailContact")]
    [DataMember()]
    public string EmailContact { get; set; }

    [System.ComponentModel.Description("Telephone Contact=TelephoneContact")]
    [DataMember()]
    public string TelephoneContact { get; set; }

    [System.ComponentModel.Description("Est Contact Principal?=EstContactPrincipal")]
    [DataMember()]
    public bool EstContactPrincipal { get; set; }

    [System.ComponentModel.Description("Acces Fiche Film?=AccesFicheFilm")]
    [DataMember()]
    public bool AccesFicheFilm { get; set; }


    [System.ComponentModel.Description("Contacts secondaires=ContactsSecondaires")]
    [DataMember()]
    public string ContactsSecondaires { get; set; }

    [System.ComponentModel.Description("$$IdUtilisateurCreation")]
    [DataMember()]
    public int? IdUtilisateurCreation { get; set; }

    [System.ComponentModel.Description("$$ContactsSecondaire")]
    [DataMember()]
    public List<ContactSecondaireFilmData> ContactsSecondaire { get; set; }

    [System.ComponentModel.Description("Date de Modification=DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }
  }


  [Serializable]
  [DataContract()]
  public class ContactSecondaireFilmData
  {
    [System.ComponentModel.Description("$$Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$IdSocieteFilm")]
    [DataMember()]
    public int? IdSocieteFilm { get; set; }

    [System.ComponentModel.Description("$$SocieteFilm")]
    [DataMember()]
    public SocieteFilmData SocieteFilm { get; set; }

    [System.ComponentModel.Description("$$IdPersonne")]
    [DataMember()]
    public int? IdPersonne { get; set; }

    [System.ComponentModel.Description("$$Personne")]
    [DataMember()]
    public PersonneData Personne { get; set; }

    [System.ComponentModel.Description("$$ToDel")]
    [DataMember()]
    public bool? ToDel { get; set; }


    ////[System.ComponentModel.Description("Nom")]
    ////[DataMember()]
    ////public string Nom
    ////{
    ////  get
    ////  {
    ////    if (!IsNothing(Personne))
    ////      return Personne.Nom;
    ////    else
    ////      return "";
    ////  }
    ////  set
    ////  {
    ////  }
    ////}

    ////[System.ComponentModel.Description("Prénom")]
    ////[DataMember()]
    ////public string Prenom
    ////{
    ////  get
    ////  {
    ////    if (!IsNothing(Personne))
    ////      return Personne.Prenom;
    ////    else
    ////      return "";
    ////  }
    ////  set
    ////  {
    ////  }
    ////}

    //[System.ComponentModel.Description("Téléphone")]
    //[DataMember()]
    //public string Telephone
    //{
    //  get
    //  {
    //    if (!IsNothing(Personne))
    //      return Personne.Telephone2;
    //    else
    //      return "";
    //  }
    //  set
    //  {
    //  }
    //}

    ////[System.ComponentModel.Description("Email")]
    ////[DataMember()]
    ////public string Email
    ////{
    ////  get
    ////  {
    ////    if (!IsNothing(Personne))
    ////      return Personne.Email;
    ////    else
    ////      return "";
    ////  }
    ////  set
    ////  {
    ////  }
    ////}

    [System.ComponentModel.Description("Accès Fiche Films")]
    [DataMember()]
    public bool? AccesFicheFilm { get; set; }
  }


}
