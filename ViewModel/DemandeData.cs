using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class DemandeData
  {
 

    [System.ComponentModel.Description("Identifiant=IdDemande")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$IdAccreditation")]
    [DataMember()]
    public int? IdAccreditation { get; set; }

    [System.ComponentModel.Description("$$IdAccreditation2")]
    [DataMember()]
    public int? IdAccreditation2 { get; set; }

    [System.ComponentModel.Description("$$IdProjection")]
    [DataMember()]
    public int IdProjection { get; set; }

    [System.ComponentModel.Description("$$IdFilm")]
    [DataMember()]
    public int IdFilm { get; set; }

    [System.ComponentModel.Description("Date Demande=DateDemande")]
    [DataMember()]
    public DateTime? DateDemande { get; set; }

    [System.ComponentModel.Description("Source=Source")]
    [DataMember()]
    public string Source { get; set; }

    [System.ComponentModel.Description("Code Statut billet=IdStatut")]
    [DataMember()]
    public string CodeStatut { get; set; }

    [System.ComponentModel.Description("Statut billet=bStatuts")]
    [DataMember()]
    public StatutDemandeData Statut { get; set; }

    [System.ComponentModel.Description("Résultat=Resultat")]
    [DataMember()]
    public string Resultat { get; set; }

    [System.ComponentModel.Description("$$IdOrganisation")]
    [DataMember()]
    public int? IdOrganisation { get; set; }

    [System.ComponentModel.Description("QBD (Qté billets Demandée)=QuantiteDemandee")]
    [DataMember()]
    public int? QuantiteDemandee { get; set; }

    [System.ComponentModel.Description("QBA (Qté billets Attribuée)=QuantiteAttribuee")]
    [DataMember()]
    public int? QuantiteAttribuee { get; set; }

    [System.ComponentModel.Description("QBI (Qté billets Imprimée)=QuantiteDistribuee")]
    [DataMember()]
    public int? QuantiteDistribuee { get; set; }

    [System.ComponentModel.Description("Note=Note")]
    [DataMember()]
    public int Note { get; set; }

    [System.ComponentModel.Description("Explications=Explications")]
    [DataMember()]
    public string Explications { get; set; }

    [System.ComponentModel.Description("Simulation ?=Simulation")]
    [DataMember()]
    public bool Simulation { get; set; }

    [System.ComponentModel.Description("Confirmé ?=Confirme")]
    [DataMember()]
    public bool Confirme { get; set; }

    // <System.ComponentModel.Description("Tirage ?=Tirage")>
    // <DataMember()>
    // Property Tirage As Boolean

    // <System.ComponentModel.Description("$$IdCampagne")>
    // <DataMember()>
    // Property IdCampagne As Integer?

    [System.ComponentModel.Description("Position=Position")]
    [DataMember()]
    public int? Position { get; set; }

    [System.ComponentModel.Description("Code Statut Diner=IdStatutDiner")]
    [DataMember()]
    public string IdStatutDiner { get; set; }


    public StatutDemandeDinerData StatutDiner { get; set; }

    [System.ComponentModel.Description("QDD (Qté diner Demandée)=QuantiteDiner")]
    [DataMember()]
    public int? QuantiteDiner { get; set; }

    [System.ComponentModel.Description("QDA (Qté diner Attribuée)=QuantiteDinerAttribuee")]
    [DataMember()]
    public int? QuantiteDinerAttribuee { get; set; }

    [System.ComponentModel.Description("$$DinerAttribueePar")]
    [DataMember()]
    public int? DinerAttribuePar { get; set; }

    [System.ComponentModel.Description("Diner attribué par")]
    [DataMember()]
    public string DinerUtilisateurAttribuePar { get; set; }

    [System.ComponentModel.Description("Diner date réponse=DinerDateReponse")]
    [DataMember()]
    public DateTime? DinerDateReponse { get; set; }

    [System.ComponentModel.Description("Diner date contrôle=DinerDateControle")]
    [DataMember()]
    public DateTime? DinerDateControle { get; set; }

    [System.ComponentModel.Description("Billet?=Billet")]
    [DataMember()]
    public bool IsBillet { get; set; } = true;

    [System.ComponentModel.Description("Diner?=Diner")]
    [DataMember()]
    public bool IsDiner { get; set; } = false;


    public PersonneData Personne { get; set; }
    public AccreditationData Accreditation { get; set; }

    public BilletData Billets { get; set; }

    public FilmData Film { get; set; }

    public ProgramSeanceData Projection { get; set; }
  }


  [DataContract()]
  public class StatutDemandeData
  {
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Statut=Statut")]
    [DataMember()]
    public string Statut { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }
  }

  [DataContract()]
  public class StatutDemandeDinerData
  {
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Statut=Statut")]
    [DataMember()]
    public string Statut { get; set; }
  }


  [DataContract()]
  public class DemandeNoteData
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public int Points { get; set; }
    [DataMember()]
    public string Libelle { get; set; }
    [DataMember()]
    public string Sql { get; set; }
  }

  [DataContract()]
  public class DemandeCampagneData
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public int? IdOrganisation { get; set; }

    [DataMember()]
    public int? IdCampagne { get; set; }

    [DataMember()]
    public bool EBillet { get; set; } = false;

    [DataMember()]
    public string IdStatut { get; set; }
  }

  [DataContract()]
  public class BilletFaqData
  {
    [DataMember()]
    public int? IdFaq { get; set; }

    [DataMember()]
    public int? Ordre { get; set; }

    [DataMember()]
    public string TitreFr { get; set; }

    [DataMember()]
    public string TitreUs { get; set; }

    [DataMember()]
    public string TexteFr { get; set; }

    [DataMember()]
    public string TexteUs { get; set; }
  }

  [DataContract()]
  public class BilletInfoData
  {
    [DataMember()]
    public int? IdInfo { get; set; }

    [DataMember()]
    public DateTime DateModification { get; set; }

    [DataMember()]
    public string TypeInfo { get; set; }

    [DataMember()]
    public DateTime? Debut { get; set; }

    [DataMember()]
    public DateTime? Fin { get; set; }

    [DataMember()]
    public string TitreFr { get; set; }

    [DataMember()]
    public string TitreUs { get; set; }

    [DataMember()]
    public string TexteFr { get; set; }

    [DataMember()]
    public string TexteUs { get; set; }
  }
}
