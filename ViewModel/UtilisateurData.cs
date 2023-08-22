using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class UtilisateurData
  {
    [Description("$$Librairie")]
    [IgnoreDataMember]
    [DataMember]
    public string Library { get; set; } = "Services.Utilisateur.UtilisateurClient, Services";

    [Description("$$LibrairieDirecte")]
    [IgnoreDataMember]
    [DataMember]
    public string LibraryDirect { get; set; } = "WcfService.Utilisateur, WcfService";

    [DataMember]
    public int? Id { get; set; }

    [DataMember]
    public string Nom { get; set; }

    [DataMember]
    public string Guid { get; set; }

    [DataMember]
    public DateTime DernierAcces { get; set; }

    [DataMember]
    public List<int> Organisations { get; set; }

    [DataMember]
    public string AdLogin { get; set; }

    [DataMember]
    public string AdPassword { get; set; }

    [DataMember]
    public string GroupePrincipal { get; set; }

    [DataMember]
    public List<string> Groupes { get; set; }

    [DataMember]
    public string Emetteur { get; set; }

    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public string MotDePasse { get; set; }

    [DataMember]
    public bool Actif { get; set; } = true;

    [DataMember]
    public bool NotificationActif { get; set; } = false;

    [DataMember]
    public string Salon { get; set; }

    [DataMember]
    public int? IdSuperieur { get; set; }

    [DataMember]
    public DateTime? DateExpiration { get; set; }
  }

  [DataContract]
  public class GroupeAffectationData
  {
    [DataMember]
    public int? Id { get; set; }

    [DataMember]
    public string Groupe { get; set; }

    [DataMember]
    public int? IdOrganisation { get; set; }
  }

  [DataContract]
  public class DroitData
  {
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Libelle { get; set; }

    [DataMember]
    public string Groupes { get; set; }
  }

  [DataContract]
  public class UtilisateurGroupeData
  {
    [DataMember]
    public int? IdUtilisateur { get; set; }

    [DataMember]
    public string Libelle { get; set; }

    [DataMember]
    public bool GroupePrincipal { get; set; } = false;

    [DataMember]
    public bool Visible { get; set; } = true;
  }

  [DataContract]
  public class PropertyDroitData
  {
    [DataMember]
    public int? IdDroit { get; set; }

    [DataMember]
    public string Objet { get; set; }

    [DataMember]
    public string Propriete { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public string GroupesAutorises { get; set; }

    [DataMember]
    public string GroupesRefuses { get; set; }
  }

  [DataContract]
  public class GroupeData
  {
    [DataMember]
    public int? IdGroupe { get; set; }

    [DataMember]
    public string Groupe { get; set; }
  }
}
