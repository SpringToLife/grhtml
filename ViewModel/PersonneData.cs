using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.ServiceModel;
using System.Xml.Serialization;
using GrapesJsEditorHtml.ViewModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


// NOTE: You can use the "Rename" command on the context menu to change the interface name "IPersonne" in both code and config file together.
public class PersonneData
{

  [Description("$$FIdUtilisateurSession")]
  [XmlIgnore]
  public int? FIdUtilisateurSession { get; set; }

  
  [Description("$$ReportData")]
  [XmlIgnore]
  public string ReportData { get; set; } = "GetPersonneReport";

  [Description("$$IdUtilisateurModification=IdUtilisateurModification")]
  [DataMember()]
  [XmlIgnore]
  public int? IdUtilisateurModification { get; set; }

  [Description("Date de création=DateCreation")]

  [DataMember()]
  public DateTime? DateCreation { get; set; }

  [Description("Date de Modification=DateModification")]

  [DataMember()]
  public DateTime? DateModification { get; set; }

  [Description("Identifiant=IdPersonne")]
  [Key]
  [DataMember()]
  public int? IdPersonne { get; set; }

  [Description("IdSelfkit=IdExterne")]
  [DataMember()]
  public int? IdExterne { get; set; }

  [Description("IdSoif=IdSoif")]
  [DataMember()]
  public int? IdSoif { get; set; }

  [Description("Id. Cinando=IdCinando")]
  [DataMember()]
  public int? IdCinando { get; set; }

  [Description("Actif=Actif")]
  [DataMember()]
  [XmlIgnore]
  public string Actif { get; set; } // = "Y"

  [Description("Civilité=Civilite")]

  [DataMember()]


  
  public CiviliteData Civilite { get; set; }

  [Description("Nom=Nom")]
 
  [DataMember()]
  public string Nom { get; set; }

  [Description("Nom jeune femme=NomJf")]

  [DataMember()]
  public string NomJf { get; set; }

  [Description("Prénom=Prenom")]

  [DataMember()]
  public string Prenom { get; set; }

  [Description("Langue=Langue")]

  [DataMember()]
  public string Langue { get; set; }

  [Description("Photo=Photo")]

  [DataMember()]
  public bool? Photo { get; set; }

  [Description("Email=Email")]

  [DataMember()]
  public string Email { get; set; }

  [Description("Site Web=SiteWeb")]

  [DataMember()]
  public string SiteWeb { get; set; }

  [Description("Entités=ListEntites")]

  [DataMember()]
  public string Entites { get; set; }

  [Description("Inversion Nom=InversionNom")]

  [DataMember()]
  public bool? InversionNom { get; set; } = false;

  [Description("Nom complet")]

  [DataMember()]
  public string FullName
  {
    get
    {
      if ((bool)InversionNom)
        return (Nom + " " + Prenom).Trim();
      else
        return (Prenom + " " + Nom).Trim();
    }
    set
    {
    }
  }

  [Description("Nom affichage")]

  [DataMember()]
  public string DisplayName
  {
    get
    {
      if (Nom == "" && Prenom == "")
        return "";
      else
        return (Nom + ", " + Prenom).Trim();
    }
    set
    {
    }
  }

  [Description("Nom complet inversé")]

  [DataMember()]
  public string FullNameInv
  {
    get
    {
      return (Nom + " " + Prenom).Trim();
    }
    set
    {
    }
  }

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

  [Description("Etat=Etats")]
 
  [DataMember()]
  public string Etat { get; set; }

  [Description("$$CodePays=Pays")]

  [DataMember()]
  public string CodePays { get; set; }

  [Description("Pays=Pays_Pays")]

  [DataMember()]
  public string Pays { get; set; }


  //[Description("Pays Soc./Pays")]

  //[DataMember()]
  //public string PaysOuPaysSoc
  //{
  //  get
  //  {
  //    if (AccreditationData?.Societe == null || Accreditation?.Societe.Pays == "")
  //      return Pays;
  //    else
  //      return Accreditation?.Societe.Pays;
  //  }
  //  set
  //  {
  //  }
  //}

  [Description("$$Nationalite")]

  [DataMember()]
  public string CodeNationalite { get; set; }

  [Description("$$Nationalite2")]

  [DataMember()]
  public string CodeNationalite2 { get; set; }

  [Description("Nationalité=Nationalite_Nationalite")]
 
  [DataMember()]
  public string Nationalite { get; set; }

  [Description("$$NationaliteUs")]
 
  [DataMember()]
  public string NationaliteUs { get; set; }

  [Description("Nationalité 2=Nationalite2_Nationalite")]

  [DataMember()]
  public string Nationalite2 { get; set; }

  [Description("$$NationaliteUs")]

  [DataMember()]
  public string Nationalite2Us { get; set; }

  [Description("Nationalités")]
 
  public string Nationalites
  {
    get
    {
      return Nationalite + Nationalite2 != "" ? ";" + Nationalite2 : "";
    }
    set
    {
    }
  }

  [Description("Téléphone 1=Telephone")]
  
  [DataMember()]
  public string Telephone { get; set; }

  [Description("Téléphone 2=Telephone2")]

  [DataMember()]
  public string Telephone2 { get; set; }

  [Description("$$Infos complètes?")]
  [DataMember()]
  [XmlIgnore]
  public bool Complet { get; set; }

  [Description("$$Synchro")]
  [DataMember()]
  [XmlIgnore]
  public bool? Synchroniser { get; set; }

  [Description("A un compte?=HasAccount")]
  [DataMember()]
  public bool? HasAccount { get; set; }

  [Description("Date de naissance=NaissanceDate")]

  [DataMember()]
  public DateTime? NaissanceDate { get; set; }

  //[Description("$$NaissanceDateFr")]
 
  //[DataMember()]
  //[XmlIgnore]
  //public string NaissanceDateFr
  //{
  //  get
  //  {
  //    if (NaissanceDate == null)
  //      return "";
  //    else
  //      return (DateTime)NaissanceDate.ToString("dd/MM/yyyy");
  //  }
  //  set
  //  {
  //  }
  //}

  //[Description("$$NaissanceDateStringFr")]

  //[DataMember()]
  //[XmlIgnore]
  //public string NaissanceDateStringFr
  //{
  //  get
  //  {
  //    if (NaissanceDate == null)
  //      return "";
  //    else
  //      return (DateTime)NaissanceDate.ToString("dd MMMM yyyy");
  //  }
  //  set
  //  {
  //  }
  //}

  //[Description("$$NaissanceDateUs")]

  //[DataMember()]
  //[XmlIgnore]
  //public string NaissanceDateUs
  //{
  //  get
  //  {
  //    if (NaissanceDate == null)
  //      return "";
  //    else
  //      return (DateTime)NaissanceDate.ToString("MM/dd/yyyy");
  //  }
  //  set
  //  {
  //  }
  //}

  //[Description("$$NaissanceDateStringUs")]
  //[Category(Organigramme)]
  //[DataMember()]
  //[XmlIgnore]
  //public string NaissanceDateStringUs
  //{
  //  get
  //  {
  //    if (NaissanceDate == null)
  //      return "";
  //    else
  //    {
  //      string _th;
  //      if (((DateTime)NaissanceDate.Day == 1 || (DateTime)NaissanceDate.Day == 21 || (DateTime)NaissanceDate.Day == 31))
  //        _th = "st";
  //      else if (((DateTime)NaissanceDate.Day == 2 || (DateTime)NaissanceDate.Day == 22))
  //        _th = "nd";
  //      else if (((DateTime)NaissanceDate.Day == 3 || (DateTime)NaissanceDate.Day == 23))
  //        _th = "rd";
  //      else
  //        _th = "th";
  //      return (DateTime)NaissanceDate.ToString("MMMM dd", new CultureInfo("en-US")) + _th + " " + (DateTime)NaissanceDate.ToString("yyyy");
  //    }
  //  }
  //  set
  //  {
  //  }
  //}

  [Description("Ville de naissance=NaissanceVille")]

  [DataMember()]
  public string NaissanceVille { get; set; }

  [Description("Département de naissance=NaissanceDepartement")]
   [DataMember()]
  public string NaissanceDepartement { get; set; }

  [Description("Ville code de naissance=NaissanceVilleCode")]
    [DataMember()]
  public string NaissanceVilleCode { get; set; }

  [Description("Pays de naissance")]
  [DataMember()]
  public string NaissancePays { get; set; }

  [Description("$$Pays de naissance")]
  [DataMember()]
  public string NaissancePaysUs { get; set; }

  [Description("$$NaissancePays=NaissancePays")]
  [DataMember()]
  public string NaissanceCodePays { get; set; }

  [Description("N° passeport=Passeport")]
   [DataMember()]
  public string Passeport { get; set; }

  [Description("N° titre travail=NoTitreTravail")]
  [DataMember()]
  public string NoTitreTravail { get; set; }

  [Description("IBAN=CoordonneesBancaires")]
  [DataMember()]
  public string IBAN { get; set; }

  [Description("BIC=BIC")]
  [DataMember()]
  public string BIC { get; set; }

  [Description("Titulaire compte=TitulaireCompte")]
   [DataMember()]
  public string TitulaireCompte { get; set; }

  [Description("Dédoublonné=Dedoublonne")]
   [DataMember()]
  public bool? Dedoublonne { get; set; }

  [Description("Handicapé?=PMR")]
   [DataMember()]
  public bool? PMR { get; set; }

  [Description("Notes privés=NotesPrives")]
  [DataMember()]
  [XmlIgnore]
  public string NotesPrives { get; set; }

  [Description("Notes publiques=NotesPubliques")]
    [DataMember()]
  [XmlIgnore]
  public string NotesPubliques { get; set; }

  [Description("Notes=Notes")]
  [DataMember()]
  [XmlIgnore]
  public string Notes { get; set; }

  [Description("Notes internet=NotesInternet")]
   [DataMember()]
  [XmlIgnore]
  public string NotesInternet { get; set; }

  

  [Description("Société Lp=SocieteLp")]
   [DataMember()]
  public string SocieteLp { get; set; }

  [Description("N° Secu=NoSecu")]
  [DataMember()]
  public string NoSecu { get; set; }

  [System.ComponentModel.Description("$$EtatTraduction")]
  [DataMember()]
  public int? EtatTraduction { get; set; }

  [System.ComponentModel.Description("Traduction")]
  [DataMember()]
  public string Traduction
  {
    get
    {
      if (EtatTraduction == 0)
        return "A traduire";
      else if (EtatTraduction == 1)
        return "Traduit";
      else
        return "Ne pas traduire";
    }
    set
    {
      if (value == "A traduire")
        EtatTraduction = 0;
      else if (value == "Traduit")
        EtatTraduction = 1;
      else
        EtatTraduction = 2;
    }
  }

  [Description("Matricule=Matricule")]
    [DataMember()]
  public string Matricule { get; set; }

  [Description("Profession=Profession")]
  [DataMember()]
  public string Profession { get; set; }

  [Description("Alias=Alias")]
  [DataMember()]
  public string AliasNom { get; set; }

  [Description("$$Phonetique=Phonetique")]
  [DataMember()]
  public string Phonetique { get; set; }

  [Description("$$NomSearch")]
  [DataMember()]
  public string NomSearch { get; set; }

  [Description("Carte Pro=CartePro")]
    [DataMember()]
  public string CartePro { get; set; }

  [Description("Validité Carte Pro=CarteProValidite")]
  [DataMember()]
  public string CarteProValidite { get; set; }

  [Description("Immatriculation=Immatriculation")]
  [DataMember()]
  public string Immatriculation { get; set; }

  [Description("Type Véhicule=Vehicule")]
  [DataMember()]
  public string Vehicule { get; set; }

  [Description("Marque Véhicule=Marque")]
  [DataMember()]
  public string Marque { get; set; }

  [Description("Modèle Véhicule=VehiculeInfo")]
  [DataMember()]
  public string VehiculeInfo { get; set; }


  [Description("Autorisé coulisses=AutoriseCoulisses")]
    [DataMember()]
  public bool? AutoriseCoulisses { get; set; }

  // <Description("Accréditations")>
  // <DataMember()>
  // Property Accreditations As List(Of AccreditationData)

  [Description("Contact stand=ContactStand")]
   [DataMember()]
  public string ContactStand { get; set; }

  [Description("Contact stand online=ContactStand")]
   [DataMember()]
  public string ContactStandOnline { get; set; }

  [Description("Contact proj.=ContactProj")]
   [DataMember()]
  public string ContactProjection { get; set; }

  [Description("Contact compta.=ContactCompta")]
  [DataMember()]
  public string ContactCompta { get; set; }

  [Description("Contact accred.=ContactAccred")]
   [DataMember()]
  public string ContactAccred { get; set; }

  [Description("Contact pub.=ContactPub")]
   [DataMember()]
  public string ContactPub { get; set; }

  [Description("Contact Ventane Sur=ContactVs")]
   [DataMember()]
  public string ContactVs { get; set; }

  [Description("Contact Billetterie=ContactBilletterie")]
   [DataMember()]
  public string ContactBilletterie { get; set; }

  [Description("Tél Contact Billetterie=ContactTelBilletterie")]
   [DataMember()]
  public string ContactTelBilletterie { get; set; }

  [Description("Email Contact Billetterie=ContactEmailBilletterie")]
  [DataMember()]
  public string ContactEmailBilletterie { get; set; }






  [Description("Publié?=Publie")]
  [DataMember()]
  public bool? Publie { get; set; }

  [Description("Publié Sfc?=PublieSfc")]
  [DataMember()]
  public bool? PublieSfc { get; set; }

  [Description("$$IdCreateur")]
  [DataMember()]
  public int? IdCreateur { get; set; }

  // <Description("$$Poste")>
  // <XmlIgnore>
  // Property Poste As PosteData

  // <Description("$$Postes")>
  // <XmlIgnore>
  // Public Property Postes As List(Of PosteData)

  // <Description("Compte")>
  // <DataMember()>
  // Property Compte As CompteData

  [Description("Adr. Bloc")]
  [XmlIgnore]
  public string AdrBloc
  {
    get
    {
      string _Line = "";
      _Line += AddLine(Civilite + " " + Prenom + " " + Nom);
      _Line += AdrBlocWithoutName;
      if (_Line != "")
        return _Line.ToUpper();
      else
        return "";
    }
  }

  [Description("Adr. Bloc Sans nom")]
  [XmlIgnore]
  [Newtonsoft.Json.JsonIgnore]
  public string AdrBlocWithoutName
  {
    get
    {
      string _Line = "";
      _Line += AddLine(Adresse1);
      _Line += AddLine(Adresse2);
      if (CodeEtat != "")
        _Line += AddLine(Ville + ", " + CodeEtat + " " + CodePostal);
      else if (CodePays == "GB")
      {
        _Line += AddLine(Ville);
        _Line += AddLine(CodePostal);
      }
      else
        _Line += AddLine(CodePostal + " " + Ville);
      if (CodePays != "" && CodePays != "FR")
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

  private string AddLine(string Line)
  {
    if (Line != null && Line.Trim() != "")
      return Line.Replace("  ", " ").Trim() + Constants.vbCrLf;
    else
      return "";
  }

  //[Description("$$$Hebergement")]
  //[XmlIgnore]
  //public HebergementData Hebergement { get; set; }

  //[Description("$$$TransportAller")]
  //[XmlIgnore]
  //public TransportData TransportAller { get; set; }

  //[Description("$$$TransportRetour")]
  //[XmlIgnore]
  //public TransportData TransportRetour { get; set; }
}



[DataContract()]
public class CasierData
{
  [Description("Casier")]
  [DataMember()]
  public string Casier { get; set; }

  [Description("Année")]
  [DataMember()]
  public string Annee { get; set; }

  [Description("Nb. Ouvertures N-1")]
  [DataMember()]
  public int NbOuverturesPrecedent { get; set; }

  [Description("Nb. Ouvertures N")]
  [DataMember()]
  public int NbOuvertures { get; set; }

  [Description("Précédent")]
  [DataMember()]
  public string Precedent { get; set; }
}

[DataContract()]
public class AccesControleData
{
  [DataMember()]
  public int? Id { get; set; }

  [DataMember()]
  public int? IdPersonne { get; set; }

  [DataMember()]
  public int? IdExterne { get; set; }

  [DataMember()]
  public int? IdEvenement { get; set; }

  [DataMember()]
  public string CodeBarres { get; set; }

  [DataMember()]
  public string CodeBarres2 { get; set; }

  [DataMember()]
  public string Nom { get; set; }

  [DataMember()]
  public string Prenom { get; set; }

  [DataMember()]
  public string Societe { get; set; }

  [DataMember()]
  public DateTime? DateControle { get; set; }
}


[DataContract()]
public class QuotaPersonneData
{
  [Description("$$Librairie")]
  [XmlIgnore]
  public string Library { get; set; } = "Services.Personne.PersonneClient, Services";

  [Description("$$LibrairieDirecte")]
  [XmlIgnore]
  public string LibraryDirect { get; set; } = "WcfService.Personne, WcfService";

  [Description("$$Identifiant=IdQuota")]
  [DataMember()]
  public int? Id { get; set; }

  [Description("$$Id.Personne")]
  [DataMember()]
  public int IdPersonne { get; set; }

  [Description("Personne=Personnes")]
  [DataMember()]
  public PersonneData Personne { get; set; }

  [Description("Emetteur=IdEmetteur")]
  [DataMember()]
  public string IdEmetteur { get; set; }

  [Description("$$Société quota")]
  [DataMember()]
  public int? IdSociete { get; set; }

  [Description("Société=Societes")]
  [DataMember()]
  public SocieteData Societe { get; set; }

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

  [Description("$$QuotaOriginal")]
  [DataMember()]
  public int? QuotaOriginal { get; set; }

  [Description("Quota=Quota")]
  [DataMember()]
  public int? Quota { get; set; }

  [Description("Commun?=Commun")]
  [DataMember()]
  public bool Commun { get; set; }

  [Description("Groupe=Groupe")]
  [DataMember()]
  public string Groupe { get; set; }

  [Description("Année Exempt.=AnneeExemption")]
  [DataMember()]
  public string AnneeExemption { get; set; }

  [Description("Société imposée?=SocieteImposee")]
  [DataMember()]
  public bool? SocieteImposee { get; set; }

  [Description("Activité=IdActivite")]
  [DataMember()]
  public string IdActivite { get; set; }

  [Description("Spécialité=IdSpecialite")]
  [DataMember()]
  public string IdSpecialite { get; set; }

  [Description("Services=Services")]
  [DataMember()]
  public string Services { get; set; }

  [Description("Notes traitement=NotesTraitement")]
  [DataMember()]
  public string NotesTraitement { get; set; }

  [Description("Notes justificatif=NotesJustificatif")]
  [DataMember()]
  public string NotesJustificatif { get; set; }

  [Description("Notes=Notes")]
  [DataMember()]
  [XmlIgnore]
  public string Notes { get; set; }
}

public class DoublonPersonneData
{
  public PersonneData Personne1 { get; set; }
  public PersonneData Personne2 { get; set; }
}

[DataContract()]
public class BiographieData
{
  [Description("$$Identifiant=IdBriographie")]
  [DataMember()]
  public int? IdBiographie { get; set; }

  [Description("$$IdPersonne=IdPersonne")]
  [DataMember()]
  public int? IdPersonne { get; set; }

  [Description("Date de Modification=DateModification")]
  [DataMember()]
  public DateTime? DateModification { get; set; }

  [Description("$$TypeBiographie")]
  [DataMember()]
  public int? TypeBiographie { get; set; }

  [Description("Biographie Fr=BiographieFr")]
  [DataMember()]
  public string BiographieFr { get; set; }

  [Description("Biographie En=BiographieUs")]
  [DataMember()]
  public string BiographieUs { get; set; }
}

[DataContract()]
public class TrackingData
{
  [Description("Date")]
  [DataMember()]
  public DateTime DateControle { get; set; }

  [Description("Lieu")]
  [DataMember()]
  public string Lieu { get; set; }

  [Description("Evènement")]
  [DataMember()]
  public string Evenement { get; set; }

  [Description("Commentaire")]
  [DataMember()]
  public string Commentaire { get; set; }
}

[DataContract()]
public class TagAccreditationData
{
  [DataMember()]
  public int? IdTag { get; set; }

  [DataMember()]
  public bool Visible { get; set; } = true;

  [DataMember()]
  public string Tag { get; set; }

  [DataMember()]
  public string Emetteurs { get; set; }
}

[Serializable]
[DataContract()]
public class PersonneListeData
{
  [Description("$$Librairie")]
  [XmlIgnore]
  public string Library { get; set; } = "Services.Personne.PersonneClient, Services";

  [Description("$$LibrairieDirecte")]
  [XmlIgnore]
  public string LibraryDirect { get; set; } = "WcfService.Personne, WcfService";


  [Description("Date de création=Personnes_DateCreation")]
  [DataMember()]
  public DateTime? DateCreation { get; set; }

  [Description("Date de Modification=Personnes_DateModification")]
  [DataMember()]
  public DateTime? DateModification { get; set; }

  [Description("Identifiant=Personnes_IdPersonne")]
  [DataMember()]
  public int? Id { get; set; }

  [Description("Identifiant accréditation=Accreditations_IdAccreditation")]
  [DataMember()]
  public int? IdAccreditation { get; set; }

  [Description("Id. Cinando=Personnes_IdCinando")]
  [DataMember()]
  public int? IdCinando { get; set; }

  [Description("Civilité=Personnes_Civilite")]
  [DataMember()]
  public string IdCivilite { get; set; }

  [Description("Nom=Personnes_Nom")]
  [DataMember()]
  public string Nom { get; set; }

  [Description("Prénom=Personnes_Prenom")]
  [DataMember()]
  public string Prenom { get; set; }

  [Description("Langue=Personnes_Langue")]
  [DataMember()]
  public string Langue { get; set; }

  [Description("Photo=Personnes_Photo")]
  [DataMember()]
  public bool? Photo { get; set; }

  [Description("Email=Personnes_Email")]
  [DataMember()]
  public string Email { get; set; }

  [Description("Entités=Personnes_ListEntites")]
  [DataMember()]
  public string Entites { get; set; }

  [Description("Adresse 1=Personnes_Adresse1")]
  [DataMember()]
  public string Adresse1 { get; set; }

  [Description("Code Postal=Personnes_CodePostal")]
  [DataMember()]
  public string CodePostal { get; set; }

  [Description("Ville=Personnes_Ville")]
  [DataMember()]
  public string Ville { get; set; }

  [Description("Etat=Personnes_Etats")]
  [DataMember()]
  public string Etat { get; set; }

  [Description("Pays=Pays_Pays")]
  [DataMember()]
  public string Pays { get; set; }

  [Description("Nationalité=Nationalite_Nationalite")]
  [DataMember()]
  public string Nationalite { get; set; }

  [Description("Nationalité 2=Nationalite2_Nationalite")]
  [DataMember()]
  public string Nationalite2 { get; set; }

  [Description("Téléphone 1=Personnes_Telephone")]
  [DataMember()]
  public string Telephone { get; set; }

  [Description("Téléphone 2=Personnes_Telephone2")]
  [DataMember()]
  public string Telephone2 { get; set; }

  [Description("A un compte?=Personnes_HasAccount")]
  [DataMember()]
  public bool? HasAccount { get; set; }

  [Description("Date de naissance=Personnes_NaissanceDate")]
  [DataMember()]
  public DateTime? NaissanceDate { get; set; }

  [Description("Pays de naissance")]
  [DataMember()]
  public string NaissancePays { get; set; }

  [Description("Dédoublonné=Personnes_Dedoublonne")]
  [DataMember()]
  public bool? Dedoublonne { get; set; }

  [Description("Profession=Personnes_Profession")]
  [DataMember()]
  public string Profession { get; set; }

  [Description("Contact stand=Personnes_ContactStand")]
  [DataMember()]
  public string ContactStand { get; set; }

  [Description("Contact stand online=Personnes_ContactStand")]
  [DataMember()]
  public string ContactStandOnline { get; set; }

  [Description("Contact proj.=Personnes_ContactProj")]
  [DataMember()]
  public string ContactProjection { get; set; }

  [Description("Contact compta.=Personnes_ContactCompta")]
  [DataMember()]
  public string ContactCompta { get; set; }

  [Description("Contact accred.=Personnes_ContactAccred")]
  [DataMember()]
  public string ContactAccred { get; set; }

  [Description("Contact pub.=Personnes_ContactPub")]
  [DataMember()]
  public string ContactPub { get; set; }

  [Description("Contact Ventane Sur=Personnes_ContactVs")]
  [DataMember()]
  public string ContactVs { get; set; }

  [Description("Contact Billetterie=Personnes_ContactBilletterie")]
  [DataMember()]
  public string ContactBilletterie { get; set; }

  [Description("Type accred=aTypesAccreditations_Libelle")]
  [DataMember()]
  public string TypeAccreditation { get; set; }

  [Description("Handicapé?=Accreditations_PMR")]
  [DataMember()]
  public bool? PMR { get; set; }

  [Description("Tags=Accreditations_Tags")]
  [DataMember()]
  public string Tags { get; set; }

  [Description("Accompagnant?")]
  [DataMember()]
  public bool? IsAccompagnant { get; set; }

  [Description("$$Accompagnant")]
  [DataMember()]
  public string Accompagnants { get; set; }

  [Description("Média sec. 1=Accreditations_Media1")]
  [DataMember()]
  public string MediaStr1 { get; set; }

  [Description("Média sec. 2=Accreditations_Media2")]
  [DataMember()]
  public string MediaStr2 { get; set; }

  [Description("Date d'impression=Accreditations_DateImpression")]
  [DataMember()]
  public DateTime? DateImpression { get; set; }

  [Description("Utilisateur En Charge=Accreditations_UtilisateurEnCharge")]
  [DataMember()]
  public string UtilisateurEnCharge { get; set; }

  [Description("Code Emetteur=Accreditations_Emetteur")]
  [DataMember()]
  public string IdEmetteur { get; set; }

  [Description("Activité=Accreditations_Activite")]
  [DataMember()]
  public string IdActivite { get; set; }

  [Description("Spécialité=Accreditations_Specialite")]
  [DataMember()]
  public string IdSpecialite { get; set; }

  [Description("Catégorie=Accreditations_Categorie")]
  [DataMember()]
  public string CodeCategorie { get; set; }

  [Description("Contingent=bOrganisations_Nom")]
  [DataMember()]
  public string Contingent { get; set; }

  [Description("Contingent Contact=bOrganisations_Contact")]
  [DataMember()]
  public string ContingentContact { get; set; }

  [Description("Secteur d'acccueil=Accreditations_Secteur")]
  [DataMember()]
  public string Secteur { get; set; }

  [Description("Code Statut=Accreditations_Statut")]
  [DataMember()]
  public string CodeStatut { get; set; }

  [Description("Code Statut Détaillé=Accreditations_StatutDetail")]
  [DataMember()]
  public string CodeStatutDetail { get; set; }

  [Description("Année=Accreditations_Annee")]
  [DataMember()]
  public string Annee { get; set; }

  [Description("Nouveau?=Accreditations_Nouveau")]
  [DataMember()]
  public bool? Nouveau { get; set; }

  [Description("Tardif?=Accreditations_Tardif")]
  [DataMember()]
  public bool? Tardif { get; set; }

  [Description("Notes traitement=Accreditations_NotesTraitement")]
  [DataMember()]
  public string NotesTraitement { get; set; }

  [Description("Notes justificatifs=Accreditations_NotesJustificatifs")]
  [DataMember()]
  public string NotesJustificatifs { get; set; }

  [Description("Statut paiement=aStatutsPaiements_Libelle")]
  [DataMember()]
  public string StatutPaiement { get; set; }

  [Description("Société nom=Societes_Nom")]
  [DataMember()]
  public string SocieteNom { get; set; }

  [Description("Société pays")]
  [DataMember()]
  public string SocietePays { get; set; }

  [Description("Email Accréditation=Accreditations_Email")]
  [DataMember()]
  public string EmailAccreditation { get; set; }

  [Description("Email Réservation=Accreditations_EmailReservation")]
  [DataMember()]
  public string EmailReservation { get; set; }

  [Description("Email Réservation 2=Accreditations_EmailReservation2")]
  [DataMember()]
  public string EmailReservation2 { get; set; }

  [Description("Importance=Accreditations_Importance")]
  [DataMember()]
  public int? Importance { get; set; }

  [Description("Billetterie?")]
  [DataMember()]
  public bool? Billetterie { get; set; }

  [Description("Fonction=Accreditations_Fonction")]
  [DataMember()]
  public string Fonction { get; set; }

  // <Description("Login accred.=Accreditations_Login")>
  // <DataMember()>
  // Property Login As String

  [Description("Password accred.=Accreditations_Password")]
  [DataMember()]
  public string Password { get; set; }

  [Description("Film Titre original")]
  [DataMember()]
  public string Titre { get; set; }

  [Description("Publié?=Personnes_Publie")]
  [DataMember()]
  public bool? Publie { get; set; }

  [Description("Publié Sfc?=Personnes_PublieSfc")]
  [DataMember()]
  public bool? PublieSfc { get; set; }
}
