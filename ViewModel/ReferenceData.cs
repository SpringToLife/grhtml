using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace GrapesJsEditorHtml.ViewModel
{
  public class VilleData
  {
    [DataMember()]
    public int Id { get; set; }

    [DataMember()]
    public string CodePostal { get; set; }

    [DataMember()]
    public string CpVille
    {
      get
      {
        return CodePostal + " - " + Ville;
      }
      set
      {
      }
    }

    [DataMember()]
    public string VilleCp
    {
      get
      {
        return Ville + " - " + CodePostal;
      }
      set
      {
      }
    }

    [DataMember()]
    public string Ville { get; set; }
  }

  [DataContract()]
  public class PaysData
  {
   
    [System.ComponentModel.Description("$$IdPays")]
    [DataMember()]
    public string IdPays { get; set; }

    [System.ComponentModel.Description("Pays=Pays")]
    [DataMember()]
    public string Pays { get; set; }

    [System.ComponentModel.Description("Pays Us=PaysUs")]
    [DataMember()]
    public string PaysUs { get; set; }

    [System.ComponentModel.Description("Nationalité=Nationalite")]
    [DataMember()]
    public string Nationalite { get; set; }

    [System.ComponentModel.Description("Nationalité Us=NationaliteUs")]
    [DataMember()]
    public string NationaliteUs { get; set; }

    [System.ComponentModel.Description("$$IdContinent")]
    [DataMember()]
    public int? IdContinent { get; set; }

    [System.ComponentModel.Description("$$IdLangue")]
    [DataMember()]
    public string IdLangue { get; set; }

    [System.ComponentModel.Description("Indicatif numéro=IndicatifNumero")]
    [DataMember()]
    public string IndicatifNumero { get; set; }

    [System.ComponentModel.Description("Format numéro=FormatNumero")]
    [DataMember()]
    public string FormatNumero { get; set; }

    [System.ComponentModel.Description("$$CodeIso3")]
    [DataMember()]
    public string CodeIso3 { get; set; }

    [System.ComponentModel.Description("UE?=UE")]
    [DataMember()]
    public bool UE { get; set; }

    [System.ComponentModel.Description("$$IdCinando")]
    [DataMember()]
    public int? IdCinando { get; set; }
  }

  [DataContract()]
  public class DepartementData
  {
    [DataMember()]
    public string Numero { get; set; }

    [DataMember()]
    public string Nom { get; set; }

    [DataMember()]
    public string Region { get; set; }

    [DataMember()]
    public string ChefLieu { get; set; }
  }

  [DataContract()]
  public class ContinentData
  {
    [System.ComponentModel.Description("$$IdContinent")]
    [DataMember()]
    public int? IdContinent { get; set; }

    [System.ComponentModel.Description("Continent=Continent")]
    [DataMember()]
    public string Continent { get; set; }
  }

  [DataContract()]
  public class ActiviteData
  {
    [System.ComponentModel.Description("$$IdActivite")]
    [DataMember()]
    public string IdActivite { get; set; }

    [System.ComponentModel.Description("Activité=Activite")]
    [DataMember()]
    public string Activite { get; set; }

    [System.ComponentModel.Description("Activité Us=ActiviteUs")]
    [DataMember()]
    public string ActiviteUs { get; set; }

    [System.ComponentModel.Description("$$IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }

    [System.ComponentModel.Description("Internet=Internet")]
    [DataMember()]
    public bool Internet { get; set; }

    [System.ComponentModel.Description("Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Secteur=IdSecteur")]
    [DataMember()]
    public string IdSecteur { get; set; }

    [System.ComponentModel.Description("$$IdCinando")]
    [DataMember()]
    public string IdCinando { get; set; }
  }

  public class EmetteurData
  {

    [System.ComponentModel.Description("$$IdEmetteur")]
    [DataMember()]
    public string IdEmetteur { get; set; }

    [System.ComponentModel.Description("Nom=Emetteur")]
    [DataMember()]
    public string Emetteur { get; set; }

    [System.ComponentModel.Description("Sac=Sac")]
    [DataMember()]
    public string Sac { get; set; }

    // <System.ComponentModel.Description("Nb. Accompagnant=NbAccompagnant")>
    // <DataMember()>
    // Property NbAccompagnant As Integer

    [System.ComponentModel.Description("Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Contact Limite?=ContactLimite")]
    [DataMember()]
    public bool ContactLimite { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("Groupes")]
    [DataMember()]
    public string Groupes { get; set; } = "";

    [System.ComponentModel.Description("Groupe par défaut=GroupesDefaut")]
    [DataMember()]
    public string GroupesDefaut { get; set; } = "";

    [System.ComponentModel.Description("Groupes autorisés=GroupesAutorise")]
    [DataMember()]
    public string GroupesAutorise { get; set; } = "";

    [System.ComponentModel.Description("Groupe de gestion=GroupesGestion")]
    [DataMember()]
    public string GroupesGestion { get; set; } = "";

    [System.ComponentModel.Description("Groupe de visé=GroupesCise")]
    [DataMember()]
    public string GroupesVise { get; set; } = "";

    [System.ComponentModel.Description("Signature Email=SignatureMail")]
    [DataMember()]
    public string SignatureMail { get; set; } = "";

    [System.ComponentModel.Description("Ouverture Accred.=DateOuvertureAccreditation")]
    [DataMember()]
    public DateTime? DateOuvertureAccreditation { get; set; }

    [System.ComponentModel.Description("Blocage Accred.=DateBlocageAccreditation")]
    [DataMember()]
    public DateTime? DateBlocageAccreditation { get; set; }

    [System.ComponentModel.Description("Limite remboursement=DateLimiteRemboursement")]
    [DataMember()]
    public DateTime? DateLimiteRemboursement { get; set; }

    [System.ComponentModel.Description("Fermeture Accred.=DateFermetureAccreditation")]
    [DataMember()]
    public DateTime? DateFermetureAccreditation { get; set; }

    [System.ComponentModel.Description("Early Bird=DateEarlyBird")]
    [DataMember()]
    public DateTime? DateEarlyBird { get; set; }

    [System.ComponentModel.Description("Date Tardif=DateTardif")]
    [DataMember()]
    public DateTime? DateTardif { get; set; }

    [System.ComponentModel.Description("Quota=Quota")]
    [DataMember()]
    public int? Quota { get; set; }

    [System.ComponentModel.Description("$$MessageCloture")]
    [DataMember()]
    public string MessageCloture { get; set; }

    [System.ComponentModel.Description("$$MessageClotureUs")]
    [DataMember()]
    public string MessageClotureUs { get; set; }

    [System.ComponentModel.Description("$$IdCampagneNotifChangement")]
    [DataMember()]
    public int? IdCampagneNotifChangement { get; set; }

    [System.ComponentModel.Description("$$IdCampagneChangementPhoto")]
    [DataMember()]
    public int? IdCampagneChangementPhoto { get; set; }

    [System.ComponentModel.Description("$$IdCampagneRemboursementOk")]
    [DataMember()]
    public int? IdCampagneRemboursementOk { get; set; }

    [System.ComponentModel.Description("$$IdCampagneRemboursementEchec")]
    [DataMember()]
    public int? IdCampagneRemboursementEchec { get; set; }

    [System.ComponentModel.Description("$$IdTarif")]
    [DataMember()]
    public int? IdTarif { get; set; }

    [System.ComponentModel.Description("$$IdTarifEarlyBird")]
    [DataMember()]
    public int? IdTarifEarlyBird { get; set; }

    [System.ComponentModel.Description("$$IdTarifTardif")]
    [DataMember()]
    public int? IdTarifTardif { get; set; }

    [System.ComponentModel.Description("$$IdTarifGratuit")]
    [DataMember()]
    public int? IdTarifGratuit { get; set; }

    [System.ComponentModel.Description("Début réservation=DebutReservation")]
    [DataMember()]
    public string DebutReservation { get; set; }
  }


  [Serializable]
  [DataContract()]
  public class TypeAccreditationData
  {
    [DataMember()]
    public string IdTypeAccreditation { get; set; }

    [DataMember()]
    public string Libelle { get; set; }
  }

  [Serializable]
  [DataContract()]
  public class StatutData
  {
 
    [System.ComponentModel.Description("$$IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("Statut=Statut")]
    [DataMember()]
    public string Statut { get; set; }

    [System.ComponentModel.Description("$$StatutSuivant")]
    [DataMember()]
    public string StatutSuivant { get; set; }

    [System.ComponentModel.Description("$$IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("$$CouleurBo")]
    [DataMember()]
    public string CouleurBo { get; set; }

    [System.ComponentModel.Description("$$Image")]
    [DataMember()]
    public string Image { get; set; }

    [System.ComponentModel.Description("Libelle Fr.=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libelle Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [System.ComponentModel.Description("Libelle Multiple Fr.=LibelleMultipleFr")]
    [DataMember()]
    public string LibelleMultipleFr { get; set; }

    [System.ComponentModel.Description("Libelle Multiple Us=LibelleMultipleUs")]
    [DataMember()]
    public string LibelleMultipleUs { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Organisation?=Organisation")]
    [DataMember()]
    public bool Organisation { get; set; }

    [System.ComponentModel.Description("Sélectionnable?=Selectionnable")]
    [DataMember()]
    public bool Selectionnable { get; set; }

    [System.ComponentModel.Description("Workflow?=Workflow")]
    [DataMember()]
    public bool Workflow { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }
  }

  [Serializable]
  [DataContract()]
  public class StatutDetailData
  {
 
    [System.ComponentModel.Description("$$IdDetail")]
    [DataMember()]
    public string IdStatutDetail { get; set; }

    [System.ComponentModel.Description("$$IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("$$CouleurBo")]
    [DataMember()]
    public string CouleurBo { get; set; }

    [System.ComponentModel.Description("IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }

    [System.ComponentModel.Description("Libellé=Libelle")]
    [DataMember()]
    public string Libelle { get; set; }

    [System.ComponentModel.Description("Libellé Fo Fr=LibelleFoFr")]
    [DataMember()]
    public string LibelleFoFr { get; set; }

    [System.ComponentModel.Description("Libellé Fo Us=LibelleFoUs")]
    [DataMember()]
    public string LibelleFoUs { get; set; }

    [System.ComponentModel.Description("Sélectionnable?=Selectionnable")]
    [DataMember()]
    public bool Selectionnable { get; set; }

    [System.ComponentModel.Description("Black-List Permanent?=BlackListPermanente")]
    [DataMember()]
    public bool BlackListPermanente { get; set; }

    [System.ComponentModel.Description("Black-List Temporaire?=BlackListTemporaire")]
    [DataMember()]
    public bool BlackListTemporaire { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("Refus tunnel=RefusTunnel")]
    [DataMember()]
    public string RefusTunnel { get; set; }
  }

  [DataContract()]
  public class TypeSacData
  {
    [System.ComponentModel.Description("$$IdSac")]
    [DataMember()]
    public string IdSac { get; set; }

    [System.ComponentModel.Description("Sac=Sac")]
    [DataMember()]
    public string Sac { get; set; }
  }

  [DataContract()]
  public class SecteurData
  {
    [System.ComponentModel.Description("$$IdSecteur")]
    [DataMember()]
    public string IdSecteur { get; set; }

    [System.ComponentModel.Description("Secteur=Secteur")]
    [DataMember()]
    public string Secteur { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Date Impression=DateImpression")]
    [DataMember()]
    public DateTime? DateImpression { get; set; }

    [System.ComponentModel.Description("Msg alerte=AlerteDedoublonnage")]
    [DataMember()]
    public string AlerteDedoublonnage { get; set; }
  }

  [DataContract()]
  public class StatutCampagneData
  {
    [System.ComponentModel.Description("$$IdStatutCampagne")]
    [DataMember()]
    public int? IdStatutCampagne { get; set; }

    [System.ComponentModel.Description("$$IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("$$IdSecteur")]
    [DataMember()]
    public string IdSecteur { get; set; }

    [System.ComponentModel.Description("$$Filtre")]
    [DataMember()]
    public string Filtre { get; set; }

    [System.ComponentModel.Description("$$IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }

    [System.ComponentModel.Description("$$IdCampagne")]
    [DataMember()]
    public int? IdCampagne { get; set; }

    [System.ComponentModel.Description("$$IdCampagneContact")]
    [DataMember()]
    public int? IdCampagneContact { get; set; }

    [System.ComponentModel.Description("$$Actif")]
    [DataMember()]
    public bool Actif { get; set; }
  }

  [DataContract()]
  public class StatutProgrammeCampagneData
  {
    [System.ComponentModel.Description("$$IdStatutCampagne")]
    [DataMember()]
    public int? IdStatutCampagne { get; set; }

    [System.ComponentModel.Description("$$IdProgramme")]
    [DataMember()]
    public int? IdProgramme { get; set; }

    [System.ComponentModel.Description("$$IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("$$Filtre")]
    [DataMember()]
    public string Filtre { get; set; }

    [System.ComponentModel.Description("$$IdCampagne")]
    [DataMember()]
    public int? IdCampagne { get; set; }

    [System.ComponentModel.Description("$$IdCampagneContact")]
    [DataMember()]
    public int? IdCampagneContact { get; set; }

    [System.ComponentModel.Description("$$Actif")]
    [DataMember()]
    public bool Actif { get; set; }
  }

  [DataContract()]
  public class OrganisationAccredData
  {

    [System.ComponentModel.Description("$$IdOrganisation")]
    [DataMember()]
    [Key]
    public string IdOrganisation { get; set; }

    [System.ComponentModel.Description("Organisation.Français?=Francais")]
    [DataMember()]
    public bool? Francais { get; set; }

    [System.ComponentModel.Description("Organisation.Gestion Festival?=GestionFestival")]
    [DataMember()]
    public bool? GestionFestival { get; set; }

    [System.ComponentModel.Description("Organisation.Activités=IdActivites")]
    [DataMember()]
    public string IdActivites { get; set; }

    [System.ComponentModel.Description("Organisation.Nom=LibelleInternet")]
    [DataMember()]
    public string LibelleInternet { get; set; }

    [System.ComponentModel.Description("Organisation.Nom Us=LibelleInternetUs")]
    [DataMember()]
    public string LibelleInternetUs { get; set; }

    [System.ComponentModel.Description("Organisation.Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Organisation.Secteur=IdSecteur")]
    [DataMember()]
    public string IdSecteur { get; set; }

    [System.ComponentModel.Description("Organisation.Quota=Quota")]
    [DataMember()]
    public int Quota { get; set; }

    [System.ComponentModel.Description("$$$QuotaPris")]
    [DataMember()]
    public int QuotaPris { get; set; }

    [System.ComponentModel.Description("$$$QuotaPrctPris")]
    [DataMember()]
    public double QuotaPrctPris
    {
      get
      {
        return Math.Round(100 * QuotaPris / (double)Quota, 1);
      }
      set
      {
      }
    }
  }

  [DataContract()]
  public class FonctionData
  {
    [System.ComponentModel.Description("$$IdFonction")]
    [DataMember()]
    public int? IdFonction { get; set; }

    [System.ComponentModel.Description("$$IdSecteur")]
    [DataMember()]
    public string IdSecteur { get; set; }

    [System.ComponentModel.Description("$$IdActivite")]
    [DataMember()]
    public string IdActivite { get; set; }

    [System.ComponentModel.Description("$$IdSpecialite")]
    [DataMember()]
    public string IdSpecialite { get; set; }

    [System.ComponentModel.Description("Importance")]
    [DataMember()]
    public int? Importance { get; set; }

    [System.ComponentModel.Description("Organisation.Emetteur")]
    [DataMember()]
    public string IdEmetteur { get; set; }

    [System.ComponentModel.Description("Organisation.Fonction=Fonction")]
    [DataMember()]
    public string Fonction { get; set; }

    [System.ComponentModel.Description("Organisation.Fonction=FonctionFem")]
    [DataMember()]
    public string FonctionFem { get; set; }

    [System.ComponentModel.Description("Organisation.Fonction US=FonctionUs")]
    [DataMember()]
    public string FonctionUs { get; set; }

    [System.ComponentModel.Description("Organisation.Fonction US=FonctionUsFem")]
    [DataMember()]
    public string FonctionUsFem { get; set; }

    [System.ComponentModel.Description("Organisation.IdFonctionMaster")]
    [DataMember()]
    public int? IdFonctionMaster { get; set; }
  }


  // <DataContract()>
  // Public Class FonctionDetailData
  // <System.ComponentModel.Description("$$IdFonctionDetail")>
  // <DataMember()>
  // Property IdFonctionDetail As Integer

  // <System.ComponentModel.Description("$$IdFonction")>
  // <DataMember()>
  // Property IdFonction As Integer

  // <System.ComponentModel.Description("Fonction=FonctionDetail")>
  // <DataMember()>
  // Property FonctionDetail As String

  // <System.ComponentModel.Description("Fonction=FonctionDetailFem")>
  // <DataMember()>
  // Property FonctionDetailFem As String

  // <System.ComponentModel.Description("Fonction US=FonctionDetailUs")>
  // <DataMember()>
  // Property FonctionDetailUs As String

  // <System.ComponentModel.Description("Fonction US=FonctionDetailUsFem")>
  // <DataMember()>
  // Property FonctionDetailUsFem As String
  // End Class
  [DataContract()]
  public class SpecialiteCinandoData
  {
    [System.ComponentModel.Description("$$IdCinando")]
    [DataMember()]
    public int IdCinando { get; set; }

    [System.ComponentModel.Description("$$IdSpecialite")]
    [DataMember()]
    public string IdSpecialite { get; set; }
  }

  [DataContract()]
  public class SpecialiteData
  {
    [System.ComponentModel.Description("$$IdSpecialite")]
    [DataMember()]
    public string IdSpecialite { get; set; }

    [System.ComponentModel.Description("$$IdActivite")]
    [DataMember()]
    public string IdActivite { get; set; }

    [System.ComponentModel.Description("Organisation.Spécialité=Specialite")]
    [DataMember()]
    public string Specialite { get; set; }

    [System.ComponentModel.Description("Organisation.Spécialité US=SpecialiteUs")]
    [DataMember()]
    public string SpecialiteUs { get; set; }

    [System.ComponentModel.Description("Organisation.Internet?=Internet")]
    [DataMember()]
    public bool Internet { get; set; }

    [System.ComponentModel.Description("Organisation.Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Organisation.Secteur=IdSecteur")]
    [DataMember()]
    public string IdSecteur { get; set; }
  }

  [Serializable]
  [DataContract()]
  public class CiviliteData
  {

    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    [Key]
    public string IdCivilite { get; set; }

    [System.ComponentModel.Description("Civilité=Civilite")]
    [DataMember()]
    public string Civilite { get; set; }

    [System.ComponentModel.Description("Civilité Us=CiviliteUs")]
    [DataMember()]
    public string CiviliteUs { get; set; }

    [System.ComponentModel.Description("Sexe=Sexe")]
    [DataMember()]
    public string Sexe { get; set; }
  }

  [DataContract()]
  public class EtatData
  {
    [System.ComponentModel.Description("$$IdEtat")]
    [DataMember()]
    public string IdEtat { get; set; }

    [System.ComponentModel.Description("$$IdPays")]
    [DataMember()]
    public string IdPays { get; set; }

    [System.ComponentModel.Description("Etat=Etat")]
    [DataMember()]
    public string Etat { get; set; }

    [System.ComponentModel.Description("Etat Us=EtatUs")]
    [DataMember()]
    public string EtatUs { get; set; }

    [System.ComponentModel.Description("$$IdCinando")]
    [DataMember()]
    public int? IdCinando { get; set; }
  }

  [DataContract()]
  public class CategorieData
  {
    [System.ComponentModel.Description("$$IdCategorie")]
    [DataMember()]
    public int? IdCategorie { get; set; }

    [System.ComponentModel.Description("Code")]
    [DataMember()]
    public string Code { get; set; }

    [System.ComponentModel.Description("$$IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }

    [System.ComponentModel.Description("$$IdActivite")]
    [DataMember()]
    public string IdActivite { get; set; }

    [System.ComponentModel.Description("Activité=aActivites")]
    [DataMember()]
    public ActiviteData Activite { get; set; }

    [System.ComponentModel.Description("$$IdSpecialite")]
    [DataMember()]
    public string IdSpecialite { get; set; }

    [System.ComponentModel.Description("Spécialité")]
    [DataMember()]
    public SpecialiteData Specialite { get; set; }

    [System.ComponentModel.Description("Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; }
  }

  [DataContract()]
  public class ServiceData
  {
    [System.ComponentModel.Description("$$IdService")]
    [DataMember()]
    public int? IdService { get; set; }

    [System.ComponentModel.Description("Code=Code")]
    [DataMember()]
    public string Code { get; set; }

    [System.ComponentModel.Description("Service=Service")]
    [DataMember()]
    public string Service { get; set; }

    [System.ComponentModel.Description("Service Us=ServiceUs")]
    [DataMember()]
    public string ServiceUs { get; set; }

    [System.ComponentModel.Description("$$IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }

    [System.ComponentModel.Description("$$IdSecteurs")]
    [DataMember()]
    public string IdSecteurs { get; set; }

    [System.ComponentModel.Description("$$Filtre")]
    [DataMember()]
    public string Filtre { get; set; }

    [System.ComponentModel.Description("Par défaut?=IsDefault")]
    [DataMember()]
    public bool IsDefault { get; set; }
  }


  [DataContract()]
  public class ServiceSocieteData
  {
    [System.ComponentModel.Description("$$IdService")]
    [DataMember()]
    public int? IdService { get; set; }

    [System.ComponentModel.Description("Code=Code")]
    [DataMember()]
    public string Code { get; set; }

    [System.ComponentModel.Description("Service=Service")]
    [DataMember()]
    public string Service { get; set; }

    [System.ComponentModel.Description("Service Us=ServiceUs")]
    [DataMember()]
    public string ServiceUs { get; set; }

    [System.ComponentModel.Description("$$Filtre")]
    [DataMember()]
    public string Filtre { get; set; }

    [System.ComponentModel.Description("Par défaut?=IsDefault")]
    [DataMember()]
    public bool IsDefault { get; set; }
  }

  [DataContract()]
  public class HotelData
  {
    [System.ComponentModel.Description("$$IdHotel")]
    [DataMember()]
    public int IdHotel { get; set; }

    [System.ComponentModel.Description("Nom=Nom")]
    [DataMember()]
    public string Nom { get; set; }

    [System.ComponentModel.Description("Adresse 1=Adresse1")]
    [DataMember()]
    public string Adresse1 { get; set; }

    [System.ComponentModel.Description("Adresse 2=Adresse2")]
    [DataMember()]
    public string Adresse2 { get; set; }

    [System.ComponentModel.Description("Code postal=CodePostal")]
    [DataMember()]
    public string CodePostal { get; set; }

    [System.ComponentModel.Description("Ville=Ville")]
    [DataMember()]
    public string Ville { get; set; }

    [System.ComponentModel.Description("Téléphone=Telephone")]
    [DataMember()]
    public string Telephone { get; set; }

    [System.ComponentModel.Description("Fax=Fax")]
    [DataMember()]
    public string Fax { get; set; }

    [System.ComponentModel.Description("E-mail=Email")]
    [DataMember()]
    public string Email { get; set; }

    [System.ComponentModel.Description("Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Contact=Contact")]
    [DataMember()]
    public string Contact { get; set; }
  }


  [DataContract()]
  public class LangueData
  {
    [System.ComponentModel.Description("$$IdLangue")]
    [DataMember()]
    public string IdLangue { get; set; }

    [System.ComponentModel.Description("Langue=Langue")]
    [DataMember()]
    public string Langue { get; set; }

    [System.ComponentModel.Description("Langue Us=LangueEn")]
    [DataMember()]
    public string LangueEn { get; set; }

    [System.ComponentModel.Description("Langue Vo=LangueVo")]
    [DataMember()]
    public string LangueVo { get; set; }

    [System.ComponentModel.Description("$$CodeIso3")]
    [DataMember()]
    public string CodeIso3 { get; set; }
  }

  [DataContract()]
  public class IndicatifData
  {
    [System.ComponentModel.Description("$$IdPays")]
    [DataMember()]
    public string IdPays { get; set; }

    [System.ComponentModel.Description("Préfixe")]
    [DataMember()]
    public string Prefixe { get; set; }

    [DataMember()]
    public string Indicatif { get; set; }

    [System.ComponentModel.Description("Indicatif Us")]
    [DataMember()]
    public string IndicatifUs { get; set; }
  }

  [DataContract()]
  public class TraitementData
  {
    [System.ComponentModel.Description("$$Identifiant")]
    [DataMember()]
    public int? IdTraitement { get; set; }

    [System.ComponentModel.Description("Couleur=Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("Libellé=Libelle")]
    [DataMember()]
    public string Libelle { get; set; }

    [System.ComponentModel.Description("Visible=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("IdEmetteurs=IdEmetteurs")]
    [DataMember()]
    public string IdEmetteurs { get; set; }
  }

  [DataContract()]
  public class MoisData
  {
    [DataMember()]
    public int IdMois { get; set; }

    [DataMember()]
    public string Mois { get; set; }

    [DataMember()]
    public string MoisUs { get; set; }
  }

  [DataContract()]
  public class AnneeData
  {
    [DataMember()]
    public int IdAnnee { get; set; }

    [DataMember()]
    public string Annee { get; set; }
  }

  [DataContract()]

  public class CategorieFilmData
  {
    [DataMember()]
    public int? IdCategorie { get; set; }

    [DataMember()]
    public string Categorie { get; set; }

    [DataMember()]
    public string CategorieUs { get; set; }
  }

  [DataContract()]
  public class TypeFilmFilmographieData
  {
    [DataMember()]
    public int IdTypeFilmFilmographie { get; set; }

    [DataMember()]
    public string Description { get; set; }

    [DataMember()]
    public string DescriptionUs { get; set; }
  }



  [DataContract()]
  public class GenreFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }


    [System.ComponentModel.Description("IdGenre")]
    [DataMember()]
    public int? IdGenre { get; set; }

    [System.ComponentModel.Description("Genre")]
    [DataMember()]
    public string Genre { get; set; }

    [System.ComponentModel.Description("GenreUs")]
    [DataMember()]
    public string GenreUs { get; set; }
  }

  [DataContract()]
  public class FonctionFilmData
  {
    [DataMember()]
    public int? IdFonction { get; set; }

    [DataMember()]
    public string Fonction { get; set; }

    [DataMember()]
    public string FonctionUs { get; set; }

    [DataMember()]
    public string Profession { get; set; }

    [DataMember()]
    public int? Ordre { get; set; }


    [DataMember()]
    public bool VisibleFo { get; set; }
  }

  public class FonctionPersonneFilmData
  {
    [DataMember()]
    public int? IdFonctionPersonne { get; set; }

    [DataMember()]
    public string FonctionPersonne { get; set; }

    [DataMember()]
    public string FonctionPersonneUs { get; set; }

    [DataMember()]
    public string Profession { get; set; }

    [DataMember()]
    public int? Ordre { get; set; }

    [DataMember()]
    public bool Visible { get; set; }
  }

  public class FonctionContactEcoleData
  {
    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public string Libelle { get; set; }

    [DataMember()]
    public string LibelleUs { get; set; }
  }


  [DataContract()]
  public class SupportExistantFilmData
  {
    [DataMember()]
    public int IdSupportExistant { get; set; }

    [DataMember()]
    public string SupportExistant { get; set; }

    [DataMember()]
    public string SupportExistantUs { get; set; }
  }

  [DataContract()]
  public class ModeRestaurationFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? IdModeRestauration { get; set; }

    [System.ComponentModel.Description("ModeRestauration")]
    [DataMember()]
    public string ModeRestauration { get; set; }
  }

  [DataContract()]
  public class SupportTransmissionFilmData
  {
    [System.ComponentModel.Description("$$Actif_NOSAVE")]
    [DataMember()]
    public bool Actif_NOSAVE { get; set; } = false;

    [System.ComponentModel.Description("IdSupportTransmission")]
    [DataMember()]
    public int? IdSupportTransmission { get; set; }

    [System.ComponentModel.Description("$$IdMillesimeSupportTransmission")]
    [DataMember()]
    public int? IdMillesimeSupportTransmission_NOSAVE { get; set; }

    [System.ComponentModel.Description("SupportTransmission")]
    [DataMember()]
    public string SupportTransmission { get; set; }

    [System.ComponentModel.Description("SupportTransmissionUs")]
    [DataMember()]
    public string SupportTransmissionUs { get; set; }

    [System.ComponentModel.Description("TypeSupport")]
    [DataMember()]
    public int TypeSupport { get; set; }

    [System.ComponentModel.Description("CodeCM")]
    [DataMember()]
    public string CodeCM { get; set; }

    [System.ComponentModel.Description("CodeLM")]
    [DataMember()]
    public string CodeLM { get; set; }

    [System.ComponentModel.Description("IdModeTransmission")]
    [DataMember()]
    public int IdModeTransmission { get; set; }

    [System.ComponentModel.Description("$$Prix_NOSAVE")]
    [DataMember()]
    public double Prix_NOSAVE { get; set; }

    [System.ComponentModel.Description("Ordre")]
    [DataMember()]
    public int? Ordre { get; set; }
  }

  public class MillesimeSupportTransmissionFilmData
  {
    [System.ComponentModel.Description("IdMillesimeSupportTransmission")]
    [DataMember()]
    public int? IdMillesimeSupportTransmission { get; set; }

    [System.ComponentModel.Description("IdSupportTransmission")]
    [DataMember()]
    public int? IdSupportTransmission { get; set; }

    [System.ComponentModel.Description("IdMillesimeModeTransmission")]
    [DataMember()]
    public int? IdMillesimeModeTransmission { get; set; }

    [System.ComponentModel.Description("IdSoif")]
    [DataMember()]
    public int? IdSoif { get; set; }

    // <System.ComponentModel.Description("SupportTransmission")>
    // <DataMember()>
    // Property SupportTransmission As String

    // <System.ComponentModel.Description("TypeSupport")>
    // <DataMember()>
    // Property TypeSupport As Integer

    // <System.ComponentModel.Description("CodeCM")>
    // <DataMember()>
    // Property CodeCM As String

    // <System.ComponentModel.Description("CodeLM")>
    // <DataMember()>
    // Property CodeLM As String

    // <System.ComponentModel.Description("IdModeTransmission")>
    // <DataMember()>
    // Property IdModeTransmission As Integer

    [System.ComponentModel.Description("Prix")]
    [DataMember()]
    public double Prix { get; set; }
  }

  public class ReseauSocialFilmData
  {
    [System.ComponentModel.Description("Identifiant")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }

    [System.ComponentModel.Description("IdReseauSocial")]
    [DataMember()]
    public int? IdReseauSocial { get; set; }

    [System.ComponentModel.Description("ReseauSocial")]
    [DataMember()]
    public string ReseauSocial { get; set; }

    [System.ComponentModel.Description("Url")]
    [DataMember()]
    public string Url { get; set; }

    [System.ComponentModel.Description("ReseauSocialetUrl")]
    [DataMember()]
    public string ReseauSocialetUrl
    {
      get
      {
        return "(" + ReseauSocial + ") " + Url;
      }
      set
      {
      }
    }
  }

  [DataContract()]
  public class FonctionEquipeFilmData
  {
    [DataMember()]
    public int? IdFonctionEquipe { get; set; }

    [DataMember()]
    public string FonctionEquipe { get; set; }

    [System.ComponentModel.Description("$$$FonctionEquipeUs")]
    [DataMember()]
    public string FonctionEquipeUs { get; set; }

    [DataMember()]
    public string Profession { get; set; }

    [DataMember()]
    public int? Ordre { get; set; }

    [DataMember()]
    public bool Visible { get; set; }

    [DataMember()]
    public int IdFonctionPersonne { get; set; }
  }

  [DataContract()]
  public class FonctionSocieteFilmData
  {
    [DataMember()]
    public int? IdFonctionSociete { get; set; }

    [DataMember()]
    public string FonctionSociete { get; set; }

    [DataMember()]
    public int? Ordre { get; set; }
  }

  [DataContract()]
  public class StatutFilmData
  {
    [DataMember()]
    public int? IdStatutFilm { get; set; }


    [System.ComponentModel.Description("Statut=Statut")]
    [DataMember()]
    public string StatutFilm { get; set; }

    [System.ComponentModel.Description("$$StatutSuivant")]
    [DataMember()]
    public string StatutSuivant { get; set; }

    [System.ComponentModel.Description("$$CodesSections")]
    [DataMember()]
    public string CodesSections { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("$$Image")]
    [DataMember()]
    public string Image { get; set; }

    [System.ComponentModel.Description("$$Libelle Fr.=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libelle Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    // <System.ComponentModel.Description("Libelle Multiple Fr.=LibelleMultipleFr")>
    // <DataMember()>
    // Property LibelleMultipleFr As String

    // <System.ComponentModel.Description("Libelle Multiple Us=LibelleMultipleUs")>
    // <DataMember()>
    // Property LibelleMultipleUs As String

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Organisation?=Organisation")]
    [DataMember()]
    public bool Organisation { get; set; }

    [System.ComponentModel.Description("Sélectionnable?=Selectionnable")]
    [DataMember()]
    public bool Selectionnable { get; set; }

    [System.ComponentModel.Description("Workflow?=Workflow")]
    [DataMember()]
    public bool Workflow { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }
  }

  [DataContract()]
  public class SousEtatFilmData
  {
    [DataMember()]
    public int? IdSousEtatFilm { get; set; }

    [System.ComponentModel.Description("$$SousEtatFilm")]
    [DataMember()]
    public string SousEtatFilm { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("$$IdStatut")]
    [DataMember()]
    public int IdStatut { get; set; }

    [System.ComponentModel.Description("$$OldId")]
    [DataMember()]
    public int? OldId { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("CodesSections")]
    [DataMember()]
    public string CodesSections { get; set; }

    [System.ComponentModel.Description("Workflow?=Workflow")]
    [DataMember()]
    public bool Workflow { get; set; }

    [System.ComponentModel.Description("Libellé Fo Fr=LibelleFoFr")]
    [DataMember()]
    public string LibelleFoFr { get; set; }

    [System.ComponentModel.Description("Libellé Fo Us=LibelleFoUs")]
    [DataMember()]
    public string LibelleFoUs { get; set; }

    // <System.ComponentModel.Description("Sélectionnable?=Selectionnable")>
    // <DataMember()>
    // Property Selectionnable As Boolean

    // <System.ComponentModel.Description("Black-List Permanent?=BlackListPermanente")>
    // <DataMember()>
    // Property BlackListPermanente As Boolean

    // <System.ComponentModel.Description("Black-List Temporaire?=BlackListTemporaire")>
    // <DataMember()>
    // Property BlackListTemporaire As Boolean

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }
  }

  [DataContract()]
  public class SectionSelectionFilmData
  {
    [System.ComponentModel.Description("$$IdSectionSelection")]
    [DataMember()]
    public int? IdSectionSelection { get; set; }

    [System.ComponentModel.Description("Libellé")]
    [DataMember()]
    public string Libelle { get; set; }

    [System.ComponentModel.Description("$$LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [System.ComponentModel.Description("Nb. Max Accred.=NbrMaxAccreditation")]
    [DataMember()]
    public int NbrMaxAccreditation { get; set; }

    [System.ComponentModel.Description("Nb.gratuits=NbrGratuits")]
    [DataMember()]
    public int NbrGratuits { get; set; }

    [System.ComponentModel.Description("Nb. Max Accompagnant=NbrMaxAccompagnants")]
    [DataMember()]
    public int NbrMaxAccompagnants { get; set; }

    [System.ComponentModel.Description("$$EstArchivee")]
    [DataMember()]
    public bool EstArchivee { get; set; }

    [System.ComponentModel.Description("Affiche en résa?=DisplayResa")]
    [DataMember()]
    public bool DisplayResa { get; set; }

    [System.ComponentModel.Description("Caméra d'or?=UseCameraDor")]
    [DataMember()]
    public bool UseCameraDor { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("$$CategorySectionSelection")]
    [DataMember()]
    public int CategorySectionSelection { get; set; }

    [System.ComponentModel.Description("Section d'inscription=SectionInscriptionLiee")]
    [DataMember()]
    public string SectionInscriptionLiee { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("$$ Id Memo dossier du selectionné Fr")]
    [DataMember()]
    public int? IdReport { get; set; }

    [System.ComponentModel.Description("$$ Id Memo dossier du selectionné En")]
    [DataMember()]
    public int? IdReportUs { get; set; }

    [System.ComponentModel.Description("$$ Id Campagne Notif nouvelle modification dossier sélectionné ")]
    [DataMember()]
    public int? IdCampagneModifDossier { get; set; }

    [System.ComponentModel.Description("$$ Id Campagne choix d'envoi en BO - Relance completion dossier")]
    [DataMember()]
    public int? IdCampagneRelanceDossier { get; set; }

    [System.ComponentModel.Description("Groupes=Groupes")]
    [DataMember()]
    public string Groupes { get; set; }
  }

  [DataContract()]
  public class SousSectionSelectionFilmData
  {
    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public string Libelle { get; set; }

    [DataMember()]
    public string LibelleUs { get; set; }

    [DataMember()]
    public bool EstArchivee { get; set; }
  }

  [DataContract()]
  public class ModeTransmissionFilmData
  {
    [DataMember()]
    public bool Actif { get; set; } = false;

    [DataMember()]
    public int? IdModeTransmission { get; set; }

    [DataMember()]
    public string ModeTransmission { get; set; }

    [DataMember()]
    public string ModeTransmissionUs { get; set; }

    [DataMember()]
    public double? Frais { get; set; }

    [DataMember()]
    public int? Ordre { get; set; }
  }



  [DataContract()]
  public class SupportMediaData
  {
    [System.ComponentModel.Description("$$IdSupportMedia")]
    [DataMember()]
    public int? IdSupportMedia { get; set; }

    [System.ComponentModel.Description("Visible Bo?=VisibleBo")]
    [DataMember()]
    public bool VisibleBo { get; set; }

    [System.ComponentModel.Description("Visible Fo?=VisibleFo")]
    [DataMember()]
    public bool VisibleFo { get; set; }

    [System.ComponentModel.Description("Support Fr?=SupportMedia")]
    [DataMember()]
    public string SupportMedia { get; set; }

    [System.ComponentModel.Description("Support Us?=SupportMediaUs")]
    [DataMember()]
    public string SupportMediaUs { get; set; }

    [System.ComponentModel.Description("$$SupportMediaFunctionKey")]
    [DataMember()]
    public string SupportMediaFunctionKey { get; set; }
  }

  [DataContract()]
  public class SupportJournalisteData
  {
    [System.ComponentModel.Description("$$IdSupportJournaliste")]
    [DataMember()]
    public int? IdSupportJournaliste { get; set; }

    [System.ComponentModel.Description("Visible Bo?=VisibleBo")]
    [DataMember()]
    public bool VisibleBo { get; set; }

    [System.ComponentModel.Description("Visible Fo?=VisibleFo")]
    [DataMember()]
    public bool VisibleFo { get; set; }

    [System.ComponentModel.Description("Support Fr?=SupportJournaliste")]
    [DataMember()]
    public string SupportJournaliste { get; set; }

    [System.ComponentModel.Description("Support Us?=SupportJournalisteUs")]
    [DataMember()]
    public string SupportJournalisteUs { get; set; }
  }

  [Serializable]
  [DataContract()]
  public class EmissionData
  {
    [System.ComponentModel.Description("$$IdEmission")]
    [DataMember()]
    public int? IdEmission { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Nom=NomEmission")]
    [DataMember()]
    public string NomEmission { get; set; }

    [System.ComponentModel.Description("Horaire=Horaire")]
    [DataMember()]
    public string Horaire { get; set; }

    [System.ComponentModel.Description("Périodicité=Periodicite")]
    [DataMember()]
    public string Periodicite { get; set; }

    [System.ComponentModel.Description("Audience=Audience")]
    [DataMember()]
    public string Audience { get; set; }

    [System.ComponentModel.Description("Nb. Diffusion=NbDiffusion")]
    [DataMember()]
    public string NbDiffusion { get; set; }
  }

  [Serializable]
  [DataContract()]
  public class ProfessionData
  {
    [System.ComponentModel.Description("$$IdProfession")]
    [DataMember()]
    public int? IdProfession { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Profession=Profession")]
    [DataMember()]
    public string Profession { get; set; }

    [System.ComponentModel.Description("ProfessionUs=Profession Us")]
    [DataMember()]
    public string ProfessionUs { get; set; }

    [System.ComponentModel.Description("ProfessionF=Profession Féminin")]
    [DataMember()]
    public string ProfessionF { get; set; }

    [System.ComponentModel.Description("ProfessionUsF=Profession Féminin Us")]
    [DataMember()]
    public string ProfessionUsF { get; set; }
  }

}
