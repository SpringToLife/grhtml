using Microsoft.VisualBasic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using static GrapesJsEditorHtml.ViewModel.InscriptionFilmData.FormulaireSelectionData;

namespace GrapesJsEditorHtml.ViewModel
{

    public class PersonneFilmData
    {
      

      [System.ComponentModel.Description("Identifiant")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("$$IdFilm")]
      [DataMember()]
      public int? IdFilm { get; set; }

      [System.ComponentModel.Description("$$IdPersonne")]
      [DataMember()]
      public int? IdPersonne { get; set; }

      [System.ComponentModel.Description("IdUtilisateurCreation")]
      [DataMember()]
      public int? IdUtilisateurCreation { get; set; }

      [System.ComponentModel.Description("$$IdFonction")]
      [DataMember()]
      public int? IdFonction { get; set; }

      [System.ComponentModel.Description("$$FonctionAutre")]
      [DataMember()]
      public string FonctionAutre { get; set; }

      [System.ComponentModel.Description("$$Fonction")]
      [DataMember()]
      public FonctionFilmData FonctionObject { get; set; }

      [System.ComponentModel.Description("$$IdFonctionPersonne")]
      [DataMember()]
      public int? IdFonctionPersonne { get; set; } // table référence dFonctionsPersonneFilms. Information générale: Votre fonction principale par rapport au film

      [System.ComponentModel.Description("$$FonctionPersonne")]
      [DataMember()]
      public FonctionPersonneFilmData FonctionPersonneObject { get; set; }


      [System.ComponentModel.Description("$$IdSoif")]
      [DataMember()]
      public int? IdSoif { get; set; }

      [System.ComponentModel.Description("$$IdSoif2")]
      [DataMember()]
      public int? IdSoif2 { get; set; }

      [System.ComponentModel.Description("Ordre=Ordre")]
      [DataMember()]
      public int? Ordre { get; set; }

      // <System.ComponentModel.Description("OrdreEquipe")>
      // <DataMember()>
      // Property OrdreEquipe As Integer

      [System.ComponentModel.Description("Personne=Personnes")]
      [DataMember()]
      public PersonneData Personne { get; set; }

      [System.ComponentModel.Description("Role=Role")]
      [DataMember()]
      public string Role { get; set; }

      [System.ComponentModel.Description("Role Us=RoleUs")]
      [DataMember()]
      public string RoleUs { get; set; }

      [System.ComponentModel.Description("Email=Email")]
      [DataMember()]
      public string Email { get; set; }

      [System.ComponentModel.Description("Téléphone=Telephone")]
      [DataMember()]
      public string Telephone { get; set; }

      [System.ComponentModel.Description("Portable=TelephonePortable")]
      [DataMember()]
      public string TelephonePortable { get; set; }

      [System.ComponentModel.Description("$$IdFonctionEquipePersonne")]
      [DataMember()]
      public int? IdFonctionEquipePersonne { get; set; } // table référence dFonctionsEquipe. Information artistique du film (Scenario et dialogue, ou Equipe artistique et technique pour SFC)

      [System.ComponentModel.Description("$$FonctionEquipePersonne")]
      [DataMember()]
      public FonctionEquipeFilmData FonctionEquipePersonne { get; set; }

      [System.ComponentModel.Description("$$Nom=Nom")]
      [DataMember()]
      public string Nom { get; set; }

      [System.ComponentModel.Description("$$Prénom=Prenom")]
      [DataMember()]
      public string Prenom { get; set; }

      [System.ComponentModel.Description("Contact Principal?=EstContactPrincipal")]
      [DataMember()]
      public bool EstContactPrincipal { get; set; }

      [System.ComponentModel.Description("Contact?=EstContact")]
      [DataMember()]
      public bool EstContact { get; set; }

      [System.ComponentModel.Description("Acces Fiche Film?=AccesFicheFilm")]
      [DataMember()]
      public bool AccesFicheFilm { get; set; }

      // Uniquement pour les reports
      [System.ComponentModel.Description("$$Filmographies")]
      [DataMember()]
      public List<FilmographieData> FilmographieFilms { get; set; } = new List<FilmographieData>();

      [System.ComponentModel.Description("$$Fonction personne=dFonctionsPersonneFilms_FonctionPersonne")]
      [DataMember()]
      public string FonctionPersonne { get; set; }

      [System.ComponentModel.Description("$$FonctionEquipe")]
      [DataMember()]
      public string FonctionEquipe { get; set; }

      [System.ComponentModel.Description("$$Fonction personne=dFonctionsPersonneFilms_FonctionPersonne")]
      [DataMember()]
      public string FonctionPersonneUs { get; set; }


      [System.ComponentModel.Description("Fonction=IsNull(dFonctionsEquipe_FonctionEquipe,dFonctionsPersonneFilms_FonctionPersonne)")]
      [DataMember()]
      public string Fonction
      {
        get
        {
          if (FonctionEquipe == "")
            return FonctionPersonne;
          else
            return FonctionEquipe;
        }
        set
        {
        }
      }



      //[System.ComponentModel.Description("$$NomComplet=NomComplet")]
      //[DataMember()]
      //public string NomComplet
      //{
      //  get
      //  {
      //    string StrNomComplet = "";
      //    // nom de la personne
      //    if (!IsNothing(Personne))
      //      StrNomComplet = Personne.FullName;
      //    else
      //      StrNomComplet = Prenom + " " + Nom;
      //    return StrNomComplet;
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("Fonction+Nom=FonctionetNomComplet")]
      //[DataMember()]
      //public string FonctionetNomComplet
      //{
      //  get
      //  {
      //    string StrFonctionetNomComplet = NomComplet;

      //    // Fonction de la personne
      //    if (!Information.IsNothing(IdFonctionPersonne))
      //      StrFonctionetNomComplet = FonctionPersonne + " - " + StrFonctionetNomComplet;
      //    return StrFonctionetNomComplet;
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("Fonction+Nom+Email=FonctionetNomCompletetEmail")]
      //[DataMember()]
      //public string FonctionetNomCompletetEmail
      //{
      //  get
      //  {
      //    string StrFonctionetNomCompletetEmail = FonctionetNomComplet;
      //    if (!Information.IsNothing(Email) && Email.Trim() != "")
      //    {
      //      if (EstContactPrincipal == false)
      //        StrFonctionetNomCompletetEmail = StrFonctionetNomCompletetEmail + " (" + Email + ")";
      //      else
      //        StrFonctionetNomCompletetEmail = StrFonctionetNomCompletetEmail + " (Contact principal)" + " (" + Email + ")";
      //    }


      //    return StrFonctionetNomCompletetEmail;
      //  }
      //  set
      //  {
      //  }
      //}

      [System.ComponentModel.Description("Film=dFilms")]
      [DataMember()]
      public FilmData Film { get; set; }

      [System.ComponentModel.Description("Date de Modification=DateModification")]
      [DataMember()]
      public DateTime? DateModification { get; set; }
    }

  }

