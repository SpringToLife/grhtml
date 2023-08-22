using GrapesJsEditorHtml.ViewModel;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{

  public class CompteData
  {


    [Description("Identifiant=IdCompte")]
    [DataMember]
    [Key]
    public string IdCompte { get; set; }

    [Description("Id.Externe=IdExterne")]
    [DataMember]
    public string IdExterne { get; set; }

    [Description("$$IdPersonne")]
    [DataMember]
    public int IdPersonne { get; set; }

    [Description("$$IdCinando")]
    [DataMember]
    public int? IdCinando { get; set; }

    public PersonneData Personnes { get; set; }
    public OrganisationAccredData Organisation { get; set; }

    [Description("Login=Login")]
    [DataMember]
    public string Login { get; set; }

    [Description("Password=Password")]
    [DataMember]
    public string Password { get; set; }

    [Description("$$IdUtilisateurModification")]
    [DataMember]
    public int IdUtilisateurModification { get; set; }

    [Description("Date de Modification=DateModification")]
    [DataMember]
    public DateTime DateModification { get; set; }

    [Description("A Synchroniser=Synchroniser")]
    [DataMember]
    public bool Synchroniser { get; set; }

    [Description("Code Etat=Etat")]
    [DataMember]
    public string Etat { get; set; }

    [Description("Etat Cinando=EtatCinando")]
    [DataMember]
    public string EtatCinando { get; set; }

    [Description("Nb. Accès=NbAcces")]
    [DataMember]
    public int NbAcces { get; set; }

    [Description("Dernier accès=DernierAcces")]
    [DataMember]
    public DateTime? DernierAcces { get; set; }

    public CompteEtatData Etats { get; set; }

    [Description("Compte Organisation?")]
    [DataMember]
    public bool CompteOrga { get; set; }

    [Description("$$IdOrganisation")]
    [DataMember]
    public string IdOrganisation { get; set; }

    [Description("$$IdOrganisation2")]
    [DataMember]
    public string IdOrganisation2 { get; set; }

    [Description("$$IdOrganisation3")]
    [DataMember]
    public string IdOrganisation3 { get; set; }

    [Description("Id.Soif=IdSoif")]
    [DataMember]
    public string IdSoif { get; set; }

    [Description("Roles=Roles")]
    [DataMember]
    public string Roles { get; set; }

    [Description("$$IdOperation")]
    [DataMember]
    public int? Compte_IdOperation { get; set; }

    //[Description("$$Opération")]
    //[DataMember]
    //public OperationData Operation { get; set; }

    //[Description("$$Transaction")]
    //[DataMember]
    //public TransactionData Transaction { get; set; }
  }
  public class CompteEtatData
  {

    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    [Key]
    public string ComptesEtats_IdCompteEtat { get; set; }

    [System.ComponentModel.Description("Compte état.Libellé=Libelle")]
    [DataMember()]
    public string ComptesEtats_Libelle { get; set; }

    [System.ComponentModel.Description("Compte état.Action=ComptesEtats_Action")]
    [DataMember()]
    public string ComptesEtats_Action { get; set; }
  }


}




