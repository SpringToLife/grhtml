using System.ComponentModel;
using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class MailerConfigData
  {
    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public string Nom { get; set; }

    [DataMember()]
    public string SmtpServeur { get; set; }

    [DataMember()]
    public string SmtpLogin { get; set; }

    [DataMember()]
    public string SmtpPassword { get; set; }

    [DataMember()]
    public int SmtpPort { get; set; }

    [DataMember()]
    public bool SmtpSSL { get; set; }

    [DataMember()]
    public string PopServeur { get; set; }

    [DataMember()]
    public string PopLogin { get; set; }

    [DataMember()]
    public string PopPassword { get; set; }

    [DataMember()]
    public int PopPort { get; set; }

    [DataMember()]
    public string FieldEmail { get; set; }

    [DataMember()]
    public string FieldAdresse { get; set; }

    [DataMember()]
    public string FieldDesabonnement { get; set; }

    [DataMember()]
    public int? IdListeType { get; set; }

    [DataMember()]
    public bool UseApiOffice { get; set; }

    [DataMember()]
    public ListeTypeData ListeType { get; set; }

    [DataMember()]
    public string Url { get; set; }

    [DataMember()]
    public string UrlDesabonnement { get; set; }

    [DataMember()]
    public bool Splio { get; set; }
  }
  public class MailerCampagneData
  {
    [System.ComponentModel.Description("$$Librairie")]
    public string Library { get; set; } = "Services.Mailer.MailerClient, Services";

    [System.ComponentModel.Description("$$LibrairieDirecte")]
    public string LibraryDirect { get; set; } = "WcfServiceL.Mailer, WcfService";

    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public DateTime DateCreation { get; set; }

    [DataMember()]
    public string Annee { get; set; }

    [DataMember()]
    public DateTime DateModification { get; set; }

    [System.ComponentModel.Description("$$IdUtilisateurModification")]
    [DataMember()]
    public int? IdUtilisateurModification { get; set; }

    [System.ComponentModel.Description("Modifié par")]
    [DataMember()]
    public UtilisateurData UtilisateurModification { get; set; }

    [System.ComponentModel.Description("$$IdUtilisateurCreation")]
    [DataMember()]
    public int? IdUtilisateurCreation { get; set; }

    [System.ComponentModel.Description("Créé par")]
    [DataMember()]
    public UtilisateurData UtilisateurCreation { get; set; }

    [System.ComponentModel.Description("$$IdEvenement")]
    [DataMember()]
    public int? IdEvenement { get; set; }

    [System.ComponentModel.Description("$$FieldDateEnvoi")]
    [DataMember()]
    public string FieldDateEnvoi { get; set; }

    [System.ComponentModel.Description("$$IdCategorie")]
    [DataMember()]
    public int? IdCategorie { get; set; }

    [System.ComponentModel.Description("Emetteur")]
    [DataMember()]
    public string Emetteur { get; set; }

    [System.ComponentModel.Description("Catégorie")]
    [DataMember()]
    public string Categorie { get; set; }

    [DataMember()]
    public int? IdCampagneSuivante { get; set; }

    [DataMember()]
    public string TypeMailing { get; set; }

    [DataMember()]
    public string Nom { get; set; }

    [DataMember()]
    public string Code { get; set; }

    [DataMember()]
    public string Expediteur { get; set; }

    [DataMember()]
    public string ExpediteurUs { get; set; }

    [DataMember()]
    public string EmailExpediteur { get; set; }

    [DataMember()]
    public string EmailRetour { get; set; }

    [DataMember()]
    public string EmailCci { get; set; }

    [DataMember()]
    public List<string> EmailTest { get; set; }

    [DataMember()]
    public string EmailTestString
    {
      get
      {
        if (EmailTest == null || EmailTest.Count == 0)
        {
          return "";
        }
        else
        {
          return string.Join(";", EmailTest);
        }
      }
      set
      {
        EmailTest = new List<string>();
        if (value != null)
        {
          EmailTest = value.Split(';').ToList();
        }
      }
    }

    [DataMember()]
    public bool UniqueEmail { get; set; }

    [DataMember()]
    public bool Valide { get; set; }

    [DataMember()]
    public bool BloqueDesabonnement { get; set; }

    [DataMember()]
    public bool Automatique { get; set; }

    [DataMember()]
    public string Objet { get; set; }

    [DataMember()]
    public string Fichier { get; set; }

    [DataMember()]
    public List<MailerPiecesJointesData> PiecesJointes { get; set; }

    [DataMember()]
    public string TestLangue { get; set; }

    [DataMember()]
    public string ObjetUs { get; set; }

    [DataMember()]
    public string FichierUs { get; set; }

    [DataMember()]
    public List<MailerPiecesJointesData> PiecesJointesUs { get; set; }

    [DataMember()]
    public string TestLangueUs { get; set; }

    [DataMember()]
    public int NbEnreg { get; set; }

    [DataMember()]
    public int NbEnvoi { get; set; }

    [DataMember()]
    public int? IdConfig { get; set; }

    [DataMember()]
    public string Salon { get; set; }

    [DataMember()]
    public string Notes { get; set; }

    [DataMember()]
    public MailerConfigData Config { get; set; }

    [DataMember()]
    public List<MailerStatData> Stat { get; set; }
  }
  public class MailerStatData
  {
    public string Resultat { get; set; }
    public int Valeur { get; set; }
  }

  public class MailerPiecesJointesData
  {
    public int? Id { get; set; }
    public int? IdFichier { get; set; }
    public string IdLangue { get; set; }
    public string NomPublic { get; set; }
    public string NomPrive { get; set; }
  }

  public class MailerEmailingData
  {
    [System.ComponentModel.Description("Identifiant")]
    public int? IdEmailing { get; set; }

    [System.ComponentModel.Description("Id. Destinataire")]
    public int IdEnreg { get; set; }

    [System.ComponentModel.Description("$$IdCampagne")]
    public int? IdCampagne { get; set; }

    [System.ComponentModel.Description("Demandé le=DateDemande")]
    public DateTime? DateDemande { get; set; }

    [System.ComponentModel.Description("Envoyé le=DateEnvoi")]
    public DateTime? DateEnvoi { get; set; }

    [System.ComponentModel.Description("Analysé le")]
    public DateTime? DateAnalyse { get; set; }

    [System.ComponentModel.Description("Code résultat=Resultat")]
    public int? Resultat { get; set; }

    [System.ComponentModel.Description("Ordre")]
    public int? Ordre { get; set; }

    [System.ComponentModel.Description("Test?")]
    public bool IsTest { get; set; }

    [System.ComponentModel.Description("Expéditeur")]
    public string Expediteur { get; set; }

    public string Body { get; set; }

    public string Parametre { get; set; }

    [System.ComponentModel.Description("Envoyé à=AdresseEnvoye")]
    public string AdresseEnvoye { get; set; }

    [System.ComponentModel.Description("Destinataire")]
    public object Enreg { get; set; }

    [System.ComponentModel.Description("Résultat")]
    public string ResultatString { get; set; }

    [System.ComponentModel.Description("$$IdStatutFormulaire")]
    public int? IdStatutFormulaire { get; set; }

    [System.ComponentModel.Description("Statut Formulaire=StatutFormulaire")]
    public StatutFormulaireData StatutFormulaire { get; set; }

    [System.ComponentModel.Description("Date Retour=DateRetour")]
    public DateTime? DateRetour { get; set; }

    [System.ComponentModel.Description("Notes=Notes")]
    public string Notes { get; set; }

    [System.ComponentModel.Description("Source=Source")]
    public string Source { get; set; }
  }

  public class MailerCategorieData
  {
    public int? Id { get; set; }
    public string Categorie { get; set; }
  }
 
}
