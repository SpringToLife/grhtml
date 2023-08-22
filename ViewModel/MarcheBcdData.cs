using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace GrapesJsEditorHtml.ViewModel
{
  public class MarcheStatutBdcData
  {
    [Description("$$IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [Description("$$Visible?=IdStatut")]
    [DataMember()]
    public bool Visible { get; set; }

    [Description("Statut=Statut")]
    [DataMember()]
    public string Statut { get; set; }

    [Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [Description("$$IdCampagne")]
    [DataMember()]
    public int? IdCampagne { get; set; }

    [Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [Description("$$Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [Description("$$Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [Description("$$Libellé Multiple Fr=LibelleMultipleFr")]
    [DataMember()]
    public string LibelleMultipleFr { get; set; }

    [Description("$$Libellé Multiple Us=LibelleMultipleUs")]
    [DataMember()]
    public string LibelleMultipleUs { get; set; }

    [Description("$$Libellé bouton Fr=LibelleFr")]
    [DataMember()]
    public string LibelleBoutonFr { get; set; }

    [Description("$$Libellé bouton Us=LibelleUs")]
    [DataMember()]
    public string LibelleBoutonUs { get; set; }
  }

  [DataContract()]
  public class MarcheBdcData
  {
    
    [Description("Id. Bdc=IdBdc")]
    [DataMember()]
    public int? IdBdc { get; set; }

    [System.ComponentModel.Description("$$IdUtilisateurModification=IdUtilisateurModification")]
    [DataMember()]
    public int? IdUtilisateurModification { get; set; }

    [Description("Date de Modification=DateModification")]
    [DataMember()]
    public DateTime? DateModification { get; set; }

    [Description("Date Création=DateCreation")]
    [DataMember()]
    public DateTime? DateCreation { get; set; }

    [Description("Date BDCA=DateBdca")]
    [DataMember()]
    public DateTime? DateBdca { get; set; }

    // <Description("$$IdPersonne")>
    // <DataMember()>
    // Property IdPersonne As Integer?

    [Description("$$IdSociete")]
    [DataMember()]
    public int? IdSociete { get; set; }

    [Description("$$IdOperation")]
    [DataMember()]
    public int? IdOperation { get; set; }

    [Description("Opération")]
    [DataMember()]
    public OperationData Operation { get; set; }

    [Description("$$Reglement")]
    [DataMember()]
    public OperationData Reglement { get; set; }

    [Description("Société=Societes")]
    [DataMember()]
    public SocieteData Societe { get; set; }

    [Description("Année=Annee")]
    [DataMember()]
    public string Annee { get; set; }

    [Description("Code Statut=IdStatut")]
    [DataMember()]
    public string StatutBdc { get; set; }

    [Description("Statut=mStatutsBdc")]
    [DataMember()]
    public MarcheStatutBdcData Statut { get; set; }

    [Description("$$Projections")]
    [IgnoreDataMember]
    public List<MarcheProjectionData> Projections { get; set; }
  }
}
