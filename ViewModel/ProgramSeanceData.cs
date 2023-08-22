using Microsoft.VisualBasic;

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{

    public class ProgramSeanceData
    {

    [System.ComponentModel.Description("Identifiant=Id")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("$$IdExterne")]
      [DataMember()]
      public int? IdExterne { get; set; }

      [System.ComponentModel.Description("$$NomSeance")]
      [DataMember()]
      public string Nom { get; set; } // vide, à rechercher dans la table dProgramObjet

      [System.ComponentModel.Description("Début=Debut")]
      [DataMember()]
      public DateTime Debut { get; set; } // normalement, il faut faire ca sur la base

      [System.ComponentModel.Description("Date longue Fr")]
      [DataMember()]
      public string LongDateTimeFr
      {
        get
        {
          return Debut.ToString("dddd dd MMMM HH:mm", new System.Globalization.CultureInfo("fr-FR"));
        }
        set
        {
        }
      }

      [System.ComponentModel.Description("Date longue En")]
      [DataMember()]
      public string LongDateTimeEn
      {
        get
        {
          try
          {
            return Debut.ToString("dddd MMMM dd hh:mm tt", new System.Globalization.CultureInfo("en-US"));
          }
          catch (Exception ex)
          {
            return Debut.ToString("dddd MMMM dd hh:mm");
          }
        }
        set
        {
        }
      }

      [System.ComponentModel.Description("Visibilité=Visibilite")]
      [DataMember()]
      public int Visibilite { get; set; }

      // <System.ComponentModel.Description("JourneeProgrammationId")>
      // <DataMember()>
      // Public Property JourneeProgrammationId As Integer?

      [System.ComponentModel.Description("$$SalleProgrammationId")]
      [DataMember()]
      public int? SalleProgrammationId { get; set; }

      [System.ComponentModel.Description("$$IdFilm")]
      [DataMember()]
      public int? IdFilm { get; set; } // IdFilm sur Posi. En général, une séance (projection) peut avoir une liste des films à projecter, 
                                       // mais spécifiquement, on peut citer par défaut un film qui contient les titres VO, VF affichés comme  'Competition court métrage' sur la table dProgramSeanceObjet, par exemple 
                                       // Du coup, la fin de projection sera la durée de ce film, ce qui n'est pas forcéménet vrai, vue qu'il y plusieurs films possible pour la séance concernée.

      [System.ComponentModel.Description("Fin=FinProjection")]
      [DataMember()]
      public DateTime Fin { get; set; }


      [System.ComponentModel.Description("Titre VF=TitreVF")]
      [DataMember()]
      public string TitreVF { get; set; } = null;

      [System.ComponentModel.Description("Titre VA=TitreVO")]
      [DataMember()]
      public string TitreVO { get; set; } = null;

      [System.ComponentModel.Description("$$EtatTraduction")]
      [DataMember()]
      public int? EtatTraduction { get; set; }

      [System.ComponentModel.Description("CST état=CstState")]
      [DataMember()]
      public string CstState { get; set; }

      [System.ComponentModel.Description("Grille presse?=GrillePresse")]
      [DataMember()]
      public bool? GrillePresse { get; set; } = false;

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

      [System.ComponentModel.Description("Date Création=DateCreation")]
      [DataMember()]
      public DateTime DateCreation { get; set; }


      [System.ComponentModel.Description("Date Publication=DatePublication")]
      [DataMember()]
      public DateTime? DatePublication { get; set; }


    // <System.ComponentModel.Description("SeanceObjet")>
    // <DataMember()>
    // Property ProgramSeanceObjet As ProgramSeanceObjetData

    // <System.ComponentModel.Description("SeanceObjet")>
    // <DataMember()>
    // Property ListProgramSeanceObjet As List(Of ProgramSeanceObjetData)


    // <System.ComponentModel.Description("TypeProjection")>
    // <DataMember()>
    // Property TypeProjection As ProgramTypeProjectionData


    public ProgramSalleData Salle { get; set; }

    // <System.ComponentModel.Description("Section")>
    // <DataMember()>
    // Property Section As ProgramSectionData

    // <System.ComponentModel.Description("Journee")>
    // <DataMember()>
    // Property Journee As ProgramJourneeData
    [System.ComponentModel.Description("Année=Annee")]
      [DataMember()]
      public string Annee { get; set; }

      [System.ComponentModel.Description("Date de Modification=DateModification")]
      [DataMember()]
      public DateTime? DateModification { get; set; }

      [System.ComponentModel.Description("Complet?=Complet")]
      [DataMember()]
      public bool? Complet { get; set; }

      //[System.ComponentModel.Description("Date Envoi eBillet")]
      //[DataMember()]
      //public DateTime? DateEnvoiEbillet
      //{
      //  get
      //  {
      //    if (Debut.Year == 1)
      //      return default(Date?);
      //    DateTime _Date = Debut.AddHours(-48);
      //    _Date = (DateTime)_Date.ToString("dd/MM/yyyy 23:00");
      //    return _Date;
      //  }
      //  set
      //  {
      //  }
      //}

      [System.ComponentModel.Description("Id.Type Accès=IdTypeAcces")]
      [DataMember()]
      public string IdTypeAcces { get; set; }

      // <System.ComponentModel.Description("$$$$DebutReservationTousBd")>
      // <DataMember()>
      // Property DebutReservationQuotaBd As Date?

      [System.ComponentModel.Description("$$DebutReservationPro")]
      [DataMember()]
      public DateTime DebutReservationPro { get; set; }

      [System.ComponentModel.Description("$$DebutReservationNoPro")]
      [DataMember()]
      public DateTime DebutReservationNoPro { get; set; }

      [System.ComponentModel.Description("$$DebutReservationTousBd")]
      [DataMember()]
      public DateTime? DebutReservationTousBd { get; set; }

      // <System.ComponentModel.Description("Début réservation=DebutReservationQuota")>
      // <DataMember()>
      // Property DebutReservationQuota As Date?

      [System.ComponentModel.Description("Début réservation tous=DebutReservationTous")]
      [DataMember()]
      public DateTime? DebutReservationTous { get; set; }

      [System.ComponentModel.Description("Date limite annulation=DateLimiteAnnulation")]
      [DataMember()]
      public DateTime? DateLimiteAnnulation { get; set; }

      [System.ComponentModel.Description("Fin réservation")]
      [DataMember()]
      public DateTime? FinReservation { get; set; }

      [System.ComponentModel.Description("$$DateLimiteAnnulationBd")]
      [DataMember()]
      public DateTime? DateLimiteAnnulationBd { get; set; }

      [System.ComponentModel.Description("Durée Fin Accès 1=DureeFinAcces1")]
      [DataMember()]
      public int DureeFinAcces1 { get; set; } = 0;

      [System.ComponentModel.Description("Durée Fin Accès 2=DureeFinAcces2")]
      [DataMember()]
      public int DureeFinAcces2 { get; set; } = 0;

      [System.ComponentModel.Description("$$DebutProjectionReel")]
      [DataMember()]
      public DateTime DebutProjectionReel
      {
        get
        {
          if (Debut.Hour < 7)
            return Debut.AddDays(1);
          else
            return Debut;
        }
        set
        {
          if (DebutProjectionReel.Hour < 7)
            Debut = DebutProjectionReel.AddDays(-1);
          else
            Debut = DebutProjectionReel;
        }
      }


      //[System.ComponentModel.Description("$$FinProjectionReel")]
      //[DataMember()]
      //public DateTime FinProjectionReel
      //{
      //  get
      //  {
      //    if (Fin.Hour < 7 && Debut.Hour < 7)
      //      return Fin.AddDays(1);
      //    else
      //      return Fin;
      //  }
      //  set
      //  {
      //    if ((DateTime)FinProjectionReel.Hour < 7 && Debut.Hour < 7)
      //      Fin = (DateTime)FinProjectionReel.AddDays(-1);
      //    else
      //      Fin = FinProjectionReel;
      //  }
      //}

      //[System.ComponentModel.Description("Durée (mn)")]
      //public int Duree
      //{
      //  get
      //  {
      //    return System.Convert.ToInt32(DateTime.DateDiff(DateInterval.Minute, (DateTime)Debut, (DateTime)Fin));
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("Durée (h)")]
      //public string DureeHeure
      //{
      //  get
      //  {
      //    int _Duree = System.Convert.ToInt32(DateTime.DateDiff(DateInterval.Minute, (DateTime)Debut, (DateTime)Fin));
      //    if (_Duree >= 60)
      //      return Math.Truncate(_Duree / (double)60).ToString() + "h" + (_Duree - Math.Truncate(_Duree / (double)60) * 60).ToString().PadLeft(2, System.Convert.ToChar("0"));
      //    else
      //      return _Duree.ToString() + "mn";
      //  }
      //  set
      //  {
      //  }
      //}


      //[System.ComponentModel.Description("Date Projection")]
      //[DataMember()]
      //public string DateProjection
      //{
      //  get
      //  {
      //    return (DateTime)Debut.ToString("dd/MM/yyyy");
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("$$DateProjectionShort")]
      //[DataMember()]
      //public string DateProjectionShort
      //{
      //  get
      //  {
      //    return (DateTime)Debut.ToString("ddd dd HH:mm");
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("Heure Projection")]
      //[DataMember()]
      //public string HeureProjection
      //{
      //  get
      //  {
      //    return (DateTime)Debut.ToString("HH:mm");
      //  }
      //  set
      //  {
      //  }
      //}

      //[System.ComponentModel.Description("Date Retrait")]
      //[DataMember()]
      //public DateTime DateRetrait { get; set; }

      //[System.ComponentModel.Description("Libellé")]
      //[DataMember()]
      //public string Libelle
      //{
      //  get
      //  {
      //    if (Salle == null)
      //      return "";
      //    else
      //      return Salle.Nom + " - " + (DateTime)Debut.ToString("dddd dd HH:mm");
      //  }
      //  set
      //  {
      //  }
      //}

      [System.ComponentModel.Description("Date Retrait Mail")]
      [DataMember()]
      public DateTime DateRetraitMail { get; set; }

      [System.ComponentModel.Description("Début Tirage")]
      [DataMember()]
      public DateTime DebutTirage { get; set; }

      [System.ComponentModel.Description("Fin Tirage")]
      [DataMember()]
      public DateTime FinTirage { get; set; }

      [System.ComponentModel.Description("Dernier Tirage")]
      [DataMember()]
      public DateTime? DernierTirage { get; set; }

      [System.ComponentModel.Description("Fin Accès 1")]
      [DataMember()]
      public DateTime FinAcces1
      {
        get
        {
          if ((Debut.Year == 1))
            return DateTime.Now;
          else
            return (DateTime)Debut.AddMinutes(-DureeFinAcces1);
        }
        set
        {
        }
      }

      [System.ComponentModel.Description("Fin Accès 2")]
      [DataMember()]
      public DateTime FinAcces2
      {
        get
        {
          if ((Debut.Year == 1))
            return DateTime.Now;
          else
            return (DateTime)Debut.AddMinutes(-DureeFinAcces2);
        }
        set
        {
        }
      }


      [System.ComponentModel.Description("Tenue Fr=TenueFr")]
      [DataMember()]
      public string TenueFr { get; set; }

      [System.ComponentModel.Description("Tenue Us=TenueUs")]
      [DataMember()]
      public string TenueUs { get; set; }

      [System.ComponentModel.Description("Code Jour=CodeJour")]
      [DataMember()]
      public string CodeJour { get; set; }

      [System.ComponentModel.Description("Type=Type")]
      [DataMember()]
      public string Type { get; set; }

      [System.ComponentModel.Description("N° Séance=NumSeance")]
      [DataMember()]
      public int NumSeance { get; set; }

      [System.ComponentModel.Description("N° Jour=NumJour")]
      [DataMember()]
      public int NumJour { get; set; }

      [System.ComponentModel.Description("$$IdFormat")]
      [DataMember()]
      public int? IdFormat { get; set; }

      [System.ComponentModel.Description("$$IdFormateBillet")]
      [DataMember()]
      public int? IdFormateBillet { get; set; }

      [System.ComponentModel.Description("Format Billet=pFormats_LibFormat")]
      [DataMember()]
      public string Format { get; set; }

      [System.ComponentModel.Description("Format e-Billet=pFormats2_LibFormat")]
      [DataMember()]
      public string FormateBillet { get; set; }

      [System.ComponentModel.Description("Disponible Résa?")]
      [DataMember()]
      public bool DisponibleResa { get; set; }

      [System.ComponentModel.Description("Réservation?")]
      [DataMember()]
      public bool Reservation { get; set; }

      [System.ComponentModel.Description("Nb. Billets")]
      [DataMember()]
      public int NbBillets { get; set; }

      [System.ComponentModel.Description("Nb. Disponibles")]
      [DataMember()]
      public int NbDisponibles { get; set; }

      // <System.ComponentModel.Description("Nb. Tardifs")>
      // <DataMember()>
      // Property NbTardifs As Integer

      [System.ComponentModel.Description("Nb. Dispo Resa")]
      [DataMember()]
      public int NbBilletsDispoResa { get; set; }

      [System.ComponentModel.Description("Nb Imprimés")]
      [DataMember()]
      public int NbImprimes { get; set; }

      // <System.ComponentModel.Description("Nb Demandes")>
      // <DataMember()>
      // Property NbDemandes As Integer

      [System.ComponentModel.Description("Nb Réservés")]
      [DataMember()]
      public int NbReserves { get; set; }

      [System.ComponentModel.Description("Nb Distribués")]
      [DataMember()]
      public int NbDistribues { get; set; }

      [System.ComponentModel.Description("Nb Controlés")]
      [DataMember()]
      public int NbControles { get; set; }

      [System.ComponentModel.Description("Nb Controlés")]
      [DataMember()]
      public int NbBadges { get; set; }

      [System.ComponentModel.Description("Nb à traiter")]
      [DataMember()]
      public int NbATraiter { get; set; }

      [System.ComponentModel.Description("Nb en attente")]
      [DataMember()]
      public int NbAttente { get; set; }

      [System.ComponentModel.Description("Nb confirmés")]
      [DataMember()]
      public int NbConfirme { get; set; }

      [System.ComponentModel.Description("Très demandée?=DemandeImportante")]
      [DataMember()]
      public bool DemandeImportante { get; set; }

      [System.ComponentModel.Description("Titre=Titre")]
      [DataMember()]
      public string Titre { get; set; }

      [System.ComponentModel.Description("Ligne 1 billet=Ligne1")]
      [DataMember()]
      public string Ligne1 { get; set; }

      [System.ComponentModel.Description("Ligne 2 billet=Ligne2")]
      [DataMember()]
      public string Ligne2 { get; set; }

      [System.ComponentModel.Description("Ligne 3 billet=Ligne3")]
      [DataMember()]
      public string Ligne3 { get; set; }

      [System.ComponentModel.Description("Ligne date billet=LigneDate")]
      [DataMember()]
      public string LigneDate { get; set; }

      [System.ComponentModel.Description("$$Flux")]
      [DataMember()]
      public List<ProjectionFluxData> Flux { get; set; }

      [System.ComponentModel.Description("Notes=Notes")]
      [DataMember]
      public string Notes { get; set; }
      // Ci dessous, les données à compléter si on veut etre en synchro avec les projections de Soif:

      [System.ComponentModel.Description("$$ListeProgramSeanceObjet")]
      [DataMember()]
      public List<ProgramSeanceObjetData> ListProgramSeanceObjet { get; set; } // Une seance (ou une projection) peut concerne plusieurs dProgramSeanceObjet (donc plusieurs films)

      [System.ComponentModel.Description("$$ProgramSeanceObjet")]
      [DataMember()]
      public ProgramSeanceObjetData ProgramSeanceObjet { get; set; }

      [System.ComponentModel.Description("$$Realisateurs")]
      [DataMember()]
      public List<PersonneFilmData> Realisateurs { get; set; }

     
      public FilmData Film { get; set; }

      [System.ComponentModel.Description("$$ListeFilms")]
      [DataMember()]
      public List<FilmData> ListFilms { get; set; }

      [System.ComponentModel.Description("$$IdSalle")]
      [DataMember()]
      public int? IdSalle { get; set; }

      [System.ComponentModel.Description("Deadline invit. diner=DeadlineDiner")]
      [DataMember()]
      public DateTime? DeadlineDiner { get; set; }


      //[System.ComponentModel.Description("Salle=dProgramSalle")]
      //[DataMember()]
      //public ProgramSalleData Salle { get; set; }


      // Save avec les param comme 'TypeProjectionId' des tables de référence, et la propriété de référence sera pour la lecture (Load) 'TypeProjection'(Data)
    
      public int? TypeProjectionId { get; set; }

      [System.ComponentModel.Description("Type Projection=dProgramTypeProjection")]
      [DataMember()]
      public ProgramTypeProjectionData TypeProjection { get; set; }


 
      //public int? SectionProgrammationId { get; set; }



      public ProgramSectionData SectionProgrammation { get; set; }

      [System.ComponentModel.Description("$$ObjetProgrammationId")]
      [DataMember()]
      public int? ObjetProgrammationId { get; set; }
      // Get
      // If Not IsNothing(ObjetProgrammation) Then
      // Return ObjetProgrammation.Id
      // End If
      // Return Nothing
      // End Get
      // Set(value As Integer?)
      // End Set
      // End Property

      [System.ComponentModel.Description("$$ObjetProgrammation")]
      [DataMember()]
      public ProgramObjetData ObjetProgrammation { get; set; }

      [System.ComponentModel.Description("Gala?=Gala")]
      [DataMember()]
      public bool Gala { get; set; }

      [System.ComponentModel.Description("Equipe du film?=EquipeFilm")]
      [DataMember()]
      public bool EquipeFilm { get; set; }

      [System.ComponentModel.Description("Organisateur=Organisateur")]
      [DataMember()]
      public string Organisateur { get; set; } = "F";

      [System.ComponentModel.Description("$$OrganisateurObjet")]
      [DataMember()]
      public MarcheProjectionOrganisateurData OrganisateurObjet { get; set; }

      [System.ComponentModel.Description("Gestionnaire Technique=GestionnaireTechnique")]
      [DataMember()]
      public string GestionnaireTechnique { get; set; } = "F";

      [System.ComponentModel.Description("Statut Technique=StatutTechnique")]
      [DataMember()]
      public string StatutTechnique { get; set; }

     
      public ProjectionEntreesData DetailEntrees { get; set; }
    }

    [Serializable]
    [DataContract]
    public class ProgramSeanceObjetData
    {
      [System.ComponentModel.Description("Identifiant=Identifiant")]
      [DataMember()]
      public int? Id { get; set; }

      [DataMember()]
      public int? Duree { get; set; }

      [System.ComponentModel.Description("Durée (h)")]
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


      [System.ComponentModel.Description("IdExterne")]
      [DataMember()]
      public int? IdExterne { get; set; }


      [System.ComponentModel.Description("$$SeanceProgrammationId")]
      [DataMember()]
      public int? SeanceProgrammationId { get; set; }

      // <System.ComponentModel.Description("ProgramSeance")>
      // <DataMember()>
      // Property Seance As ProgramSeanceData

      [System.ComponentModel.Description("$$ObjetProgrammationId")]
      [DataMember()]
      public int? ObjetProgrammationId { get; set; }

      [System.ComponentModel.Description("Ordre")]
      [DataMember()]
      public int Ordre { get; set; }

      [System.ComponentModel.Description("FilmData")]
      [DataMember()]
      public FilmData Film { get; set; }

      // <System.ComponentModel.Description("FilmId=FilmId")>
      // <DataMember()>
      // Property FilmId As Guid? 'IdFilm sur Soif

      [System.ComponentModel.Description("IdFilm")]
      [DataMember()]
      public int? IdFilm { get; set; } // IdFilm sur Posi

      [System.ComponentModel.Description("TitreVF")]
      [DataMember()]
      public string TitreVF { get; set; } = null;

      [System.ComponentModel.Description("TitreVO")]
      [DataMember()]
      public string TitreVO { get; set; } = null;

      [System.ComponentModel.Description("DateModification")]
      [DataMember()]
      public DateTime DateModification { get; set; }

      [System.ComponentModel.Description("ObjetProgrammation")]
      [DataMember()]
      public ProgramObjetData ObjetProgrammation { get; set; }
    }
    [DataContract]
    public class ProgramObjetData
    {
      [System.ComponentModel.Description("Identifiant")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("IdExterne")]
      [DataMember()]
      public int? IdExterne { get; set; }

      [System.ComponentModel.Description("NomObjet")]
      [DataMember()]
      public string Nom { get; set; } = null; // pour complète le nom des séances, evenement... dans la table dProgramSeance

      [System.ComponentModel.Description("Visibilite")]
      [DataMember()]
      public int Visibilite { get; set; }


      [System.ComponentModel.Description("Duree")]
      [DataMember()]
      public long Duree { get; set; } // ou int64

      [System.ComponentModel.Description("DureeMinute")]
      [DataMember()]
      public int DureeMinute { get; set; }


      [System.ComponentModel.Description("Ordre")]
      [DataMember()]
      public int Ordre { get; set; }

      [System.ComponentModel.Description("IsPrintable")]
      [DataMember()]
      public bool IsPrintable { get; set; }

      [System.ComponentModel.Description("TypeObjet")]
      [DataMember()]
      public int TypeObjet { get; set; }


      [System.ComponentModel.Description("IsFilm")]
      [DataMember()]
      public bool IsFilm { get; set; }

      [System.ComponentModel.Description("DateModification")]
      [DataMember()]
      public DateTime DateModification { get; set; }

      [DataMember()]
      [System.ComponentModel.Description("$$OldValue")]
      public ProgramObjetData OldData { get; set; }
    }
  public enum eProgramObjetData
  {
    [System.ComponentModel.Description("ObjetProgrammation Adami")]
    Adami = 1,
    [System.ComponentModel.Description("ObjetProgrammation Cérémonie d'Ouverture")]
    CeremonieOuverture = 2,
    [System.ComponentModel.Description("ObjetProgrammation Film")]
    Film = 3,
    [System.ComponentModel.Description("ObjetProgrammation Film")]
    Film1 = 4,
    [System.ComponentModel.Description("ObjetProgrammation Cérémonie de Clôture")]
    CeremonieCloture = 5,
    [System.ComponentModel.Description("ObjetProgrammation Angenieux")]
    Angenieux = 6,
    [System.ComponentModel.Description("ObjetProgrammation ProgrammationResources.VmGestionProgrammation_PhotoCallProgrammation")]
    PhotoCallProgrammation = 7,
    [System.ComponentModel.Description("ObjetProgrammation Cinéfondation")]
    Cinefondation = 8,
    [System.ComponentModel.Description("ObjetProgrammation courts metrages compet")]
    courtsMetragesCompet = 9,
    [System.ComponentModel.Description("ObjetProgrammation Leçon de Cinéma")]
    LeconDeCinema = 10,
    [System.ComponentModel.Description("ObjetProgrammation Répétition")]
    Repetition = 14
  }

  [Serializable]
  [DataContract]
  public class ProgramTypeProjectionData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Nom")]
    [DataMember()]
    public string Nom { get; set; } = null;

    [System.ComponentModel.Description("Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    //[System.ComponentModel.Description("$$Color")]
    //public Windows.Media.Color Color
    //{
    //  get
    //  {
    //    if (Couleur != "")
    //      return (Windows.Media.Color)Utils.Util.GetWpfColor(Couleur);
    //    else
    //      return Windows.Media.Colors.White;
    //  }
    //}


    [System.ComponentModel.Description("Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("Imprimer?")]
    [DataMember()]
    public bool Imprimer { get; set; }

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public ProgramTypeProjectionData OldData { get; set; }

    public ProgramTypeProjectionData()
    {
    }
    public ProgramTypeProjectionData(ProgramTypeProjectionData TypePrj)
    {
      this.Id = TypePrj.Id;
      this.IdExterne = TypePrj.IdExterne;
      this.Nom = TypePrj.Nom;
      this.Ordre = TypePrj.Ordre;
      this.Couleur = TypePrj.Couleur;
      this.DateModification = TypePrj.DateModification;
    }
  }

  [Serializable]
  [DataContract]
  public class ProgramSectionData
  {
    [System.ComponentModel.Description("$$Identifiant")]
    [DataMember()]
    public int? Id { get; set; }
    [System.ComponentModel.Description("$$IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Libellé Fr=Libelle")]
    [DataMember()]
    public string Libelle { get; set; } = "";

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; } = "";

    [System.ComponentModel.Description("Date de création=DateCreation")]
    [DataMember()]
    public DateTime DateCreation { get; set; }

    [System.ComponentModel.Description("Date de modification=DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("Display Resa?=DisplayResa")]
    [DataMember()]
    public bool DisplayResa { get; set; }

    // <System.ComponentModel.Description("Sur badge?=SurBadge")>
    // <DataMember()>
    // Public Property SurBadge As Boolean

    // <System.ComponentModel.Description("Accès libre?=AccesLibre")>
    // <DataMember()>
    // Public Property AccesLibre As Boolean

    [System.ComponentModel.Description("$$GROUPES")]
    [DataMember()]
    public string Groupes { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public ProgramSectionData OldData { get; set; }
  }

  [Serializable]
  [DataContract]
  public class ProgramJourneeData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("ProgrammationId")]
    [DataMember()]
    public int? ProgrammationId { get; set; }

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public ProgramJourneeData OldData { get; set; }
  }

  [Serializable]
  [DataContract]
  public class ProgramData
  {


    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Nom")]
    [DataMember()]
    public string Nom { get; set; } = null;

    [System.ComponentModel.Description("ProgrammeId")]
    [DataMember()]
    public int? ProgrammeId { get; set; }

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public ProgramData OldData { get; set; }
  }

  [Serializable]
  [DataContract]
  public class ProgramEditionData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Nom")]
    [DataMember()]
    public string Nom { get; set; } = null;

    [System.ComponentModel.Description("FestivalId")]
    [DataMember()]
    public int? FestivalId { get; set; }

    [System.ComponentModel.Description("Ouverture")]
    [DataMember()]
    public DateTime? Ouverture { get; set; }

    [System.ComponentModel.Description("Fermeture")]
    [DataMember()]
    public DateTime? Fermeture { get; set; }

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public ProgramEditionData OldData { get; set; }
  }

  [Serializable]
  [DataContract]
  public class ProgramSalleData
  {
    [System.ComponentModel.Description("Identifiant=Id")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("$$Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Nom=Nom")]
    [DataMember()]
    public string Nom { get; set; } = null;

    [System.ComponentModel.Description("NomUs=Nom")]
    [DataMember()]
    public string NomUs { get; set; } = null;

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("$$IdLieu")]
    [DataMember()]
    public int IdLieu { get; set; }

    [System.ComponentModel.Description("Groupes=Groupes")]
    [DataMember()]
    public string Groupes { get; set; }
    // <DataMember()>
    // <System.ComponentModel.Description("$$OldValue")>
    // Public Property OldData As ProgramSalleData

    // <System.ComponentModel.Description("$$OffsetLastMinute")>
    // <DataMember()>
    // Property OffsetLastMinute As Integer?

    [System.ComponentModel.Description("Début réservation Pro=DebutReservationQuota")]
    [DataMember()]
    public string DebutReservationQuota { get; set; }

    [System.ComponentModel.Description("Début réservation tous=DebutReservationTous")]
    [DataMember()]
    public string DebutReservationTous { get; set; }

    [System.ComponentModel.Description("Fin limite annulation=DateLimiteAnnulation")]
    [DataMember()]
    public string DateLimiteAnnulation { get; set; }

    [System.ComponentModel.Description("Fin limite réservation=FinReservation")]
    [DataMember()]
    public string FinReservation { get; set; }

    [System.ComponentModel.Description("Lieu=Lieu")]
    [DataMember()]
    public string Lieu { get; set; }

    [System.ComponentModel.Description("UrlLieu=UrlLieu")]
    [DataMember()]
    public string UrlLieu { get; set; }

    [System.ComponentModel.Description("Gère Pmr?=GerePmr")]
    [DataMember()]
    public bool GerePmr { get; set; }

    [System.ComponentModel.Description("Latitude=Latitude")]
    [DataMember()]
    public string Latitude { get; set; }

    [System.ComponentModel.Description("Longitude=Longitude")]
    [DataMember()]
    public string Longitude { get; set; }

    [System.ComponentModel.Description("Id.Type Accès=IdTypeAcces")]
    [DataMember()]
    public string IdTypeAcces { get; set; }
  }

  [Serializable]
  [DataContract]
  public class ProgramCreneauData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }  // utilisé pour IdCreneauDebut

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Debut")]
    [DataMember()]
    public long Debut { get; set; }

    [DataMember()]
    public DateTime HeureDebut { get; set; }

    [System.ComponentModel.Description("Duree")]
    [DataMember()]
    public long Duree { get; set; }

    [DataMember()]
    public double MinuteParPixel { get; set; }

    [System.ComponentModel.Description("Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    public int IdCreneauFin { get; set; } // pour récupérer Id dans la liste des créneaux

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }
    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public ProgramCreneauData OldData { get; set; }
  }


  // dProjectionData ', sert à ajouter (pour département dFilm). 
  // Apparemment la projection de Soif n'est que pour le festival? (Cedric)

  // <DataContract>
  // Public Class dProjectionData

  // <System.ComponentModel.Description("$$LibrairieDirecte")>
  // <IgnoreDataMember>
  // Public Property LibraryDirect As String = "WcfService.dProjection, WcfService"

  // <System.ComponentModel.Description("$$Librairie")>
  // <IgnoreDataMember>
  // Public Property Library As String = "Services.dProjection.IdProjectionClient, Services"

  // <System.ComponentModel.Description("Identifiant=IdProjection")>
  // <DataMember>
  // Property Id As Integer?

  // <System.ComponentModel.Description("$$IdExterne")>
  // <DataMember()>
  // Property IdExterne As Integer? ' IdExterne sur la table dProgramSeance qui vient de programmation.SeanceProgrammation de Soif

  // '<System.ComponentModel.Description("Actif")>
  // '<DataMember()>
  // Property Actif As Boolean?


  // <System.ComponentModel.Description("Année=Annee")>
  // <DataMember()>
  // Property Annee As String

  // <System.ComponentModel.Description("Date de Modification=DateModification")>
  // <DataMember()>
  // Property DateModification As Date?

  // <System.ComponentModel.Description("Durée Fin Accès 1=DureeFinAcces1")>
  // <DataMember()>
  // Property DureeFinAcces1 As Integer = 0

  // <System.ComponentModel.Description("Durée Fin Accès 2=DureeFinAcces2")>
  // <DataMember()>
  // Property DureeFinAcces2 As Integer = 0

  // <System.ComponentModel.Description("Début Projection=DebutProjection")>
  // <DataMember()>
  // Property DebutProjection As Date

  // <System.ComponentModel.Description("$$DebutProjectionReel")>
  // <DataMember()>
  // Property DebutProjectionReel As Date
  // Get
  // If DebutProjection.Hour < 7 Then
  // Return DebutProjection.AddDays(1)
  // Else
  // Return DebutProjection
  // End If
  // End Get
  // Set(value As Date)
  // If DebutProjectionReel.Hour < 7 Then
  // DebutProjection = DebutProjectionReel.AddDays(-1)
  // Else
  // DebutProjection = DebutProjectionReel
  // End If
  // End Set
  // End Property

  // <System.ComponentModel.Description("Fin Projection=FinProjection")>
  // <DataMember()>
  // Property FinProjection As Date

  // <System.ComponentModel.Description("$$FinProjectionReel")>
  // <DataMember()>
  // Property FinProjectionReel As Date
  // Get
  // If FinProjection.Hour < 7 AndAlso DebutProjection.Hour < 7 Then
  // Return FinProjection.AddDays(1)
  // Else
  // Return FinProjection
  // End If
  // End Get
  // Set(value As Date)
  // If FinProjectionReel.Hour < 7 AndAlso DebutProjection.Hour < 7 Then
  // FinProjection = FinProjectionReel.AddDays(-1)
  // Else
  // FinProjection = FinProjectionReel
  // End If
  // End Set
  // End Property

  // <System.ComponentModel.Description("Durée (mn)")>
  // Property Duree As Integer
  // Get
  // Return CInt(DateDiff(DateInterval.Minute, DebutProjection, FinProjection))
  // End Get
  // Set(value As Integer)

  // End Set
  // End Property

  // <System.ComponentModel.Description("Durée (h)")>
  // Property DureeHeure As String
  // Get
  // Dim _Duree As Integer = CInt(DateDiff(DateInterval.Minute, DebutProjection, FinProjection))
  // If _Duree >= 60 Then
  // Return Math.Truncate(_Duree / 60).ToString + "h" + (_Duree - Math.Truncate(_Duree / 60) * 60).ToString.PadLeft(2, CChar("0"))
  // Else
  // Return _Duree.ToString + "mn"
  // End If
  // End Get
  // Set(value As String)

  // End Set
  // End Property


  // <System.ComponentModel.Description("Date Projection")>
  // <DataMember()>
  // Property DateProjection As String
  // Get
  // Return DebutProjection.ToString("dd/MM/yyyy")
  // End Get
  // Set(value As String)

  // End Set
  // End Property

  // <System.ComponentModel.Description("$$DateProjectionShort")>
  // <DataMember()>
  // Property DateProjectionShort As String
  // Get
  // Return DebutProjection.ToString("ddd dd HH:mm")
  // End Get
  // Set(value As String)

  // End Set
  // End Property

  // <System.ComponentModel.Description("Heure Projection")>
  // <DataMember()>
  // Property HeureProjection As String
  // Get
  // Return DebutProjection.ToString("HH:mm")
  // End Get
  // Set(value As String)

  // End Set
  // End Property

  // <System.ComponentModel.Description("Date Retrait")>
  // <DataMember()>
  // Property DateRetrait As Date

  // <System.ComponentModel.Description("Libellé")>
  // <DataMember()>
  // Property Libelle As String
  // Get
  // If Salle Is Nothing Then
  // Return ""
  // Else
  // Return Salle.Nom + " - " + DebutProjection.ToString("dddd dd HH:mm")
  // End If
  // End Get
  // Set(value As String)

  // End Set
  // End Property

  // <System.ComponentModel.Description("Date Retrait Mail")>
  // <DataMember()>
  // Property DateRetraitMail As Date

  // <System.ComponentModel.Description("Début Tirage")>
  // <DataMember()>
  // Property DebutTirage As Date

  // <System.ComponentModel.Description("Fin Tirage")>
  // <DataMember()>
  // Property FinTirage As Date

  // <System.ComponentModel.Description("Dernier Tirage")>
  // <DataMember()>
  // Property DernierTirage As Date?

  // <System.ComponentModel.Description("Fin Accès 1")>
  // <DataMember()>
  // Property FinAcces1 As Date
  // Get
  // Return DebutProjection.AddMinutes(-DureeFinAcces1)
  // End Get
  // Set(value As Date)

  // End Set
  // End Property

  // <System.ComponentModel.Description("Fin Accès 2")>
  // <DataMember()>
  // Property FinAcces2 As Date
  // Get
  // Return DebutProjection.AddMinutes(-DureeFinAcces2)
  // End Get
  // Set(value As Date)

  // End Set
  // End Property


  // <System.ComponentModel.Description("Tenue Fr=TenueFr")>
  // <DataMember()>
  // Property TenueFr As String

  // <System.ComponentModel.Description("Tenue Us=TenueUs")>
  // <DataMember()>
  // Property TenueUs As String

  // <System.ComponentModel.Description("Code Jour=CodeJour")>
  // <DataMember()>
  // Property CodeJour As String

  // <System.ComponentModel.Description("Type=Type")>
  // <DataMember()>
  // Property Type As String

  // <System.ComponentModel.Description("N° Séance=NumSeance")>
  // <DataMember()>
  // Property NumSeance As Integer

  // <System.ComponentModel.Description("N° Jour=NumJour")>
  // <DataMember()>
  // Property NumJour As Integer

  // <System.ComponentModel.Description("$$IdFormat")>
  // <DataMember()>
  // Property IdFormat As Integer?

  // <System.ComponentModel.Description("Format Billet=pFormats_LibFormat")>
  // <DataMember()>
  // Property Format As String

  // <System.ComponentModel.Description("Disponible Résa?")>
  // <DataMember()>
  // Property DisponibleResa As Boolean

  // <System.ComponentModel.Description("Réservation?")>
  // <DataMember()>
  // Property Reservation As Boolean

  // <System.ComponentModel.Description("Nb. Billets")>
  // <DataMember()>
  // Property NbBillets As Integer

  // <System.ComponentModel.Description("Nb. Disponibles")>
  // <DataMember()>
  // Property NbDisponibles As Integer

  // <System.ComponentModel.Description("Nb. Dispo Resa")>
  // <DataMember()>
  // Property NbBilletsDispoResa As Integer

  // <System.ComponentModel.Description("Nb Imprimés")>
  // <DataMember()>
  // Property NbImprimes As Integer

  // <System.ComponentModel.Description("Nb Demandes")>
  // <DataMember()>
  // Property NbDemandes As Integer

  // <System.ComponentModel.Description("Nb Réservés")>
  // <DataMember()>
  // Property NbReserves As Integer

  // <System.ComponentModel.Description("Nb Distribués")>
  // <DataMember()>
  // Property NbDistribues As Integer

  // <System.ComponentModel.Description("Nb Controlés")>
  // <DataMember()>
  // Property NbControles As Integer

  // <System.ComponentModel.Description("Nb à traiter")>
  // <DataMember()>
  // Property NbATraiter As Integer

  // <System.ComponentModel.Description("Nb en attente")>
  // <DataMember()>
  // Property NbAttente As Integer

  // <System.ComponentModel.Description("Nb confirmés")>
  // <DataMember()>
  // Property NbConfirme As Integer

  // <System.ComponentModel.Description("Très demandée?=DemandeImportante")>
  // <DataMember()>
  // Property DemandeImportante As Boolean

  // <System.ComponentModel.Description("Titre=Titre")>
  // <DataMember()>
  // Property Titre As String

  // <System.ComponentModel.Description("Ligne 1 billet=Ligne1")>
  // <DataMember()>
  // Property Ligne1 As String

  // <System.ComponentModel.Description("Ligne 2 billet=Ligne2")>
  // <DataMember()>
  // Property Ligne2 As String

  // <System.ComponentModel.Description("Ligne 3 billet=Ligne3")>
  // <DataMember()>
  // Property Ligne3 As String

  // <System.ComponentModel.Description("Ligne date billet=LigneDate")>
  // <DataMember()>
  // Property LigneDate As String

  // <System.ComponentModel.Description("$$Flux")>
  // <DataMember()>
  // Property Flux As List(Of ProjectionFluxData)

  // <System.ComponentModel.Description("Notes=Notes")>
  // <DataMember>
  // Property Notes As String
  // 'Ci dessous, les données à compléter si on veut etre en synchro avec les projections de Soif:

  // <System.ComponentModel.Description("$$NomProjectionFilm")>
  // <DataMember()>
  // Property Nom As String

  // 'dProjections et dProgramSeance  est la relation 1-1 strictement pour notre projection films. Notion Projection et Séance sont la meme chose

  // <System.ComponentModel.Description("Programme=dProgramSeance")>
  // <DataMember()>
  // Property ProgramSeance As ProgramSeanceData

  // <System.ComponentModel.Description("$$ListeProgramSeanceObjet")>
  // <DataMember()>
  // Property ListProgramSeanceObjet As List(Of ProgramSeanceObjetData) 'Une seance (ou une projection) peut concerne plusieurs dProgramSeanceObjet (donc plusieurs films)

  // <System.ComponentModel.Description("$$ProgramSeanceObjet")>
  // <DataMember()>
  // Property ProgramSeanceObjet As ProgramSeanceObjetData

  // <System.ComponentModel.Description("$$IdFilm")>
  // <DataMember()>
  // Property IdFilm As Integer?

  // <System.ComponentModel.Description("$$Realisateurs")>
  // <DataMember()>
  // Property Realisateurs As List(Of PersonneFilmData)

  // <System.ComponentModel.Description("Film=dFilms")>
  // <DataMember()>
  // Property Film As FilmData

  // <System.ComponentModel.Description("$$ListeFilms")>
  // <DataMember()>
  // Property ListFilms As List(Of FilmData)

  // <System.ComponentModel.Description("$$IdSalle")>
  // <DataMember()>
  // Property IdSalle As Integer?

  // <System.ComponentModel.Description("Deadline invit. diner=DeadlineDiner")>
  // <DataMember()>
  // Property DeadlineDiner As Date?


  // <System.ComponentModel.Description("Salle=dProgramSalle")>
  // <DataMember()>
  // Property Salle As ProgramSalleData


  // 'Save avec les param comme 'TypeProjectionId' des tables de référence, et la propriété de référence sera pour la lecture (Load) 'TypeProjection'(Data)
  // <System.ComponentModel.Description("$$TypeProjectionId")>
  // <DataMember()>
  // Public Property TypeProjectionId As Integer?

  // <System.ComponentModel.Description("$$TypeProjection")>
  // <DataMember()>
  // Property TypeProjection As ProgramTypeProjectionData


  // <System.ComponentModel.Description("$$SectionProgrammationId")>
  // <DataMember()>
  // Property SectionProgrammationId As Integer?


  // <System.ComponentModel.Description("Section programmation")>
  // <DataMember()>
  // Property SectionProgrammation As ProgramSectionData

  // 'Normalement, ce sera une liste

  // <System.ComponentModel.Description("$$GroupeFilmId")>
  // <DataMember()>
  // Property GroupeFilmId As Integer?

  // <System.ComponentModel.Description("$$ObjetProgrammationId")>
  // <DataMember()>
  // Property ObjetProgrammationId As Integer?
  // '    Get
  // '        If Not IsNothing(ObjetProgrammation) Then
  // '            Return ObjetProgrammation.Id
  // '        End If
  // '        Return Nothing
  // '    End Get
  // '    Set(value As Integer?)
  // '    End Set
  // 'End Property

  // <System.ComponentModel.Description("$$ObjetProgrammation")>
  // <DataMember()>
  // Property ObjetProgrammation As ProgramObjetData

  // <System.ComponentModel.Description("Gala?=Gala")>
  // <DataMember()>
  // Property Gala As Boolean


  // <System.ComponentModel.Description("Organisateur=Organisateur")>
  // <DataMember()>
  // Property Organisateur As String = "F"

  // <System.ComponentModel.Description("Gestionnaire Technique=GestionnaireTechnique")>
  // <DataMember()>
  // Property GestionnaireTechnique As String = "F"
  // End Class

  // <DataContract()>
  // Public Class ProjectionFluxData
  // <DataMember()>
  // Property DateControle As Date
  // <DataMember()>
  // Property Nombre As Integer
  // End Class

  [DataContract()]
  public class ProjectionStatut
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public string Libelle { get; set; }
    [DataMember()]
    public string Couleur { get; set; }
    [DataMember()]
    public string Annee { get; set; }
    [DataMember()]
    public string Etat { get; set; }
    [DataMember()]
    public int Ordre { get; set; }
  }

  [DataContract()]
  public class StatTirageData
  {
    [DataMember()]
    public string Secteur { get; set; }
    [DataMember()]
    public string Importance { get; set; }
    [DataMember()]
    public int Demande { get; set; }
    [DataMember()]
    public int Accepte { get; set; }
    [DataMember()]
    public int Refuse { get; set; }
    [DataMember()]
    public List<DemandeData> Demandes { get; set; }
  }


  [DataContract()]
  public class ProjectionFluxData
  {
    [DataMember()]
    public DateTime DateControle { get; set; }
    [DataMember()]
    public int Nombre { get; set; }
  }

  [DataContract()]
  public class CodeJour
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public int IdSalle { get; set; }
    [DataMember()]
    public string Lettre { get; set; }
    [DataMember()]
    public int Jour { get; set; }
  }



  [Serializable]
  [DataContract]
  public class FavorisData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Actif")]
    [DataMember()]
    public bool? Actif { get; set; }

    [System.ComponentModel.Description("IdFilm Soif")]
    [DataMember()]
    public Guid? IdFilm { get; set; }

    [System.ComponentModel.Description("FilmId Posi")]
    [DataMember()]
    public int? FilmId { get; set; }

    [System.ComponentModel.Description("IdCompteUtilisateur Soif")]
    [DataMember()]
    public Guid? IdCompteSoif { get; set; }

    [System.ComponentModel.Description("IdCompteUtilisateur Posi")]
    [DataMember()]
    public int? IdCompte { get; set; }

    // <System.ComponentModel.Description("ListRepertoireFavoris")>
    // <DataMember()>
    // Property ListRepertoireFavoris As List(Of RepertoireFavorisData)

    // <System.ComponentModel.Description("RepertoireFavoris")>
    // <DataMember()>
    // Property RepertoireFavoris As RepertoireFavorisData

    [System.ComponentModel.Description("Comment")]
    [DataMember()]
    public string Comment { get; set; } = null;

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public FavorisData OldData { get; set; }
  }



  [Serializable]
  [DataContract]
  public class RepertoireFavorisData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdExterne")]
    [DataMember()]
    public int? IdExterne { get; set; }

    [System.ComponentModel.Description("Actif")]
    [DataMember()]
    public bool? Actif { get; set; } = true;

    [System.ComponentModel.Description("LibelleEn")]
    [DataMember()]
    public string LibelleEn { get; set; } = "";

    [System.ComponentModel.Description("LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; } = "";

    [System.ComponentModel.Description("Description Us=DescriptionEn")]
    [DataMember()]
    public string DescriptionEn { get; set; }

    [System.ComponentModel.Description("Description Fr=DescriptionFr")]
    [DataMember()]
    public string DescriptionFr { get; set; }

    [System.ComponentModel.Description("IsApproved")]
    [DataMember()]
    public bool IsApproved { get; set; }

    [System.ComponentModel.Description("IsProgramme")]
    [DataMember()]
    public bool IsProgramme { get; set; }

    [System.ComponentModel.Description("Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("Id. Cinando=IdCinando")]
    [DataMember()]
    public int? IdCinando { get; set; }

    [System.ComponentModel.Description("IsSelectionOfficielle")]
    [DataMember()]
    public bool IsSelectionOfficielle { get; set; }

    [System.ComponentModel.Description("IsSystem")]
    [DataMember()]
    public bool IsSystem { get; set; }

    [System.ComponentModel.Description("IdCompteUtilisateur")]
    [DataMember()]
    public Guid? IdCompteSoif { get; set; }

    [System.ComponentModel.Description("IdCompteUtilisateur Posi")]
    [DataMember()]
    public int? IdCompte { get; set; }

    [System.ComponentModel.Description("LibelleAbrege")]
    [DataMember()]
    public string LibelleAbrege { get; set; }

    [System.ComponentModel.Description("CodeInscriptionSource")]
    [DataMember()]
    public string CodeInscriptionSource { get; set; } = null;

    [System.ComponentModel.Description("IdFestival")]
    [DataMember()]
    public int? IdFestival { get; set; }

    [System.ComponentModel.Description("Annee")]
    [DataMember()]
    public string Annee { get; set; } = null;


    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }


    // <System.ComponentModel.Description("Favoris")>
    // <DataMember()>
    // Property Favoris As FavorisData

    [System.ComponentModel.Description("ListFavoris")]
    [DataMember()]
    public List<FavorisData> ListFavoris { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public RepertoireFavorisData OldData { get; set; }

    [System.ComponentModel.Description("Image")]
    [DataMember()]
    public string Image { get; set; } // Image lié à la collection

    [System.ComponentModel.Description("NbFilm")]
    [DataMember()]
    public int NbFilm { get; set; }

    [System.ComponentModel.Description("VLCustomTags")]
    [DataMember()]
    public bool VLCustomTags { get; set; }
  }

  [Serializable]
  [DataContract]
  public class RelRepertoireFavorisFavoriData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("Actif")]
    [DataMember()]
    public bool? Actif { get; set; }

    [System.ComponentModel.Description("IdRepertoireFavoris Externe")]
    [DataMember()]
    public int? IdRepertoireFavorisEx { get; set; }

    [System.ComponentModel.Description("IdFavori Externe")]
    [DataMember()]
    public int? IdFavoriEx { get; set; }

    [System.ComponentModel.Description("IdRepertoireFavoris")]
    [DataMember()]
    public int IdRepertoireFavoris { get; set; }

    [System.ComponentModel.Description("IdFavori")]
    [DataMember()]
    public int IdFavori { get; set; }

    [System.ComponentModel.Description("DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$OldValue")]
    public RelRepertoireFavorisFavoriData OldData { get; set; }
  }

  public class Visibilite
  {
    public string Nom { get; set; }
    public int Id { get; set; }
    //public Windows.Media.SolidColorBrush Couleur { get; set; }
  }

  public class ProjectionEntreesData
  {
    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public int? IdProgramSeance { get; set; }

    [DataMember()]
    public int? Presse { get; set; }

    [DataMember()]
    public int? Badge { get; set; }

    [DataMember()]
    public int? Autre { get; set; }

    [DataMember()]
    public int? Orchestre { get; set; }

    [DataMember()]
    public int? Balcon { get; set; }

    [DataMember()]
    public int? Corbeille { get; set; }

    [DataMember()]
    public int OrchestreDistribue { get; set; } = 0;

    [DataMember()]
    public int BalconDistribue { get; set; } = 0;

    [DataMember()]
    public int CorbeilleDistribue { get; set; } = 0;

    [DataMember()]
    public int? PresseOuestOrchestre { get; set; }

    [DataMember()]
    public int? PresseEstOrchestre { get; set; }

    [DataMember()]
    public int? BadgeOuestOrchestre { get; set; }

    [DataMember()]
    public int? BadgeEstOrchestre { get; set; }

    [DataMember()]
    public int? AutreOuestOrchestre { get; set; }

    [DataMember()]
    public int? AutreEstOrchestre { get; set; }

    [DataMember()]
    public int? PresseOuestBalcon { get; set; }

    [DataMember()]
    public int? PresseEstBalcon { get; set; }

    [DataMember()]
    public int? BadgeOuestBalcon { get; set; }

    [DataMember()]
    public int? BadgeEstBalcon { get; set; }

    [DataMember()]
    public int? AutreOuestBalcon { get; set; }

    [DataMember()]
    public int? AutreEstBalcon { get; set; }

    //public int? NbEntrees
    //{
    //  get
    //  {
    //    if (Presse == null && Badge == null && Autre == null)
    //      return default(Integer?);
    //    else
    //      return System.Convert.ToInt32(Interaction.IIf(Presse == null, 0, Presse)) + System.Convert.ToInt32(Interaction.IIf(Badge == null, 0, Badge)) + System.Convert.ToInt32(Interaction.IIf(Autre == null, 0, Autre));
    //  }
    //}

    public int? NbImpressions { get; set; }

    public int? NbBowling
    {
      get
      {
        int _Nb;
        _Nb = System.Convert.ToInt32(Interaction.IIf(PresseOuestOrchestre == null, 0, PresseOuestOrchestre)) + System.Convert.ToInt32(Interaction.IIf(PresseEstOrchestre == null, 0, PresseEstOrchestre)) + System.Convert.ToInt32(Interaction.IIf(BadgeOuestOrchestre == null, 0, BadgeOuestOrchestre));
        _Nb += System.Convert.ToInt32(Interaction.IIf(BadgeEstOrchestre == null, 0, BadgeEstOrchestre)) + System.Convert.ToInt32(Interaction.IIf(AutreOuestOrchestre == null, 0, AutreOuestOrchestre)) + System.Convert.ToInt32(Interaction.IIf(AutreEstOrchestre == null, 0, AutreEstOrchestre));
        _Nb += System.Convert.ToInt32(Interaction.IIf(PresseOuestBalcon == null, 0, PresseOuestBalcon)) + System.Convert.ToInt32(Interaction.IIf(PresseEstBalcon == null, 0, PresseEstBalcon)) + System.Convert.ToInt32(Interaction.IIf(BadgeOuestBalcon == null, 0, BadgeOuestBalcon));
        _Nb += System.Convert.ToInt32(Interaction.IIf(BadgeEstBalcon == null, 0, BadgeEstBalcon)) + System.Convert.ToInt32(Interaction.IIf(AutreOuestBalcon == null, 0, AutreOuestBalcon)) + System.Convert.ToInt32(Interaction.IIf(AutreEstBalcon == null, 0, AutreEstBalcon));
        return _Nb;
      }
    }
  }

  [Serializable]
  [DataContract]
  public class StatutTechniqueData
  {
    [DataMember()]
    public string IdStatutTechnique { get; set; }

    [DataMember()]
    public string Libelle { get; set; }
  }


  [Serializable]
  [DataContract]
  public class TypeAccesData
  {
    [DataMember()]
    public string IdTypeAcces { get; set; }

    [DataMember()]
    public string TypeAcces { get; set; }
  }
}