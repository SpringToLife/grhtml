using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{

  public class AccreditationData
  {


    [Key]
    [Description("Identifiant=IdAccreditation")]

    [DataMember()]
    public int? IdAccreditation { get; set; }

    [Description("IdExterne=IdExterne")]

    [DataMember()]
    public int? IdExterne { get; set; }

    [Description("$$IdCinando")]

    [DataMember()]
    public int? IdCinando { get; set; }

    [Description("$$Id. Personne=IdPersonne")]
    [DataMember()]
    public int? IdPersonne { get; set; }

    [Description("$$Id. Societe=IdSociete")]
    [DataMember()]
    public int? IdSociete { get; set; }

    [Description("Id. Film=IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }

    [Description("$$IdMedia1")]
    [DataMember()]
    public int? IdMedia1 { get; set; }

    [Description("$$IdMedia2")]
    [DataMember()]
    public int? IdMedia2 { get; set; }


    [Description("$$Media1")]
    [DataMember()]
    public SocieteData Media1 { get; set; }

    [Description("$$Media2")]
    [DataMember()]
    public SocieteData Media2 { get; set; }

    [Description("Média sec. 1=Media1")]
    [DataMember()]
    public string MediaStr1 { get; set; }

    [Description("Média sec. 2=Media2")]
    [DataMember()]
    public string MediaStr2 { get; set; }

    [Description("Date de création=DateCreation")]

    [DataMember()]
    public DateTime? DateCreation { get; set; }

    [Description("Date de Modification=DateModification")]

    [DataMember()]
    public DateTime? DateModification { get; set; }

    [Description("$$IdUtilisateurModification")]
    [DataMember()]
    public int? IdUtilisateurModification { get; set; }

    [Description("Date d'impression=DateImpression")]

    [DataMember()]
    public DateTime? DateImpression { get; set; }

    [Description("$$IdUtilisateurImpression")]
    [DataMember()]
    public int? IdUtilisateurImpression { get; set; }

    [Description("Date internet=DateWeb")]

    [DataMember()]
    public DateTime? DateWeb { get; set; }

    [Description("Date kit=DateRetraitSac")]

    [DataMember()]
    public DateTime? DateRetraitSac { get; set; }

    [Description("Date validation=DateValidation")]

    [DataMember()]
    public DateTime? DateValidation { get; set; }

    // <Description("$$IdUtilisateurTraitement=IdUtilisateurTraitement")>
    // <DataMember()>
    // Property IdUtilisateurTraitement As Integer?

    // <Description("$$IdUtilisateurEnCharge=IdUtilisateurEnCharge")>
    // <DataMember()>
    // <IgnoreDataMember>
    // Property IdUtilisateurEnCharge As Integer?

    [Description("Utilisateur En Charge=UtilisateurEnCharge")]
    [DataMember()]
    public string UtilisateurEnCharge { get; set; }

    [Description("Visé par=UtilisateurVisePar")]
    [DataMember()]
    public string UtilisateurVisePar { get; set; }

    [Description("$$CouleurTraitement")]
    [DataMember()]
    [IgnoreDataMember]
    public string CouleurTraitement { get; set; }

    [Description("Traitement=aTraitements_Libelle")]

    [DataMember()]
    public string LibelleTraitement { get; set; }

    [Description("Groupe=Groupe")]

    [DataMember()]
    public string Groupe { get; set; }

    [Description("$$IdTraitement")]
    [DataMember()]
    public int? IdTraitement { get; set; }

    [Description("$$IdContact")]
    [DataMember()]
    public int? IdContact { get; set; }

    [Description("Demande groupée?")]

    [DataMember()]
    public bool DemandeGroupee
    {
      get
      {
        if (IdContact == null)
          return false;
        else
          return true;
      }
      set
      {
      }
    }

    [Description("Réponse=Reponse")]

    [DataMember()]
    public string Reponse { get; set; }

    // <Description("Date traitement=DateTraitement")>
    // <DataMember()>
    // Property DateTraitement As Date?

    private string FIdEmetteur;
    [Description("Code Emetteur=Emetteur")]

    [DataMember()]
    public string IdEmetteur
    {
      get
      {
        return FIdEmetteur;
      }
      set
      {
        FIdEmetteur = value;
        if (value == "" || value == null)
          Emetteur = null/* TODO Change to default(_) if this is not a reference type */;
      }
    }


    public EmetteurData Emetteur { get; set; }

    [Description("$$Tunnel")]

    [DataMember()]
    [IgnoreDataMember]
    public string Tunnel
    {
      get
      {
        if (IdEmetteur == "F" && IdActivite == "S")
          return "R";
        else
          return IdEmetteur;
      }
      set
      {
      }
    }

    [Description("Activité=Activite")]

    [DataMember()]
    public string IdActivite { get; set; }

    [Description("Spécialité=Specialite")]

    [DataMember()]
    public string IdSpecialite { get; set; }

    [Description("Catégorie=Categorie")]

    [DataMember()]
    public string CodeCategorie { get; set; }

    [Description("Accompagnant?")]

    [DataMember()]
    public bool? IsAccompagnant { get; set; }


    // <Description("Catégorie=aCategories")>
    // <DataMember()>
    // Property Categorie As CategorieData

    // <Description("Activité=Activite")>
    // <DataMember()>
    // Property Activite As String

    // <Description("Spécialité=Specialite")>
    // <DataMember()>
    // Property Specialite As String

    [Description("Organisation=Organisation")]

    [DataMember()]
    public string Organisation { get; set; }

    public OrganisationData Contingent { get; set; }

 

    [Description("Secteur d'acccueil=Secteur")]

    [DataMember()]
    public string Secteur { get; set; }

    [Description("Services=Services")]

    [DataMember()]
    public string Services { get; set; } = "";

    [Description("Code Statut=Statut")]

    [DataMember()]
    public string CodeStatut { get; set; }

    [Description("Code Statut Détaillé=StatutDetail")]

    [DataMember()]
    public string CodeStatutDetail { get; set; }

    [Description("Histo. Statut=StatutPrecedent")]

    [DataMember()]
    public string CodeStatutPrecedent { get; set; }

    [Description("Histo. Statut Détaillé=StatutDetailPrecedent")]

    [DataMember()]
    public string CodeStatutDetailPrecedent { get; set; }

    public StatutData Statut { get; set; }

  
    public StatutDetailData StatutDetail { get; set; }

    [Description("Année=Annee")]

    [DataMember()]
    public string Annee { get; set; }

    [Description("Invité?=Invite")]

    [DataMember()]
    public bool? Invite { get; set; }

    [Description("PMR?=PMR")]
    [DataMember()]
    public bool? PMR { get; set; }

    // <Description("Nb. Accompagnants autorisés=AccompagnantsAutorises")>
    // <DataMember()>
    // Property AccompagnantsAutorises As Integer

    [Description("Id. Accompagnateur=IdAccompagnateur")]
    [DataMember()]
    public int? IdAccompagnateur { get; set; }

    [Description("Nb. Accompagnants=NbAccompagnant")]
    [DataMember()]
    [IgnoreDataMember]
    public int NbAccompagnant { get; set; } = 0;

    [Description("Liste=Liste")]

    [DataMember()]
    public string Liste { get; set; }

    [Description("Sans badge?")]

    [DataMember()]
    public bool? SansBadge { get; set; }

    [Description("Raison sans badge")]

    [DataMember()]
    public string SansBadgeRaison { get; set; }

    [Description("Code Wifi=Wifi")]

    [DataMember()]
    public string CodeWifi { get; set; }

    [Description("TR=TR")]

    [DataMember()]
    public string TR { get; set; }

    [Description("MOD=MOD")]

    [DataMember()]
    public string MOD_ { get; set; }

    // <Description("$$IdEmission")>
    // <DataMember()>
    // Property IdEmission As Integer?

    // <Description("Emission=aEmissions"), Category(Presse)>
    // <DataMember()>
    // Property Emission As EmissionData

    [Description("Nouveau?=Nouveau")]

    [DataMember()]
    public bool? Nouveau { get; set; }

    [Description("Tardif?=Tardif")]

    [DataMember()]
    public bool? Tardif { get; set; }

    [Description("EarlyBird?=EarlyBird")]

    [DataMember()]
    public bool? EarlyBird { get; set; }

    [Description("Contact badge=ContactBadge")]

    [DataMember()]
    public string ContactBadge { get; set; }

    [Description("Zone")]

    [DataMember()]
    public string Zone { get; set; }

    [Description("Code-Barres=CodeBarres")]

    [DataMember()]
    public string CodeBarres { get; set; }


    [Description("Notes traitement=NotesTraitement")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesTraitement { get; set; }

    [Description("Notes internet=NotesInternet")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesInternet { get; set; }

    [Description("Notes privés=NotesPrives")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesPrives { get; set; }

    [Description("Notes publiques=NotesPubliques")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesPubliques { get; set; }

    [Description("Notes organisations=NotesOrganisation")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesOrganisation { get; set; }

    [Description("Notes justificatifs=NotesJustificatifs")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesJustificatifs { get; set; }

    [Description("Notes hébergement=NotesHebergement")]

    [DataMember()]
    [IgnoreDataMember]
    public string NotesHebergement { get; set; }

    [Description("Date livraison=DateLivraison")]

    [DataMember()]
    [IgnoreDataMember]
    public DateTime? DateLivraison { get; set; }

    [Description("Lieu livraison=LieuLivraison")]

    [DataMember()]
    [IgnoreDataMember]
    public string LieuLivraison { get; set; }

    // <Description("N° Casier=Casier"), Category(Presse)>
    // <DataMember()>
    // Property Casier As Integer?

    // <Description("Nb. Ouv. Casier=NbOuverturesCasier"), Category(Presse)>
    // <DataMember()>
    // Property NbOuverturesCasier As Integer?

    [Description("Numéro=Numero")]

    [DataMember()]
    public int? Numero { get; set; }

    [Description("Param impr. 1=ParametreImpression1")]

    [DataMember()]
    public string ParametreImpression1 { get; set; }

    [Description("Param impr. 2=ParametreImpression2")]

    [DataMember()]
    public string ParametreImpression2 { get; set; }

    [Description("Param impr. 3=ParametreImpression3")]

    [DataMember()]
    public string ParametreImpression3 { get; set; }

    [Description("Param impr. 4=ParametreImpression4")]

    [DataMember()]
    public string ParametreImpression4 { get; set; }

    [Description("Param impr. 5=ParametreImpression5")]

    [DataMember()]
    public string ParametreImpression5 { get; set; }

    [Description("Rubrique Média=RubriqueMedia")]

    [DataMember()]
    public string RubriqueMedia { get; set; }

    [Description("Support Média=MediaSupport")]

    [DataMember()]
    public string MediaSupport { get; set; }

    [Description("Corres. à Paris=CorrespondantEtrangerParis")]

    [DataMember()]
    public bool? CorrespondantEtrangerParis { get; set; }

    [Description("Niveau Classe=NiveauClasse")]

    [DataMember()]
    public string NiveauClasse { get; set; }

    [Description("Dates de présence=DatesDePresence")]

    [DataMember()]
    public string DatesDePresence { get; set; }

    [Description("Présent du")]

    [DataMember()]
    public DateTime? PresenceDu { get; set; }

    [Description("Nb. jours")]

    [DataMember()]
    public int? NbJour { get; set; }

    [Description("Présent au")]

    [DataMember()]
    public DateTime? PresenceAu { get; set; }

    // <Description("Code internet=CodeInternet")>
    // <DataMember()>
    // Property CodeInternet As String

    // <Description("Login presse=LoginPresse"), Category(Presse)>
    // <DataMember()>
    // Property LoginPresse As String

    // <Description("Password presse=PasswordPresse"), Category(Presse)>
    // <DataMember()>
    // Property PasswordPresse As String

    [Description("Téléphone=Telephone")]

    [DataMember()]
    public string Telephone { get; set; }

    [Description("Téléphone à Cannes=TelephoneCannes")]

    [DataMember()]
    public string TelephoneCannes { get; set; }

    // <Description("Exonéré?=Exonere"), Category(Code)>
    // <DataMember()>
    // Property Exonere As Boolean?

    [Description("$$Exemptépiece")]
    [DataMember()]
    public bool? Exempte { get; set; }

    [Description("Code Type accred=IdTypeAccreditation")]

    [DataMember()]
    public string IdTypeAccreditation { get; set; }

    [Description("Type accred=aTypesAccreditations_Libelle")]

    [DataMember()]
    public string TypeAccreditation { get; set; }

    [Description("$$IdBrigade")]
    [DataMember()]
    public int? IdBrigade { get; set; }

    [Description("Badges bloqués=BadgesBloques")]
    [DataMember()]
    public string BadgesBloques { get; set; }

    [Description("Autres badges=AutresBadges")]
    [DataMember()]
    public string AutresBadges { get; set; }

    [Description("Montant=Montant")]
    [DataMember()]
    public double? Montant { get; set; }

    [Description("$$MontantModifie")]
    [DataMember()]
    public double? MontantModifie { get; set; }

    [Description("$$ServicesModifie")]
    [DataMember()]
    public string ServicesModifie { get; set; } = "";

    [Description("$$IdFacture")]
    [DataMember()]
    public int? IdFacture { get; set; }

    [Description("$$IdReglement")]
    [DataMember()]
    public int? IdReglement { get; set; }

    [System.ComponentModel.Description("Libellés SurBadges")]
    public string TypesSurBadges
    {
      get
      {
        string _Type = AutresBadges;
        if (AutresBadges != "")
        {
          _Type = _Type.Replace("CLT2", "TECHNICIEN CLT LUMIERE N°");
          _Type = _Type.Replace("CLE-", "OUVERTURE CANAL+ TOUS ACCES N°");
          _Type = _Type.Replace("CLA-", "OUVERTURE ACCES PARVIS N°");
          _Type = _Type.Replace("CLN-", "SOIREE DE CLOTURE CANAL+ TOUS ACCES N°");
          _Type = _Type.Replace("CLS-", "DINER DE CLOTURE N°");
          _Type = _Type.Replace("SEV-", "ESPACES VERTS  N°");
          _Type = _Type.Replace("CLK-", "ACCES RESERVE INVITE FESTIVAL N°");
          _Type = _Type.Replace("CLW-", "FESTIVAL ET MARCHE TOUS ACCES SALLE N°");
          _Type = _Type.Replace("CLX-", "ZONE PARTENAIRES ACCES RESERVE N°");
          _Type = _Type.Replace("CLJ-", "ORGANISATION FESTIVAL ACCES RESERVE N°");
          _Type = _Type.Replace("CLF-", "OUVERTURE INVITES FESTIVAL ACCES RESERVE  N°");
          _Type = _Type.Replace("CLL-", "COULOIR TECHNIQUE N°");
          _Type = _Type.Replace("CLH-", "ACCES NUIT NIVEAU 01 ZONE EXPOSITION N°");
          _Type = _Type.Replace("CLI-", "PERSONNELS AUTORISES ACCES RESERVE N°");
          _Type = _Type.Replace("CL2-", "SOIREE DE CLOTURE FESTIVAL ET MARCHE TOUS ACCES SALLE N°");
          _Type = _Type.Replace("PAL-", "PALAIS FESTIVAL DU FILM N°");
          _Type = _Type.Replace("CLP-", "SOIREE DE CLOTURE ACCES PARVIS N°");
          _Type = _Type.Replace("CLQ-", "SOIREE CLOTURE COULISSES N°");
          _Type = _Type.Replace("CL1-", "GALA DE CLOTURE N°");
          _Type = _Type.Replace("SIG-", "POLICE NATIONALE  N°");
          _Type = _Type.Replace("PAN-", "SERVICE DE NETTOYAGE N°");
          _Type = _Type.Replace("PRO-", "PROTOCOLE  N°");
          _Type = _Type.Replace("MAG-", "MAGISTRATS DE PERMANENCE  N°");
          _Type = _Type.Replace("CLB-", "OUVERTURE ORGANISATION FESTIVAL ACCES RESERVE N°");
          _Type = _Type.Replace("CLG-", "GALA D'OUVERTURE N°");
          _Type = _Type.Replace("CLU-", "DINER D'OUVERTURE N°");
          _Type = _Type.Replace("CLR-", "SOIREE CLOTURE ORCHESTRE LUMIERE PRESSE N°");
          _Type = _Type.Replace("CLM-", "SOIREE DE CLOTURE ACCES RESERVE ORGANISATION FIF N°");
          _Type = _Type.Replace("CLC-", "OUVERTURE COULISSES N°");
          _Type = _Type.Replace("CLD-", "OUVERTURE ORCHESTRE LUMIERE PRESSE  N°");
          _Type = _Type.Replace("CLO-", "SOIREE DE CLOTURE INVITES FIF ACCES RESERVE N°");
          _Type = _Type.Replace("CLV-", "OUVERTURE FESTIVAL MARCHE TOUS ACCES SALLE N°");
          _Type = _Type.Replace("SIG-", "SIG N°");
        }
        return _Type;
      }
    }

    [Description("Mission=Mission")]
    [DataMember()]
    public string Mission { get; set; }

    //[System.ComponentModel.Description("$$Tous les Repos")]
    //[IgnoreDataMember]
    //public List<ReposData> Repos { get; set; }

    [Description("$$Paye")]

    [DataMember()]
    public string IdStatutPaiement { get; set; } = "N";

    [Description("Statut paiement=aStatutsPaiements_Libelle")]

    [DataMember()]
    public string StatutPaiement { get; set; }


    public SocieteData Societe { get; set; }

    [Description("Email=Email")]

    [DataMember()]
    public string Email { get; set; }

    [Description("Email Réservation=EmailReservation")]

    [DataMember()]
    public string EmailReservation { get; set; }

    [Description("Email Réservation 2=EmailReservation2")]

    [DataMember()]
    public string EmailReservation2 { get; set; }

    [Description("Contact Organisation")]

    [DataMember()]
    public string ContactOrganisation { get; set; }

    [Description("$$Accompagnant")]
    [DataMember()]
    public string Accompagnants { get; set; }

    // <Description("Tirage billetterie?"), Category(Billet)>
    // <DataMember()>
    // Property Tirage As Boolean?

    // <Description("Bonus"), Category(Billet)>
    // <DataMember()>
    // Property Bonus As Integer = 0

    [Description("Importance=Importance")]

    [DataMember()]
    public int? Importance { get; set; }

    [Description("$$Id. Organisation")]
    [DataMember()]
    public int? IdOrganisation { get; set; }

    [Description("Billetterie?")]

    [DataMember()]
    public bool? Billetterie { get; set; }

    [Description("Accès Lumière?")]

    [DataMember()]
    public bool AccesLumiere { get; set; }

    [Description("$$En cours?")]
    [DataMember()]
    [IgnoreDataMember]
    public bool EnCours
    {
      get
      {
        if (CodeStatut != "ANN" && CodeStatut != "RF" && CodeStatut != "RO" && CodeStatut != "RF")
          return true;
        else
          return false;
      }
      set
      {
      }
    }

    [Description("Remise individuelle?=RemiseIndividuelle")]

    [DataMember()]
    public bool RemiseIndividuelle { get; set; } = true;

    // <Description("Contact accred.?=ContactAccreditation"), Category(Code)>
    // <DataMember()>
    // Property ContactAccreditation As Boolean


    [Description("Remise justif=RemiseJustif")]

    [DataMember()]
    public string RemiseJustif { get; set; }

    [Description("$$IdFonction")]
    [DataMember()]
    public int? IdFonction { get; set; }

    [Description("$$IdFonction")]
    [DataMember()]
    public int? IdFonctionDetail { get; set; }

    [Description("Fonction=Fonction")]

    [DataMember()]
    public string Fonction { get; set; }

    // <Description("FonctionDetail")>
    // <DataMember()>
    // Property FonctionDetail As String

    // <Description("Nb. Sac=NbSac"), Category(Cannes)>
    // <DataMember()>
    // Property NbSacs As Integer?

    // <Description("Sac"), Category(Cannes)>
    // <DataMember()>
    // Property Sac As String

    //[Description("Invitations")]

    //[DataMember()]
    //[IgnoreDataMember]
    //public List<BilletData> Billets { get; set; }

    // Private FDemandes As List(Of DemandeData)
    // <Description("Demandes de billets")>
    // <DataMember()>
    // Property Demandes As List(Of DemandeData)
    // // A CORRIGER

    // Get
    // If FDemandes Is Nothing Then
    // Demandes = Personne.FillDataDemandes(CInt(Id))
    // End If
    // Return FDemandes
    // End Get
    // Set(value As List(Of DemandeData))
    // FDemandes = value
    // End Set
    // End Property
    // <Description("Login accred.=Login")>
    // <DataMember()>
    // Property Login As String

    [Description("Password accred.=Password")]
    [DataMember()]
    public string Password { get; set; }

    [Description("$$IdUtilisateurSociete")]
    public int? IdUtilisateurSociete { get; set; }

    [Description("N° Organigramme=Organigramme")]

    [DataMember()]
    public string Organigramme { get; set; }

    [Description("Tags=Tags")]

    [DataMember()]
    public string Tags { get; set; }

    [Description("$$Programmes")]
   
    [DataMember()]
    public string Programmes { get; set; }

    [Description("$$LoginContact")]
    [DataMember()]
    public string LoginContact { get; set; }

    [Description("Société invité=SocieteInvite")]
    [DataMember()]
    public string SocieteInvite { get; set; }

    [Description("Agent représentant=AgentRepresentant")]
    [DataMember()]
    public string AgentRepresentant { get; set; }

    [Description("QrCode")]
    [DataMember()]
    public string QrCode
    {
      get
      {
        if (IdAccreditation != null && IdPersonne != null && IdAccreditation.ToString().Length > 1)
          return IdAccreditation.ToString();
        else
          return "";
      }
      set
      {
      }
    }

    
    public FilmData Film { get; set; }
  }
}