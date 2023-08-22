
using System.Runtime.Serialization;
namespace GrapesJsEditorHtml.ViewModel
{
  public class MainCouranteData
  {
    public class ReposData
    {
      [System.ComponentModel.Description("$$FIdUtilisateurSession")]
      public int? FIdUtilisateurSession { get; set; }

      public ReposData()
      {
      }
      public ReposData(int? IdUtilisateurSession)
      {
        FIdUtilisateurSession = IdUtilisateurSession;
      }
      public int DeepScan = 2;

      [System.ComponentModel.Description("$$Librairie")]
      public string Library { get; set; } = "WcfService.Planning, WcfService";

      public int? Id { get; set; }

      [System.ComponentModel.Description("Date repos")]
      public DateTime DateRepos { get; set; }

      [System.ComponentModel.Description("$$IdPersonne")]
      public int? IdPersonne { get; set; }

      [System.ComponentModel.Description("Personne")]
      public PersonneData Personne { get; set; }
    }

    // <Serializable>
    // <DataContract()>
    // Public Class PosteData
    // <System.ComponentModel.Description("$$FIdUtilisateurSession")>
    // Public Property FIdUtilisateurSession As Integer?

    // Public Sub New()
    // End Sub
    // Public Sub New(Optional IdUtilisateurSession As Integer? = Nothing)
    // FIdUtilisateurSession = IdUtilisateurSession
    // End Sub
    // Public DeepScan As Integer = 2

    // <System.ComponentModel.Description("$$Librairie")>
    // Public Property Library As String = "WcfService.Poste, WcfService"

    // <System.ComponentModel.Description("$$Id")>
    // Public Property Id As Integer?

    // <System.ComponentModel.Description("$$IdUtilisateurModification")>
    // Public Property IdUtilisateurModification As Integer?

    // <System.ComponentModel.Description("Modifié le")>
    // Public Property DateModification As Date?

    // <System.ComponentModel.Description("Note")>
    // Public Property Note As String

    // <System.ComponentModel.Description("$$IdPersonne")>
    // Public Property IdPersonne As Integer?

    // <System.ComponentModel.Description("$$IdBrigade")>
    // Public Property IdBrigade As Integer?

    // Public Property Brigade As String

    // <System.ComponentModel.Description("Année")>
    // Public Property Annee As String

    // <System.ComponentModel.Description("Synchro")>
    // Property Synchro As Boolean = False

    // <System.ComponentModel.Description("Ref. Poste")>
    // Public Property IdentifPoste As String

    // <System.ComponentModel.Description("Libellé")>
    // Public Property Libelle As String

    // <System.ComponentModel.Description("Mission")>
    // Public Property Mission As String

    // <System.ComponentModel.Description("Service")>
    // Public Property LibService As String

    // <System.ComponentModel.Description("Code Service")>
    // Public Property Service As String

    // <System.ComponentModel.Description("Groupe")>
    // Public Property Groupe As String

    // <System.ComponentModel.Description("Niveau")>
    // Public Property Niveau As String

    // <System.ComponentModel.Description("Série")>
    // Public Property Serie As String

    // <System.ComponentModel.Description("Recouvrement")>
    // Public Property Recouvrement As String

    // <System.ComponentModel.Description("N° Badge")>
    // Public Property NoBadge As String

    // <System.ComponentModel.Description("N° Badge 2")>
    // Public Property NoBadge2 As String

    // <System.ComponentModel.Description("N° Macaron 1")>
    // Public Property NoMacaron1 As String

    // <System.ComponentModel.Description("N° Macaron 2")>
    // Public Property NoMacaron2 As String

    // <System.ComponentModel.Description("Badges")>
    // Public Property Badges As String

    // <System.ComponentModel.Description("Libellés SurBadges")>
    // Public ReadOnly Property TypesSurBadges As String
    // Get
    // Dim _Type As String = Badges
    // If Badges <> "" Then
    // _Type = _Type.Replace("CLT2", "TECHNICIEN CLT LUMIERE N°")
    // _Type = _Type.Replace("CLE-", "OUVERTURE CANAL+ TOUS ACCES N°")
    // _Type = _Type.Replace("CLA-", "OUVERTURE ACCES PARVIS N°")
    // _Type = _Type.Replace("CLN-", "SOIREE DE CLOTURE CANAL+ TOUS ACCES N°")
    // _Type = _Type.Replace("CLS-", "DINER DE CLOTURE N°")
    // _Type = _Type.Replace("SEV-", "ESPACES VERTS  N°")
    // _Type = _Type.Replace("CLK-", "ACCES RESERVE INVITE FESTIVAL N°")
    // _Type = _Type.Replace("CLW-", "FESTIVAL ET MARCHE TOUS ACCES SALLE N°")
    // _Type = _Type.Replace("CLX-", "ZONE PARTENAIRES ACCES RESERVE N°")
    // _Type = _Type.Replace("CLJ-", "ORGANISATION FESTIVAL ACCES RESERVE N°")
    // _Type = _Type.Replace("CLF-", "OUVERTURE INVITES FESTIVAL ACCES RESERVE  N°")
    // _Type = _Type.Replace("CLL-", "COULOIR TECHNIQUE N°")
    // _Type = _Type.Replace("CLH-", "ACCES NUIT NIVEAU 01 ZONE EXPOSITION N°")
    // _Type = _Type.Replace("CLI-", "PERSONNELS AUTORISES ACCES RESERVE N°")
    // _Type = _Type.Replace("CL2-", "SOIREE DE CLOTURE FESTIVAL ET MARCHE TOUS ACCES SALLE N°")
    // _Type = _Type.Replace("PAL-", "PALAIS FESTIVAL DU FILM N°")
    // _Type = _Type.Replace("CLP-", "SOIREE DE CLOTURE ACCES PARVIS N°")
    // _Type = _Type.Replace("CLQ-", "SOIREE CLOTURE COULISSES N°")
    // _Type = _Type.Replace("CL1-", "GALA DE CLOTURE N°")
    // _Type = _Type.Replace("SIG-", "POLICE NATIONALE  N°")
    // _Type = _Type.Replace("PAN-", "SERVICE DE NETTOYAGE N°")
    // _Type = _Type.Replace("PRO-", "PROTOCOLE  N°")
    // _Type = _Type.Replace("MAG-", "MAGISTRATS DE PERMANENCE  N°")
    // _Type = _Type.Replace("CLB-", "OUVERTURE ORGANISATION FESTIVAL ACCES RESERVE N°")
    // _Type = _Type.Replace("CLG-", "GALA D'OUVERTURE N°")
    // _Type = _Type.Replace("CLU-", "DINER D'OUVERTURE N°")
    // _Type = _Type.Replace("CLR-", "SOIREE CLOTURE ORCHESTRE LUMIERE PRESSE N°")
    // _Type = _Type.Replace("CLM-", "SOIREE DE CLOTURE ACCES RESERVE ORGANISATION FIF N°")
    // _Type = _Type.Replace("CLC-", "OUVERTURE COULISSES N°")
    // _Type = _Type.Replace("CLD-", "OUVERTURE ORCHESTRE LUMIERE PRESSE  N°")
    // _Type = _Type.Replace("CLO-", "SOIREE DE CLOTURE INVITES FIF ACCES RESERVE N°")
    // _Type = _Type.Replace("CLV-", "OUVERTURE FESTIVAL MARCHE TOUS ACCES SALLE N°")
    // _Type = _Type.Replace("SIG-", "SIG N°")
    // End If
    // Return _Type
    // End Get
    // End Property

    // <System.ComponentModel.Description("N° Surbadge 1")>
    // Public Property NoSurBadge1 As String

    // <System.ComponentModel.Description("N° Surbadge 2")>
    // Public Property NoSurBadge2 As String

    // <System.ComponentModel.Description("N° Surbadge 3")>
    // Public Property NoSurBadge3 As String

    // <System.ComponentModel.Description("N° Surbadge 4")>
    // Public Property NoSurBadge4 As String

    // <System.ComponentModel.Description("N° Surbadge 5")>
    // Public Property NoSurBadge5 As String

    // <System.ComponentModel.Description("N° Surbadge 6")>
    // Public Property NoSurBadge6 As String

    // <System.ComponentModel.Description("N° Surbadge 7")>
    // Public Property NoSurBadge7 As String

    // <System.ComponentModel.Description("N° Surbadge 8")>
    // Public Property NoSurBadge8 As String

    // <System.ComponentModel.Description("N° Surbadge 9")>
    // Public Property NoSurBadge9 As String

    // <System.ComponentModel.Description("Badge bloqué")>
    // Public Property BlockBadge As Boolean

    // <System.ComponentModel.Description("Surbadge 1 bloqué?")>
    // Public Property BlockSurBadge1 As Boolean

    // <System.ComponentModel.Description("Surbadge 2 bloqué?")>
    // Public Property BlockSurBadge2 As Boolean

    // <System.ComponentModel.Description("Surbadge 3 bloqué?")>
    // Public Property BlockSurBadge3 As Boolean

    // <System.ComponentModel.Description("Surbadge 4 bloqué?")>
    // Public Property BlockSurBadge4 As Boolean

    // <System.ComponentModel.Description("Surbadge 5 bloqué?")>
    // Public Property BlockSurBadge5 As Boolean

    // <System.ComponentModel.Description("Surbadge 6 bloqué?")>
    // Public Property BlockSurBadge6 As Boolean

    // <System.ComponentModel.Description("Surbadge 7 bloqué?")>
    // Public Property BlockSurBadge7 As Boolean

    // <System.ComponentModel.Description("Surbadge 8 bloqué?")>
    // Public Property BlockSurBadge8 As Boolean

    // <System.ComponentModel.Description("Surbadge 9 bloqué?")>
    // Public Property BlockSurBadge9 As Boolean

    // <System.ComponentModel.Description("Catégorie")>
    // Public Property Categorie As String

    // <System.ComponentModel.Description("Chef de service")>
    // Public Property ChefDeService As Boolean

    // <System.ComponentModel.Description("Personne")>
    // Public Property Personne As PersonneData

    // <System.ComponentModel.Description("$$Tous les Repos")>
    // <DataMember()>
    // Public Property Repos As List(Of ReposData)


    // End Class

    public class PointageData
    {
      [System.ComponentModel.Description("$$FIdUtilisateurSession")]
      public int? FIdUtilisateurSession { get; set; }

      public PointageData()
      {
      }
      public PointageData(int? IdUtilisateurSession )
      {
        FIdUtilisateurSession = IdUtilisateurSession;
      }
      public int DeepScan = 2;

      [System.ComponentModel.Description("$$Librairie")]
      public string Library { get; set; } = "WcfService.Pointage, WcfService";

      [System.ComponentModel.Description("$$Id")]
      public int? Id { get; set; }

      [System.ComponentModel.Description("$$IdPlanning")]
      public int? IdPlanning { get; set; }

      [System.ComponentModel.Description("$$IdAccreditation")]
      public int? IdAccreditation { get; set; }

      [System.ComponentModel.Description("$$IdPersonne")]
      public int? IdPersonne { get; set; }

      // Private FPoste As PosteData
      // <System.ComponentModel.Description("Poste")>
      // Public Property Poste As PosteData

      // Private FPlanning As PlanningData
      //[System.ComponentModel.Description("Planning")]
      //public PlanningData Planning { get; set; }

      public PersonneData Personne { get; set; }

      [System.ComponentModel.Description("$$IdLieu")]
      public int? IdLieu { get; set; }

      // Private FLieu As String = ""
      [System.ComponentModel.Description("Lieu")]
      public string Lieu { get; set; }

      [System.ComponentModel.Description("Annee")]
      public string Annee { get; set; }

      [System.ComponentModel.Description("$$IdSens")]
      public string IdSens { get; set; }

      // Private FSens As String = ""
      [System.ComponentModel.Description("Sens")]
      public string Sens { get; set; }

      [System.ComponentModel.Description("Image")]
      public string Image { get; set; }

      [System.ComponentModel.Description("Date controle")]
      public DateTime? DateControle { get; set; }

      // <System.ComponentModel.Description("Date attendue")>
      // Public Property DateAttendue As Date?

      // <System.ComponentModel.Description("Date attendue")>
      // Public ReadOnly Property Ecart As Integer?
      // Get
      // If DateAttendue Is Nothing OrElse DateControle Is Nothing Then
      // Return Nothing
      // Else
      // Return CInt(DateDiff(DateInterval.Minute, CDate(DateControle), CDate(DateAttendue)))
      // End If
      // End Get
      // End Property

      [System.ComponentModel.Description("Resultat")]
      public string Resultat
      {
        get
        {
          if (IdSens == "R")
            return "Refusé";
          else
            return "Ok";
        }
      }

      [System.ComponentModel.Description("Code-barre")]
      public string CodeBarre { get; set; }

      [System.ComponentModel.Description("Note")]
      public string Note { get; set; }
    }

  }
  }