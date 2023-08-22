using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

using static GrapesJsEditorHtml.ViewModel.InscriptionFilmData.FormulaireSelectionData;

namespace GrapesJsEditorHtml.ViewModel
{
  public class SocieteData
  {


      [Description("$$IdUtilisateurModification=IdUtilisateurSaisie")]
      [DataMember()]
      [IgnoreDataMember]
      public int? IdUtilisateurModification { get; set; }

      [Description("Actif=Actif")]
      [DataMember()]
      [IgnoreDataMember]
      public string Actif { get; set; } = "Y";

      [Description("Date de création=DateCreation")]
    
      [DataMember()]
      public DateTime DateCreation { get; set; }

      [Description("Date internet Marché=DateWeb")]

      [DataMember()]
      public DateTime? DateWeb { get; set; }

      [Description("Date de Modification=DateModification")]
     
      [DataMember()]
      public DateTime? DateModification { get; set; }

      [Description("Identifiant=IdSociete")]
    
      [DataMember()]
      [Key]
      public int? Societes_IdSociete { get; set; }

      [Description("$$Id. Selfkit=IdExterne")]
      [DataMember()]
      [IgnoreDataMember]
      public int? IdExterne { get; set; }

      // <Description("Id. Soif=IdSoif")>
      // <DataMember()>
      // Property IdSoif As Integer?

      [Description("Id. Cinando=IdCinando")]
      [DataMember()]
      public int? IdCinando { get; set; }

      [Description("$$Synchro")]
      [DataMember()]
      public bool? Synchroniser { get; set; }


      [Description("Identifiant Sage=IdentifSage")]
    
      [DataMember()]
      public string IdentifSage { get; set; }

      [Description("$$Id. Société Mère=IdSocieteMere")]
      [DataMember()]
      public int? IdSocieteMere { get; set; }

      [Description("$$Id. Contact Stand=IdContactStand")]
      [DataMember()]
      public int? IdContactStand { get; set; }

      [Description("$$Id. Contact Stand2=IdContactStand2")]
      [DataMember()]
      public int? IdContactStand2 { get; set; }

      [Description("$$IdContactStandOnline")]
      [DataMember()]
      public int? IdContactStandOnline { get; set; }

      [Description("$$Id. Contact Pub=IdContactPub")]
      [DataMember()]
      public int? IdContactPub { get; set; }

      [Description("$$Id. Contact Proj=IdContactProj")]
      [DataMember()]
      public int? IdContactProj { get; set; }

      [Description("$$Id. Contact Proj2=IdContactProj2")]
      [DataMember()]
      public int? IdContactProj2 { get; set; }

      [Description("$$Id. Contact Proj Cannes=IdContactProjCannes")]
      [DataMember()]
      public int? IdContactProjCannes { get; set; }

      [Description("$$Id. Contact Compta=$IdContactCompta")]
      [DataMember()]
      public int? IdContactCompta { get; set; }

      [Description("$$Id. Contact Vs=IdContactVs")]
      [DataMember()]
      public int? IdContactVs { get; set; }

      [Description("$$IdContactIndustryPrograms")]
      [DataMember()]
      public int? IdContactIndustryPrograms { get; set; }

      [Description("$$Id. Contact Utilisateur=IdContactCreateur")]
      [DataMember()]
      [IgnoreDataMember]
      public int? IdContactCreateur { get; set; }

       public CompteData CompteCreateur { get; set; }


      // <Description("$$Id. Contact Ecole - Compte créateur =IdContactEcoleCompte")>
      // <DataMember()>
      // <IgnoreDataMember>
      // Property IdContactEcoleCompte As Integer?

      [Description("$$Id. Contact Ecole")]
      [DataMember()]
      [IgnoreDataMember]
      public int? IdContactEcole { get; set; }

      [Description("Nom=Nom")]

      [DataMember()]
      public string Nom { get; set; }

      [Description("Nom court=NomCourt")]

      [DataMember()]
      public string NomCourt { get; set; }

      [Description("Alias=Alias")]

      [DataMember()]
      public string AliasNom { get; set; }

      [Description("$$Phonetique=Phonetique")]
      [DataMember()]
      public string Phonetique { get; set; }

      [Description("$$NomSearch")]
      [DataMember()]
      public string NomSearch { get; set; }

      [Description("Utilisateur En Charge=UtilisateurEnCharge")]
      [DataMember()]
      public string UtilisateurEnCharge { get; set; }

      [Description("Utilisateur En Charge Projection=UtilisateurEnChargeProj")]
      [DataMember()]
      public string UtilisateurEnChargeProj { get; set; }

      [Description("$$CouleurTraitement")]
      [DataMember()]
      [IgnoreDataMember]
      public string CouleurTraitement { get; set; }

      [Description("Traitement")]
  
      [DataMember()]
      public string LibelleTraitement { get; set; }

      [Description("$$Id. Traitement=IdTraitement")]
      [DataMember()]
      [IgnoreDataMember]
      public int? IdTraitement { get; set; }

      [Description("Notes traitement=NotesTraitement")]
     
      [DataMember()]
      public string NotesTraitement { get; set; }

      [DataMember()]
      [Description("N° Tva intra.=NumeroTvaIntra")]
    
      public string NumeroTvaIntra { get; set; }

      [Description("Adresse 1=Adresse1")]
      
      [DataMember()]
      public string Adresse1 { get; set; }

      [Description("Adresse 2=Adresse2")]
  
      [DataMember()]
      public string Adresse2 { get; set; }

      [Description("Code Postal=CodePostal")]

      [DataMember()]
      public string CodePostal { get; set; }

      [Description("Ville=Ville")]
   
      [DataMember()]
      public string Ville { get; set; }

      [Description("Code Etat=Etat")]

      [DataMember()]
      public string CodeEtat { get; set; }

      [Description("Etat")]

      [DataMember()]
      public string Etat { get; set; }

      [Description("$$CodePays=Pays")]

      [DataMember()]
      [IgnoreDataMember]
      public string CodePays { get; set; }

      [Description("Pays=PaysSoc_Pays")]

      [DataMember()]
      public string Pays { get; set; }

      [Description("Pays Us=PaysSoc_PaysUs")]

      [DataMember()]
      public string PaysUs { get; set; }

      public PaysData DetailPays { get; set; }

      [Description("Contact")]
    
      [DataMember()]
      public string Contact { get; set; }

      [Description("Téléphone=Telephone")]
 
      [DataMember()]
      public string Telephone { get; set; }

      // <Description("Fax=Fax")>
      // <DataMember()>
      // Property Fax As String

      [Description("Email=Email")]
  
      [DataMember()]
      public string Email { get; set; }

      [Description("Email rédaction=EmailRedaction")]

      [DataMember()]
      public string EmailRedaction { get; set; }

      [Description("Site Web=SiteWeb")]

      [DataMember()]
      public string SiteWeb { get; set; }

      [Description("Activité=IdActivite")]

      [DataMember()]
      public string IdActivite { get; set; }

      [Description("Spécialité=IdSpecialite")]
  
      [DataMember()]
      public string IdSpecialite { get; set; }

      [Description("Organisation=IdOrganisation")]
     
      [DataMember()]
      public string IdOrganisation { get; set; }

      [Description("Groupes=Groupes")]

      [DataMember()]
      [IgnoreDataMember]
      public string Groupes { get; set; }

      [Description("Profil=Profil")]
  
      [DataMember()]
      [IgnoreDataMember]
      public string Profil { get; set; }

      [Description("Suivi stand=StatutMarche")]
   
      [DataMember()]
      [IgnoreDataMember]
      public string StatutMarche { get; set; }

      [Description("Services=Services")]
    
      [DataMember()]
      public string Services { get; set; }

      [Description("Dvm?=DVM")]
      
      [DataMember()]
      [IgnoreDataMember]
      public bool? Dvm { get; set; }

      [Description("Facturé=MontantFacture")]
    
      [DataMember()]
      public double? MttFacture { get; set; }

      [Description("Règlements=MontantReglement")]
    
      [DataMember()]
      public double? MttReglement { get; set; }

    [Description("Solde=MontantSolde")]

    [DataMember()]
    public double? MttSolde { get; set; }

    [Description("Solde Echu=MontantSoldeEchu")]

    [DataMember()]
    public double? MttSoldeEchu { get; set; }

    [Description("Solde Echu Semaine Prochaine=MontantSoldeEchuProchain")]

    [DataMember()]
    public double? MttSoldeEchuProchain { get; set; }
    [Description("Solde avec devis=MttSoldeAvecDevis")]

    [DataMember()]
    public double? MttSoldeAvecDevis { get; set; }

    [Description("Solde Echu avec devis=MttSoldeEchuAvecDevis")]

    [DataMember()]
    public double? MttSoldeEchuAvecDevis { get; set; }

    [Description("Debit autorisé=DebitAutorise")]

      [DataMember()]
      public bool? DebitAutorise { get; set; }

      [Description("Langue=Langue")]
    
      [DataMember()]
      public string Langue { get; set; }

      [Description("Notes Privés Festival=NotesPrives")]

      [DataMember()]
      [IgnoreDataMember]
      public string NotesPrives { get; set; }

      [Description("Notes Privés Presse=NotesPrivesPresse")]
     
      [DataMember()]
      [IgnoreDataMember]
      public string NotesPrivesPresse { get; set; }

      [Description("Notes Privés Marché=NotesPrivesMarche")]
     
      [DataMember()]
      [IgnoreDataMember]
      public string NotesPrivesMarche { get; set; }

      [Description("Notes Publiques=NotesPubliques")]

      [DataMember()]
      [IgnoreDataMember]
      public string NotesPubliques { get; set; }

      [Description("Notes Compta=NotesCompta")]
    
      [DataMember()]
      [IgnoreDataMember]
      public string NotesCompta { get; set; }

      [Description("Notes Internet=NotesInternet")]
    
      [DataMember()]
      [IgnoreDataMember]
      public string NotesInternet { get; set; }

      [Description("Notes N+1=NotesMarcheStand")]
    
      [DataMember()]
      [IgnoreDataMember]
      public string NotesMarcheStand { get; set; }


      [Description("Forcé TVA?=ForceTva")]
   
      [DataMember()]
      public bool? ForceTva { get; set; }

      [Description("Paye TVA?")]
     
      [DataMember()]
      public bool PayeTva
      {
        get
        {
          // If DetailPays IsNot Nothing AndAlso ForceTva = False AndAlso CodePays <> "FR" AndAlso (MandatTva OrElse NumeroTvaIntra <> "") Then
          if (DetailPays != null && ForceTva == false && CodePays != "FR" && (!DetailPays.UE || NumeroTvaIntra != ""))
            return false;
          else
            return true;
        }
        set
        {
        }
      }

      [Description("Décorateur=SocieteDecoratrice")]
  
      [DataMember()]
      public string SocieteDecoratrice { get; set; } = "";

      [Description("Mandat TVA?=MandatTva")]
    
      [DataMember()]
      public bool? MandatTva { get; set; }

      [Description("Option TVA?=OptionTva")]
  
      [DataMember()]
      public bool? OptionTva { get; set; }

      // <Description("Accès limité fact.?=AccesLimiteFacture"), Category(Compta)>
      // <DataMember()>
      // Property AccesLimiteFacture As Boolean?

      [Description("Indépendant?=Independant")]
   
      [DataMember()]
      public bool? Independant { get; set; }

      [Description("Dédoublonné?=Dedoublonne")]
    
      [DataMember()]
      public bool? Dedoublonne { get; set; }

      [Description("Importance=Importance")]
  
      [DataMember()]
      public int? Importance { get; set; }

      [Description("Support Média FO=MediaSupport")]
    
      [DataMember()]
      public string MediaSupport { get; set; }

      [Description("Support Média BO=MediaSupportInterne")]

      [DataMember()]
      public string MediaSupportInterne { get; set; }

      [Description("Périodicité Média=MediaPeriodicite")]

      [DataMember()]
      public string MediaPeriodicite { get; set; }

      [Description("Directeur Média=MediaDirecteur")]
    
      [DataMember()]
      public string MediaDirecteur { get; set; }

      [Description("Rédacteur Média=MediaRedacteur")]
   
      [DataMember()]
      public string MediaRedacteur { get; set; }

      [Description("Email rédacteur en chef=EmailRedacteurEnChef")]
   
      [DataMember()]
      public string EmailRedacteurEnChef { get; set; }

      [Description("Nb. Sacs=NbSacs")]
    
      [DataMember()]
      public int? NbSacs { get; set; }

      [Description("Nb. Badges Prioritaires=NbBadgesPrioritaires")]

      [DataMember()]
      public int? NbBadgesPrioritaires { get; set; }


      [Description("$$IdStatutEcole")]
    
      [DataMember()]
      public int? IdStatutEcole { get; set; }

      [Description("Ecole?=StatutEcole")]
     
    [DataMember()]
      public bool? StatutEcole { get; set; }

      [Description("Statut école=dStatutsEcole_StatutEcole")]
     
      [DataMember()]
      public string StatutEcoleString { get; set; }

      [Description("$$Statut école=dStatutsEcole")]

      [DataMember()]
      public StatutEcoleData StatutEcoleObjet { get; set; }


      [Description("Droits d'aquisition=DroitsAcquisitions")]
    
      [DataMember()]
      public string DroitsAcquisitions { get; set; }

      [Description("Année Stand=AnneeStand")]
  
      [DataMember()]
      public string AnneeStand { get; set; }

      [Description("$$Personnes")]
      [DataMember()]
      [IgnoreDataMember]
      public List<PersonneData> Personnes { get; set; }

      [Description("$$Projections")]
      [DataMember()]
      [IgnoreDataMember]
      public List<MarcheProjectionData> ProjectionsMarche { get; set; }

      [Description("$$ContactProjection")]
      [DataMember()]
      [IgnoreDataMember]
      public PersonneData ContactProjection { get; set; }

      [Description("$$ContactProjection2")]
      [DataMember()]
      [IgnoreDataMember]
      public PersonneData ContactProjection2 { get; set; }

      [System.ComponentModel.Description("$$ContactProjCannes")]
      [DataMember()]
      [IgnoreDataMember]
      public PersonneData ContactProjCannes { get; set; }


    [Description("Adr. Bloc")]
    public string AdrBloc
    {
      get
      {
        string _Line = "";
        _Line = _Line + AddLine(Nom);
        _Line = _Line + AdrBlocWithoutName;
        if (_Line != "")
          return _Line;
        else
          return "";
      }
    }

    //[Description("$$Adr. Bloc Us")]

    //[IgnoreDataMember]
    //public string AdrBlocUs
    //{
    //  get
    //  {
    //    string _Line = "";
    //    _Line = _Line + AddLine(Nom);
    //    _Line = _Line + AdrBlocWithoutNameUS;
    //    if (_Line != "")
    //      return _Line;
    //    else
    //      return "";
    //  }
    //}

    [Description("Adr. Bloc sans Nom")]

    [IgnoreDataMember]
    public string AdrBlocWithoutName
    {
      get
      {
        string _Line = "";
        _Line = _Line + AddLine(Adresse1);
        _Line = _Line + AddLine(Adresse2);
        if (CodeEtat != "")
          _Line = _Line + AddLine(Ville + ", " + CodeEtat + " " + CodePostal);
        else if (CodePays == "GB")
        {
          _Line = _Line + AddLine(Ville);
          _Line = _Line + AddLine(CodePostal);
        }
        else
          _Line = _Line + AddLine(CodePostal + " " + Ville);
        // If CodePays <> "" AndAlso CodePays <> "FR" Then 
        _Line = _Line + AddLine(Pays);
        if (_Line != "")
          return _Line.Substring(0, _Line.Length - 2);
        else
          return "";
      }
      set
      {
      }
    }

    //[Description("$$Adr. Bloc sans Nom US")]
    //[Category(Coord)]
    //[IgnoreDataMember]
    //public string AdrBlocWithoutNameUS
    //{
    //  get
    //  {
    //    string _Line = "";
    //    _Line = _Line + AddLine(Adresse1);
    //    _Line = _Line + AddLine(Adresse2);
    //    if (CodeEtat != "")
    //      _Line = _Line + AddLine(Ville + ", " + CodeEtat + " " + CodePostal);
    //    else if (CodePays == "GB")
    //    {
    //      _Line = _Line + AddLine(Ville);
    //      _Line = _Line + AddLine(CodePostal);
    //    }
    //    else
    //      _Line = _Line + AddLine(CodePostal + " " + Ville);
    //    // If CodePays <> "" AndAlso CodePays <> "FR" Then 
    //    _Line = _Line + AddLine(PaysUs);
    //    if (_Line != "")
    //      return _Line.Substring(0, _Line.Length - 2);
    //    else
    //      return "";
    //  }
    //  set
    //  {
    //  }
    //}

    private string AddLine(string Line)
    {
      if (Line != null && Line.Trim() != "")
        return Line.Replace("  ", " ").Trim();
      else
        return "";
    }

    [Description("$$IdSelectionneur")]
      [DataMember()]
      public int? IdSelectionneur { get; set; }

    
      public PersonneData Selectionneur { get; set; }
    }

    public class PersonneSocieteData
    {
      [Description("Identifiant=Id")]
      [DataMember()]
      public int? Id { get; set; }

      [Description("$$IdPersonne")]
      [DataMember()]
      public int IdPersonne { get; set; }

      [Description("$$IdSociete")]
      [DataMember()]
      public int? IdSociete { get; set; }

      [Description("Date arrivée=DateArrivee")]
      [DataMember()]
      public DateTime? DateArrivee { get; set; }

      [Description("Date départ=DateDepart")]
      [DataMember()]
      public DateTime? DateDepart { get; set; }


      [Description("Société")]
      [DataMember()]
      public SocieteData Societe { get; set; }

    //  [Description("Société+Date")]
    //  [DataMember()]
    //  public string SocieteDate
    //  {
    //    get
    //    {
    //      if (Societe == null)
    //        return "";
    //      if (DateDepart != null)
    //        return Societe.Nom + " (Délié le " + (DateTime)DateDepart.ToString("dd/MM/yy") + ")";
    //      if (DateArrivee != null)
    //        return Societe.Nom + " (Lié le " + (DateTime)DateArrivee.ToString("dd/MM/yy") + ")";
    //      return Societe.Nom;
    //    }
    //    set
    //    {
    //    }
    //  }
    //}

    [DataContract()]
    public class QuotaSocieteData
    {
      [Description("$$Librairie")]
      [IgnoreDataMember]
      public string Library { get; set; } = "Services.Societe.SocieteClient, Services";

      [DataMember()]
      [Description("$$LibrairieDirecte")]
      [IgnoreDataMember]
      public string LibraryDirect { get; set; } = "WcfService.Societe, WcfService";

      [Description("$$Identifiant")]
      [DataMember()]
      public int? Id { get; set; }

      [Description("$$Id.Société")]
      [DataMember()]
      public int IdSociete { get; set; }

      [Description("Société=Societes")]
      [DataMember()]
      public SocieteData Societe { get; set; }

      [Description("Emetteur=IdEmetteur")]
      [DataMember()]
      public string IdEmetteur { get; set; }

      [Description("Secteur d'accueil=IdSecteur")]
      [DataMember()]
      public string IdSecteur { get; set; }

      [Description("Exonéré=Exonere")]
      [DataMember()]
      public bool? Exonere { get; set; }

      [Description("Nb.Acc.=AccompagnantsAutorises")]
      [DataMember()]
      public int? AccompagnantsAutorises { get; set; }

      [Description("Importance=Importance")]
      [DataMember()]
      public int? Importance { get; set; }

      [Description("Quota=Quota")]
      [DataMember()]
      public int? Quota { get; set; }

      [Description("Nb. Badges gratuits=NbBadgeGratuit")]
      [DataMember()]
      public int? NbBadgeGratuit { get; set; }

      [Description("Nb. Badges Online gratuits=NbOnlineGratuit")]
      [DataMember()]
      public int? NbOnlineGratuit { get; set; }

      [Description("Année Exempt.=AnneeExemption")]
      [DataMember()]
      public string AnneeExemption { get; set; }

      [Description("Services=Services")]
      [DataMember()]
      public string Services { get; set; }

      [Description("Groupe=Groupe")]
      [DataMember()]
      public string Groupe { get; set; }
    }

    public class DoublonSocieteData
    {
      public SocieteData Societe1 { get; set; }
      public SocieteData Societe2 { get; set; }
    }

    [DataContract()]
    public class PressInfoData
    {
      [DataMember()]
      [Description("$$$Librairie")]
      [IgnoreDataMember]
      public string Library { get; set; } = "Services.Societe.SocieteClient, Services";

      [DataMember()]
      [Description("$$$LibrairieDirecte")]
      [IgnoreDataMember]
      public string LibraryDirect { get; set; } = "WcfService.Societe, WcfService";

      [Description("$$IdPressInfo")]
      [DataMember()]
      public int? IdPressInfo { get; set; }

      [Description("$$IdPersonne")]
      [DataMember()]
      public int? IdPersonne { get; set; }

      [Description("$$IdSociete")]
      [DataMember()]
      public int? IdSociete { get; set; }

      [Description("Société=Societes")]
      [DataMember()]
      public SocieteData Societe { get; set; }

      [Description("Année=Annee")]
      [DataMember()]
      public string Annee { get; set; }

      [Description("Site Web=SiteWeb")]
      [DataMember()]
      public string SiteWeb { get; set; }

      [Description("Site Web Nb Visiteurs=SiteWebNbVisiteurs")]
      [DataMember()]
      public long? SiteWebNbVisiteurs { get; set; }

      [Description("Site Web Nb Pages Lues=SiteWebNbPagesLues")]
      [DataMember()]
      public long? SiteWebNbPagesLues { get; set; }

      [Description("Compte twitter=Twitter")]
      [DataMember()]
      public string Twitter { get; set; }

      [Description("Nombre de followers=TwitterFollowers")]
      [DataMember()]
      public long? TwitterFollowers { get; set; }

      [Description("Compte facebook=Facebook")]
      [DataMember()]
      public string Facebook { get; set; }

      [Description("Nombre moyen de like par mois=FacebookLikesParMois")]
      [DataMember()]
      public long? FacebookLikesParMois { get; set; }

      [Description("Tirage Média=MediaTirage")]
      [DataMember()]
      public long? MediaTirage { get; set; }

      [Description("Tirage Fif Média=MediaTirage")]
      [DataMember()]
      public long? MediaTirageFif { get; set; }
    }

  }
}
