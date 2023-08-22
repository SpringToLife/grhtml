using Microsoft.VisualBasic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class BilletData { 

  [System.ComponentModel.Description("Identifiant=IdBillet")]
  [DataMember()]
  public int? Id { get; set; }

  /// <summary>
  ///   ''' Session du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Année=Annee")]
  [DataMember()]
  public string Annee { get; set; }


  [System.ComponentModel.Description("$$IdProjection")]
  [DataMember()]
  public int? IdProjection { get; set; }

  [System.ComponentModel.Description("$$IdOrganisation")]
  [DataMember()]
  public int? IdOrganisation { get; set; }

  [System.ComponentModel.Description("$$IdPartenaire")]
  [DataMember()]
  public int? IdPartenaire { get; set; }

  [System.ComponentModel.Description("Valeur=Valeur")]
  [DataMember()]
  public int Valeur { get; set; }

  [System.ComponentModel.Description("PMR?=PMR")]
  [DataMember()]
  public bool? PMR { get; set; }

  [System.ComponentModel.Description("$$Printing")]
  [DataMember()]
  public bool Printing { get; set; } = false;

  [System.ComponentModel.Description("$$IdDemande")]
  [DataMember()]
  public int? IdDemande { get; set; }

  [System.ComponentModel.Description("$$IdMedia")]
  [DataMember()]
  public int? IdMedia { get; set; }


  [System.ComponentModel.Description("Organisation=OrganisationBillet")]
  [DataMember()]
  public OrganisationData Organisation { get; set; }

  [System.ComponentModel.Description("Partenaire")]
  [DataMember()]
  public PartenaireData Partenaire { get; set; }

  /// <summary>
  ///   ''' Identifiant de l'organisation originale du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdOrganisationOriginale")]
  [DataMember()]
  public int? IdOrganisationOriginale { get; set; }

  /// <summary>
  ///   ''' Organisation originale du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Organisation Originale=OrganisationOriginaleBillet")]
  [DataMember()]
  public OrganisationData OrganisationOriginale { get; set; }

  /// <summary>
  ///   ''' Identifiant de la zone de placement dans la salle
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdZone")]
  [DataMember()]
  public int? IdZone { get; set; }

  [System.ComponentModel.Description("Zone=bZones")]
  [DataMember()]
  public ZoneData Zone { get; set; }

  /// <summary>
  ///   ''' Festivalier ayant le billet
  ///   ''' </summary>
  ///   ''' <value></value>
  ///   ''' <returns></returns>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("IdDetenteur=Id. Personne")]
  [DataMember()]
  public int? IdDetenteur { get; set; }

  [System.ComponentModel.Description("Detenteur=Personnes")]
  [DataMember()]
  public PersonneData Detenteur { get; set; }

  [System.ComponentModel.Description("$$IdCouleur")]
  [DataMember()]
  public int? IdCouleur { get; set; }

  [System.ComponentModel.Description("Couleur=bCouleursBillets")]
  [DataMember()]
  public CouleurData Couleur { get; set; }

  /// <summary>
  ///   ''' Date de modification
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Date Modification=DateModification")]
  [DataMember]
  public DateTime? DateModification { get; set; }

  /// <summary>
  ///   ''' Date de création de l'enregistrement
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Date Génération=DateGeneration")]
  [DataMember]
  public DateTime? DateGeneration { get; set; }


  /// <summary>
  ///   ''' Date de réservation online du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Date Réservation=DateReservation")]
  [DataMember]
  public DateTime? DateReservation { get; set; }

  /// <summary>
  ///   ''' Date d'impression
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Date Impression=DateImpression")]
  [DataMember]
  public DateTime? DateImpression { get; set; }


  [System.ComponentModel.Description("$$Date Distribution=DateDistribution")]
  [DataMember]
  public DateTime? DateDistribution { get; set; }


  [System.ComponentModel.Description("Date Contrôle=DateControle")]
  [DataMember]
  public DateTime? DateControle { get; set; }


  [System.ComponentModel.Description("Date Annulation=DateAnnulation")]
  [DataMember]
  public DateTime? DateAnnulation { get; set; }

  [System.ComponentModel.Description("Motif Annulation=MotifAnnulation")]
  [DataMember]
  public string MotifAnnulation { get; set; }


  [System.ComponentModel.Description("$$IdUserGeneration")]
  [DataMember]
  public int? IdUserGeneration { get; set; }

  /// <summary>
  ///   ''' Identifiant de l'utilisateur ayant réservé le billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdUserReservation")]
  [DataMember]
  public int? IdUserReservation { get; set; }

  /// <summary>
  ///   ''' Identifiant de l'utilisateur ayant imprimé le billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdUserImpression")]
  [DataMember]
  public int? IdUserImpression { get; set; }

  /// <summary>
  ///   ''' version du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Nb. impression=NbImpression")]
  [DataMember]
  public int NbImpression { get; set; } = 0;

  /// <summary>
  ///   ''' Identifiant de l'utilisateur ayant distribué le billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdUserDistribution")]
  [DataMember]
  public int? IdUserDistribution { get; set; }

  /// <summary>
  ///   ''' Identifiant de l'utilisateur ayant controlé le billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdUserControle")]
  [DataMember]
  public int? IdUserControle { get; set; }

  /// <summary>
  ///   ''' Identifiant de l'utilisateur ayant annulé le billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdUserAnnulation")]
  [DataMember]
  public int? IdUserAnnulation { get; set; }

  /// <summary>
  ///   ''' Identifiant du billet annulé que ce billet remplace
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("$$IdBilletPrecedent")]
  [DataMember]
  public int? IdBilletPrecedent { get; set; }

  // <DataMember>
  // Property BilletPrecedent As BilletData

  // ''' <summary>
  // ''' Libelle d'impression de la zone du billet
  // ''' </summary>
  // ''' <remarks></remarks>
  // <DataMember>
  // Property LibelleZone As String

  /// <summary>
  ///   ''' Libelle d'impression de la zone identifiante du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Libellé=LibelleIdentifiant")]
  [DataMember]
  public string LibelleIdentifiant { get; set; }

  /// <summary>
  ///   ''' Libelle d'impression du fauteuil du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Fauteuil=LibelleFauteuil")]
  [DataMember]
  public string LibelleFauteuil { get; set; }

  [System.ComponentModel.Description("Place")]
  [DataMember]
  public string Place
  {
    get
    {
      if (LibelleFauteuil == null)
        return "";
      else if (Information.IsNumeric(LibelleFauteuil))
        return LibelleFauteuil.PadLeft(3, System.Convert.ToChar(" "));
      else if (Information.IsNumeric(LibelleFauteuil.Replace("Tv", "")))
        return "Tv" + LibelleFauteuil.Replace("Tv", "").PadLeft(2, System.Convert.ToChar(" "));
      else
        return LibelleFauteuil;
    }
    set
    {
      if (value == null)
        LibelleFauteuil = "";
      else
        LibelleFauteuil = value.Trim().Replace("  ", " ");
    }
  }

  /// <summary>
  ///   ''' Libelle d'impression du rang du billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Rang=LibelleRang")]
  [DataMember]
  public string LibelleRang { get; set; }

  /// <summary>
  ///   ''' Observations sur le billet
  ///   ''' </summary>
  ///   ''' <remarks></remarks>
  [System.ComponentModel.Description("Notes=Notes")]
  [DataMember]
  public string Notes { get; set; }

  [System.ComponentModel.Description("A Imprimer ?=AImprimer")]
  [DataMember]
  public bool AImprimer { get; set; }

  // <System.ComponentModel.Description("Electronique ?=Electronique")>
  // <DataMember>
  // Property Electronique As Boolean

  [System.ComponentModel.Description("Projection=dProgramSeance")]
  [DataMember]
  public ProgramSeanceData Projection { get; set; }

  [System.ComponentModel.Description("$$Dossier ebillet")]
  [DataMember]
  public string Fichier { get; set; }

  [System.ComponentModel.Description("$$Url ebillet")]
  [DataMember]
  public string Url { get; set; }

    public AccreditationData Accreditation { get; set; }
  }
  public class SelectionBillet
  {
    [DataMember]
    public int? IdOrganisation { get; set; }
    [DataMember]
    public int? IdTypeZone { get; set; }
    [DataMember]
    public bool? Reserve { get; set; }
    [DataMember]
    public int? IdZone { get; set; }
  }

  [DataContract()]
  public class CahierDistribData
  {
    [System.ComponentModel.Description("$$ReportData")]
    [IgnoreDataMember]
    public string ReportData { get; set; } = "GetCahier";

    [DataMember]
    public ProgramSeanceData Projection { get; set; }
    [DataMember]
    public string Nom { get; set; }
    [DataMember]
    public ZoneData Zone { get; set; }
    [DataMember]
    public int Nombre { get; set; }
    [DataMember]
    public OrganisationData Organisation { get; set; }
  }

}
