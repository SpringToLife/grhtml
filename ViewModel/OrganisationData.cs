using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class OrganisationData
  {
    
    [Key]
    public int? IdOrganisation { get; set; } = null;

    /// <summary>
    /// Identifiant de l'organisation maitre
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("$$IdMaitre")]
    [DataMember()]
    public int? IdMaitre { get; set; }

    /// <summary>
    /// Organisation maitre
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Maitre")]
    [DataMember()]
    public OrganisationData Maitre { get; set; }

    [System.ComponentModel.Description("Groupe=Groupe")]
    [DataMember()]
    public string Groupe { get; set; }

    [System.ComponentModel.Description("Nom maitre=MaitreNom")]
    [DataMember()]
    public string MaitreNom { get; set; }

    /// <summary>
    /// Nom public de l'organisation
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Nom=Nom")]
    [DataMember()]
    public string Nom { get; set; }

    [System.ComponentModel.Description("Nom court=NomCourt")]
    [DataMember()]
    public string NomCourt { get; set; }

    /// <summary>
    /// Indique si l'organisation doit être présente sur les affichages
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; } = true;

    [System.ComponentModel.Description("Réservoir?=Reservoir")]
    [DataMember()]
    public bool Reservoir { get; set; }

    /// <summary>
    /// Indique si les billets de l'organisation peuvent être réservés en ligne
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Réserve en ligne?=ReservationEnLigne")]
    [DataMember()]
    public bool ReservationEnLigne { get; set; } = false;

    [System.ComponentModel.Description("Réserve sur son Quota?=ReserveSurSonQuota")]
    [DataMember()]
    public bool ReserveSurSonQuota { get; set; } = false;

    //[System.ComponentModel.Description("Tirage?=Tirage")]
    //[DataMember()]
    //public bool Tirage { get; set; } = false;

    [System.ComponentModel.Description("Demande?=Demande")]
    [DataMember()]
    public bool Demande { get; set; } = false;

    [System.ComponentModel.Description("Informatique?=Informatique")]
    [DataMember()]
    public bool Informatique { get; set; }

    [System.ComponentModel.Description("Imprimer billet?=ImprimerBillet")]
    [DataMember()]
    public bool ImprimerBillet { get; set; } = false;

    [System.ComponentModel.Description("Réserve billet?=ReserverBillet")]
    [DataMember()]
    public bool ReserverBillet { get; set; } = false;

    [System.ComponentModel.Description("Quota réservé?=QuotaReserve")]
    [DataMember()]
    public bool QuotaReserve { get; set; } = false;

    //[System.ComponentModel.Description("E-billet?=Ebillet")]
    //[DataMember()]
    //public bool Ebillet { get; set; } = false;

    //[System.ComponentModel.Description("E-billet phase 3?=EbilletTardif")]
    //[DataMember()]
    //public bool EbilletTardif { get; set; } = false;

    /// <summary>
    /// 1ère ligne affiché sur le billet pour le nom de l'organisation
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("1ère ligne=LibelleBillet1")]
    [DataMember()]
    public string LibelleBillet1 { get; set; }

    /// <summary>
    /// 2ème ligne affiché sur le billet pour le nom de l'organisation
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("2ème ligne=LibelleBillet2")]
    [DataMember()]
    public string LibelleBillet2 { get; set; }

    /// <summary>
    /// Code affiché sur les billets
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Code=Code")]
    [DataMember()]
    public string Code { get; set; }

    /// <summary>
    /// Couleur utilisée lors des affichages
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    /// <summary>
    /// Nom et emplacement du contact de l'organisation
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Contact=Contact")]
    [DataMember()]
    public string Contact { get; set; }

    [System.ComponentModel.Description("Nb. jours visible=NbJoursVisibles")]
    [DataMember()]
    public int NbJoursVisibles { get; set; } = 2;

    /// <summary>
    /// Nombre de places disponibles par personne pour la réservation en ligne
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Nb. place/pers=NbPlacesParPersonne")]
    [DataMember()]
    public int NbPlacesParPersonne { get; set; } = 1;

    /// <summary>
    /// Indique si le nombre de places disponibles en réservation est égal à 2 si le festival a un accompagnant
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Nb. billets auto.?=NbBilletsAuto")]
    [DataMember()]
    public bool NbBilletsAuto { get; set; } = false;

    /// <summary>
    /// Date de dernière modification
    /// </summary>
    /// <remarks></remarks>
    [System.ComponentModel.Description("Date modification=DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    [System.ComponentModel.Description("Année=Annee")]
    [DataMember()]
    public string Annee { get; set; }

    //[System.ComponentModel.Description("Taille file d'attente=TailleFile")]
    //[DataMember()]
    //public int? TailleFile { get; set; }

    [System.ComponentModel.Description("Salles")]
    [DataMember()]
    public BindingList<OrganisationSalleData> Salles { get; set; }

    [System.ComponentModel.Description("Groupes=Groupes")]
    [DataMember()]
    public string Groupes { get; set; }

    [System.ComponentModel.Description("Multiple?=Multiple")]
    [DataMember()]
    public bool Multiple { get; set; }

    [System.ComponentModel.Description("Filtre=Filtre")]
    [DataMember()]
    public string Filtre { get; set; }
  }

  public class OrganisationSalleData
  {
    [DataMember()]
    public int? Id { get; set; }
    [Key]
    /// <summary>
    /// Identifiant de l'organisation
    /// </summary>
    /// <remarks></remarks>
    [DataMember()]
    public int IdOrganisation { get; set; }

    [DataMember()]
    public int IdSalle { get; set; }

    [DataMember()]
    public SalleData Salle { get; set; }

    [DataMember()]
    public bool Enabled { get; set; }

    //[DataMember()]
    //public string LibelleSalle
    //{
    //    get
    //    {
    //        return "oo";
    //        //    //      return (New Salle).Load(IdSalle).Libelle
  }
  [DataContract()]
  public class OrganisationSecteurData
  {
    [DataMember()]
    public int? Id { get; set; } 
    [DataMember()]
    public int IdOrganisation { get; set; }
    [DataMember()]
    public string IdSecteur { get; set; }
    [DataMember()]
    public int NbAccredites { get; set; }
  }

  [DataContract()]
  public class PartenaireData
  {
    [DataMember()]
    public int? Id { get; set; } 
    [DataMember()]
    public int IdOrganisation { get; set; }
    [DataMember()]
    public int? IdProjection { get; set; }
    [DataMember()]
    public string Nom { get; set; }
    [DataMember()]
    public string Couleur { get; set; }
    [DataMember()]
    public bool Visible { get; set; }
  }

  [DataContract()]
  public class BlocageSeanceData
  {
    [DataMember()]
    public int? Id { get; set; } 

    [DataMember()]
    public int IdOrganisation { get; set; }

    [DataMember()]
    public int? IdProjection { get; set; }

    [DataMember()]
    public string Annee { get; set; }
  }


}
