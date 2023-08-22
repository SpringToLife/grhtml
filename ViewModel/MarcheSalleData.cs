using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class MarcheSalleData
  {
    [System.ComponentModel.Description("$$Librairie")]
    [IgnoreDataMember]
    public string Library { get; set; } = "Services.MarcheSalle.MarcheSalleClient, Services";

    [System.ComponentModel.Description("$$LibrairieDirecte")]
    [IgnoreDataMember]
    public string LibraryDirect { get; set; } = "WcfService.MarcheSalle, WcfService";

    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$IdCinando")]
    [DataMember()]
    public int? IdCinando { get; set; }

    [System.ComponentModel.Description("$$IdSalleOnline")]
    [DataMember()]
    public int? IdSalleOnline { get; set; }

    [System.ComponentModel.Description("Nom=Nom")]
    [DataMember()]
    public string Nom { get; set; }

    [System.ComponentModel.Description("Nom court=NomCourt")]
    [DataMember()]
    public string NomCourt { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int? Ordre { get; set; }

    [System.ComponentModel.Description("Online?=Online")]
    [DataMember()]
    public string Online { get; set; }

    [System.ComponentModel.Description("Extérieur=Exterieur")]
    [DataMember()]
    public bool Exterieur { get; set; } = false;

    [System.ComponentModel.Description("Archivé?=Archive")]
    [DataMember()]
    public bool Archive { get; set; } = false;

    [System.ComponentModel.Description("Visible Créneaux?=Visible")]
    [DataMember()]
    public bool Visible { get; set; } = true;

    [System.ComponentModel.Description("Visible FO?=VisibleFO")]
    [DataMember()]
    public bool VisibleFO { get; set; } = true;

    [System.ComponentModel.Description("Visible BO?=VisibleBO")]
    [DataMember()]
    public bool VisibleBO { get; set; } = true;

    [System.ComponentModel.Description("Nb.Sieges=NbSieges")]
    [DataMember()]
    public int? NbSieges { get; set; }

    [System.ComponentModel.Description("Ecran=Ecran")]
    [DataMember()]
    public string Ecran { get; set; }

    [System.ComponentModel.Description("Image=Image")]
    [DataMember()]
    public string Image { get; set; }

    [System.ComponentModel.Description("Son=Son")]
    [DataMember()]
    public string Son { get; set; }

    [System.ComponentModel.Description("3D?=Relief")]
    [DataMember()]
    public bool Relief { get; set; }

    [System.ComponentModel.Description("Nb.Invitations=NbInvitations")]
    [DataMember()]
    public int NbInvitations { get; set; } = 0;

    [System.ComponentModel.Description("$$IdCinema")]
    [DataMember()]
    public int? IdCinema { get; set; }

    [System.ComponentModel.Description("Cinéma=mCinemas")]
    [DataMember()]
    public MarcheCinemaData Cinema { get; set; }

    [System.ComponentModel.Description("Tarif=Tarif")]
    [DataMember()]
    public string Tarif { get; set; }

    [System.ComponentModel.Description("TarifUs=TarifUs")]
    [DataMember()]
    public string TarifUs { get; set; }

    [System.ComponentModel.Description("$$IdAnalytique")]
    [DataMember()]
    public int? IdAnalytique { get; set; }

    [System.ComponentModel.Description("Créneaux")]
    [DataMember()]
    public List<string> Creneaux { get; set; }
  }

  [DataContract()]
  public class MarcheCreneauData
  {
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$IdSalle")]
    [DataMember()]
    public int IdSalle { get; set; }

    [System.ComponentModel.Description("Jour")]
    [DataMember()]
    public int Jour { get; set; }

    [System.ComponentModel.Description("$$Date")]
    [DataMember()]
    public DateTime DateCreneau { get; set; }

    [System.ComponentModel.Description("Créneau=Creneau")]
    [DataMember()]
    public int Creneau { get; set; }

    [System.ComponentModel.Description("Heure=Heure")]
    [DataMember()]
    public string Heure { get; set; }

    [System.ComponentModel.Description("Prix=Prix")]
    [DataMember()]
    public double? Prix { get; set; }

    [System.ComponentModel.Description("Bloqué?=Bloque")]
    [DataMember()]
    public bool Bloque { get; set; } = false;

    [System.ComponentModel.Description("Réservé?=Reserve")]
    [DataMember()]
    public bool Reserve { get; set; } = false;

    [System.ComponentModel.Description("Validé?=AnneeCheck")]
    [DataMember()]
    public string AnneeCheck { get; set; }
  }

  [DataContract()]
  public class MarcheCinemaData
  {
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public int? IdCinema { get; set; }

    [System.ComponentModel.Description("Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; } = true;

    [System.ComponentModel.Description("Nom=Nom")]
    [DataMember()]
    public string Nom { get; set; }

    [System.ComponentModel.Description("Localisation=Localisation")]
    [DataMember()]
    public string Localisation { get; set; }
  }

}
