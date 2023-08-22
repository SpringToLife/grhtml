using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class OperationData
  {
    

    [DataMember()]
    [System.ComponentModel.Description("$$IdUtilisateurModification")]
    public int? IdUtilisateurModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Identifiant=IdOperation")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSequence")]
    public int? IdSequence { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdTypeOperation")]
    public int? IdTypeOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Année=Annee")]
    public string Annee { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSociete")]
    public int? IdSociete { get; set; }

    // <DataMember()>
    // <System.ComponentModel.Description("$$IdAccreditation")>
    // Property IdAccreditation As Integer?

    // <DataMember()>
    // <System.ComponentModel.Description("$$IdDossierInscription")>
    // Property IdDossierInscription As Integer?

    [DataMember()]
    [System.ComponentModel.Description("$$Filtre")]
    public string Filtre { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdEnreg")]
    public int? IdEnreg { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("Identifiant Personne")]
    public int? IdPersonne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSocieteBeneficiaire")]
    public int? IdSocieteBeneficiaire { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Id. Sage=Sage_Ec_No")]
    public int? Sage_Ec_No { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Intitulé=Intitule")]
    public string Intitule { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Synchronisé?=Synchroniser")]
    public bool Synchroniser { get; set; } = false;

    // <DataMember()>
    // <System.ComponentModel.Description("$$Lettré?")>
    // Property IsLettre As Boolean = False

    [DataMember()]
    [System.ComponentModel.Description("Lettrage=Lettrage")]
    public string Lettrage { get; set; } = "";

    [DataMember()]
    [System.ComponentModel.Description("Emetteur=IdEmetteur")]
    public string IdEmetteur { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("Description")]
    public string Description
    {
      get
      {
        if (TypeOperation == null)
          return "";
        else
          return TypeOperation.Libelle + " " + MontantTTC.ToString("c") + " : " + Intitule;
      }
      set
      {
      }
    }

    [DataMember()]
    [System.ComponentModel.Description("Dernière modification=DateModification")]
    public DateTime DateModification { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date opération=DateOperation")]
    public DateTime DateOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdModeReglement")]
    public int? IdModeReglement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdDevise")]
    public int? IdDevise { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdJournal")]
    public int? IdJournal { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdBordereau")]
    public int? IdBordereau { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° facture=NumeroFacture")]
    public string NumeroFacture { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° Tva intra.=NumeroTvaIntra")]
    public string NumeroTvaIntra { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° carte=NumeroCarte")]
    public string NumeroCarte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$CVV")]
    public string Cvv { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Expire")]
    public string Expire { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant TVA=MontantTva")]
    public double MontantTva { get; set; }

    // <DataMember()>
    // <System.ComponentModel.Description("Mtt TVA")>
    // Property MontantTvaStr As String
    // Get
    // Dim _Mtt As String = CSng(MontantTva).ToString("N2")
    // If Devise Is Nothing Then
    // Return _Mtt + " €"
    // Else
    // Return _Mtt + Devise.Code
    // End If
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [DataMember()]
    [System.ComponentModel.Description("Crédit")]
    public double? Credit
    {
      get
      {
        if (TypeOperation != null && TypeOperation.Sens == 1)
          return MontantTTC;
        else
          return default(Double?);
      }
      set
      {
      }
    }

    [DataMember()]
    [System.ComponentModel.Description("Débit")]
    public double? Debit
    {
      get
      {
        if (TypeOperation != null && TypeOperation.Sens == 0)
          return MontantTTC; // Str
        else
          return default(Double?);
      }
      set
      {
      }
    }

    [DataMember()]
    [System.ComponentModel.Description("Montant HT")]
    public double MontantHt
    {
      get
      {
        return MontantTTC - MontantTva;
      }
      set
      {
      }
    }

    // <DataMember()>
    // <System.ComponentModel.Description("Mtt HT")>
    // Property MontantHtStr As String
    // Get
    // Dim _Mtt As String = MontantHt.ToString("N2")
    // If Devise Is Nothing Then
    // Return _Mtt + " €"
    // Else
    // Return _Mtt + Devise.Code
    // End If
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [DataMember()]
    [System.ComponentModel.Description("Montant TTC=Montant")]
    public double MontantTTC { get; set; }

    // <DataMember()>
    // <System.ComponentModel.Description("Mtt TTC")>
    // Property MontantTTCStr As String
    // Get
    // Dim _Mtt As String = MontantTTC.ToString("N2")
    // If Devise Is Nothing Then
    // Return _Mtt + " €"
    // Else
    // Return _Mtt + " " + Devise.Code
    // End If

    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [DataMember()]
    [System.ComponentModel.Description("Montant en devise=MontantDevise")]
    public double? MontantDevise { get; set; }

    // <DataMember()>
    // <System.ComponentModel.Description("Mtt Devise")>
    // Property MontantDeviseStr As String
    // Get
    // If MontantDevise Is Nothing Then
    // Return ""
    // Else
    // Dim _Mtt As String = CSng(MontantDevise).ToString("N2")
    // If Devise Is Nothing Then
    // Return _Mtt + " €"
    // Else
    // Return _Mtt + Devise.Code
    // End If
    // End If
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [DataMember()]
    [System.ComponentModel.Description("Montant Rembt TVA=MontantRembtTva")]
    public double? MontantRembtTva { get; set; }

    // <DataMember()>
    // <System.ComponentModel.Description("Mtt Rembt TVA")>
    // Property MontantRembtTvaStr As String
    // Get
    // If MontantRembtTva Is Nothing Then
    // Return ""
    // Else
    // Dim _Mtt As String = CSng(MontantRembtTva).ToString("N2")
    // If Devise Is Nothing Then
    // Return _Mtt + " €"
    // Else
    // Return _Mtt + Devise.Code
    // End If
    // End If
    // End Get
    // Set(value As String)

    // End Set
    // End Property

    [DataMember()]
    [System.ComponentModel.Description("Reste à payer=ResteAPayer")]
    public double? ResteAPayer { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Reste à payer échu=ResteAPayer")]
    public double? ResteAPayerEchu { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Chèque français?=ChequeFrancais")]
    public bool? ChequeFrancais { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Adresse de facturation=AdresseFacturation")]
    public string AdresseFacturation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Fichier=Fichier")]
    public string Fichier { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Version=Version")]
    public int Version { get; set; } = 1;

    [DataMember()]
    [System.ComponentModel.Description("Conditions de règlement=ConditionReglement")]
    public string ConditionReglement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 1=Date1")]
    public DateTime? Date1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt échance 1=Montant1")]
    public double? Montant1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 2=Date2")]
    public DateTime? Date2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt échance 2=Montant2")]
    public double? Montant2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 3=Date3")]
    public DateTime? Date3 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt échance 3=Montant3")]
    public double? Montant3 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 4=Date4")]
    public DateTime? Date4 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt échance 4=Montant4")]
    public double? Montant4 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 5=Date5")]
    public DateTime? Date5 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt échance 5=Montant5")]
    public double? Montant5 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 6=Date6")]
    public DateTime? Date6 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt échance 6=Montant6")]
    public double? Montant6 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Notes=Notes")]
    public string Notes { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Payé?=paye")]
    public bool Paye { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("IdReport")]
    public int? IdReport { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Bordereau=fBordereaux")]
    public BordereauData Bordereau { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Journal=fJournaux")]
    public JournalData Journal { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Devise=fDevises")]
    public DeviseData Devise { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mode de règlement=fModesReglement")]
    public ModeReglementData ModeReglement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Domaine=fSequences")]
    public SequenceData Sequence { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type opération=fTypesOperations")]
    public TypeOperationData TypeOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Société=Societes")]
    public SocieteData Societe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Personne=Personnes")]
    public PersonneData Personne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Transaction")]
    public TransactionData Transaction { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Lignes")]
    public List<FactureLigneData> Lignes { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TauxTva1")]
    public double? TauxTva1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TotalTauxTva1")]
    public double? TotalTauxTva1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TauxTva2")]
    public double? TauxTva2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TotalBaseTva1")]
    public double? TotalBaseTva1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TotalTauxTva2")]
    public double? TotalTauxTva2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TotalBaseTva2")]
    public double? TotalBaseTva2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TauxTva3")]
    public double? TauxTva3 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TotalTauxTva3")]
    public double? TotalTauxTva3 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TotalBaseTva3")]
    public double? TotalBaseTva3 { get; set; }
  }

  [DataContract()]
  public class AnalytiqueData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdAnalytique")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Visible?=Visible")]
    public bool Visible { get; set; } = true;

    [DataMember()]
    [System.ComponentModel.Description("$$IdSequence")]
    public int IdSequence { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Défaut?=Defaut")]
    public bool Defaut { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code=Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé+Code")]
    public string LibelleCode
    {
      get
      {
        return Libelle + " (" + Code + ")";
      }
      set
      {
      }
    }

    [DataMember()]
    [System.ComponentModel.Description("$$description")]
    public string Description
    {
      get
      {
        return Code + " - " + Libelle;
      }
      set
      {
      }
    }
  }

  [DataContract()]
  public class AnalytiqueCompteData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdAnalytiqueCompte")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdAnalytique")]
    public int? IdAnalytique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Taux Tva=TauxTva")]
    public double TauxTva { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Cg Num=Cg_Num")]
    public string Cg_Num { get; set; }
  }


  [DataContract()]
  public class BordereauData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdBordereau")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Numéro=Numero")]
    public string Numero { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date de remise=DateRemise")]
    public DateTime DateRemise { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nombre de chèque=Nombre")]
    public int Nombre { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant Total=Montant")]
    public double Montant { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt")]
    public string MontantStr
    {
      get
      {
        string _Mtt = Montant.ToString("N2");
        if (Devise == null)
          return _Mtt + " €";
        else
          return _Mtt + Devise.Code;
      }
      set
      {
      }
    }

    [DataMember()]
    [System.ComponentModel.Description("$$IdDevise")]
    public int? IdDevise { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Devise")]
    public DeviseData Devise { get; set; }
  }

  [DataContract()]
  public class ConditionReglementData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdConditionReglement")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Visible?=Visible")]
    public bool Visible { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nom=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Texte Fr.=Texte")]
    public string Texte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Texte Us=Texte")]
    public string TexteUs { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 1=Date1")]
    public DateTime? Date1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("% échéance 1=Pourcentage1")]
    public double? Pourcentage1 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 2=Date2")]
    public DateTime? Date2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("% échéance 2=Pourcentage2")]
    public double? Pourcentage2 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 3=Date3")]
    public DateTime? Date3 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("% échéance 3=Pourcentage3")]
    public double? Pourcentage3 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 4=Date4")]
    public DateTime? Date4 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("% échéance 4=Pourcentage4")]
    public double? Pourcentage4 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date échéance 5=Date5")]
    public DateTime? Date5 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("% échéance 5=Pourcentage5")]
    public double? Pourcentage5 { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("Date échéance 6=Date6")]
    public DateTime? Date6 { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("% échéance 6=Pourcentage6")]
    public double? Pourcentage6 { get; set; }
  }


  [DataContract()]
  public class DeviseData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdDevise")]
    public int Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Visible?=Visible")]
    public bool Visible { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Taux de change=Change")]
    public double Change { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Sage_N_Devise")]
    public string Sage_N_Devise { get; set; }
  }

  [DataContract()]
  public class FactureLigneData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdFactureLigne")]
    public int? Id { get; set; }

    [System.ComponentModel.Description("$$Librairie")]
    [IgnoreDataMember]
    public string Library { get; set; } = "Services.Comptabilite.ComptabiliteClient, Services";

    [System.ComponentModel.Description("$$LibrairieDirecte")]
    [IgnoreDataMember]
    public string LibraryDirect { get; set; } = "WcfService.Comptabilite, WcfService";

    [System.ComponentModel.Description("$$ReportData")]
    [IgnoreDataMember]
    public string ReportData { get; set; } = "GetListLignes";

    [DataMember()]
    [System.ComponentModel.Description("$$IdFacture")]
    public int IdFacture { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdAnalytique")]
    public int? IdAnalytique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$CompteAnalytique")]
    public int? CompteAnalytique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$CodeAnalytique")]
    public string CodeAnalytique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Taux Tva=TauxTva")]
    public double TauxTva { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant HT=MontantHt")]
    public double? MontantHt { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ordre")]
    public int Ordre { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Impr.?=ImprimerMontant")]
    public bool ImprimerMontant { get; set; } = true;

    // Indispensable pour l'impression
    [DataMember()]
    [System.ComponentModel.Description("Facture")]
    public OperationData Facture { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("MontantTTc")]
    public double? MontantTtc
    {
      get
      {
        if (MontantHt == null)
          return default(Double?);
        else
          return System.Convert.ToDouble(MontantHt) + (System.Convert.ToDouble(MontantHt) * TauxTva / 100);
      }
      set
      {
      }
    }


    [DataMember()]
    [System.ComponentModel.Description("MontantTTc")]
    public double? Tva
    {
      get
      {
        if (MontantHt == null)
          return default(Double?);
        else
          return (System.Convert.ToDouble(MontantHt) * TauxTva / 100);
      }
      set
      {
        if (MontantHt == null)
          TauxTva = 0;
        else
          TauxTva = System.Convert.ToDouble(100 * value / (double)MontantHt);
      }
    }
  }

  [DataContract()]
  public class ModeReglementData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdModeReglement")]
    public int? Id { get; set; }

    // <DataMember()>
    // <System.ComponentModel.Description("Visible?=Visible")>
    // Property Visible As Boolean

    [DataMember()]
    [System.ComponentModel.Description("Online?=Online")]
    public bool OnLine { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Tpe?=Tpe")]
    public bool Tpe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Sage_N_Reglement")]
    public string Sage_N_Reglement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Cg Num=Cg_Num")]
    public string Cg_Num { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type règlement=TypeReglement")]
    public string TypeReglement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ordre")]
    public int Ordre { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdJournal")]
    public int? IdJournal { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdPaybox")]
    public int? IdPaybox { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Groupes")]
    public string Groupes { get; set; }
  }

  [DataContract()]
  public class ReleveData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$Identifiant")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Paybox=Paybox")]
    public string Paybox { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Bank=Bank")]
    public string Bank { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Rank=Rank")]
    public string Rank { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Id Paybox=IdPaybox")]
    public string IdPaybox { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date=DatePaybox")]
    public DateTime DatePaybox { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Statut=Statut")]
    public string Statut { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type Carte=TypeCarte")]
    public string TypeCarte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. Opération=NbOperation")]
    public int NbOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Fichier=Fichier")]
    public string Fichier { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Mtt Paybox=MontantPaybox")]
    public double MontantPaybox { get; set; }
  }

  [DataContract()]
  public class ReleveDetailData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdReleveDetail")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("IdReleve")]
    public int IdReleve { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("IdOperation")]
    public int? IdOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("IdAppel")]
    public string IdAppel { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("DateOfIssue")]
    public DateTime DateOfIssue { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("HourOfIssue")]
    public string HourOfIssue { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("DateOfExpiration")]
    public DateTime DateOfExpiry { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Reference")]
    public string Reference { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("EmailCustomer")]
    public string EmailCustomer { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type")]
    public string Type { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Canal")]
    public string Canal { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("NumberOfAuthorization")]
    public string NumberOfAuthorization { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Amount")]
    public double Amount { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Currency")]
    public string Currency { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Entity")]
    public string Entity { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Operator")]
    public string Operateur { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Country")]
    public string Country { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("CardType")]
    public string CardType { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("RefArchive")]
    public string RefArchive { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Règlement")]
    public OperationData Operation { get; set; }
  }

  [DataContract()]
  public class SequenceData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdSequence")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé Fr.=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé Us.=LibelleUs")]
    public string LibelleUs { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Préfixe=Prefixe")]
    public string Prefixe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Force Tva?=ForceTva")]
    public bool ForceTva { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Visible Bo?=VisibleBo")]
    public bool VisibleBo { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Visible Fo?=VisibleFo")]
    public bool VisibleFo { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ordre Fo=OrdreFo")]
    public int? OrdreFo { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdConditionReglement")]
    public int? IdConditionReglement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Groupes")]
    public string Groupes { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("A synchroniser?=ASynchroniser")]
    public bool ASynchroniser { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Compte tiers=CompteTiers")]
    public string CompteTiers { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Contact")]
    public string Contact { get; set; }
  }


  [DataContract()]
  public class TransactionData
  {
    [DataMember()]
    [System.ComponentModel.Description("Identifiant=IdTransaction")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdOperation")]
    public int? IdOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdEnreg")]
    public int? IdEnreg { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date=DateCreation")]
    public DateTime DateCreation { get; set; }

    [DataMember()]
    public string CodeReponse { get; set; }

    [DataMember()]
    public string Id3d { get; set; }

    [DataMember()]
    public int? IdCompte { get; set; }

    [DataMember()]
    public string Erreur { get; set; }

    [DataMember()]
    public string Commentaire { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° Autorisation=Autorisation")]
    public string Autorisation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° Transaction=NumTrans")]
    public string NumTrans { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° Appel=NumAppel")]
    public string NumAppel { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("N° Question=NumQuestion")]
    public string NumQuestion { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Site")]
    public string Site { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Rang")]
    public string Rang { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Identifiant client=Identifiant")]
    public string Identifiant { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nom porteur=Porteur")]
    public string Porteur { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Pays")]
    public string Pays { get; set; }
  }

  [DataContract()]
  public enum eTypeSaisie
  {
    [EnumMember]
    Facture,
    [EnumMember]
    Reglement,
    [EnumMember]
    Ecart,
    [EnumMember]
    Combo
  }

  [DataContract()]
  public class TypeOperationData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdTypeOperation")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code=Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Sens=Sens")]
    public int Sens { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$TypeSaisie")]
    public eTypeSaisie TypeSaisie { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Journal=Sage_Journal")]
    public string Sage_Journal { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Couleur")]
    public string Couleur { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type Paybox=TypePaybox")]
    public string TypePaybox { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("A synchroniser?=ASynchroniser")]
    public bool ASynchroniser { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Base")]
    public string Base { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Groupes=Groupes")]
    public string Groupes { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdReport")]
    public int? IdReport { get; set; }
  }

  [DataContract()]
  public class TypeOperationReportData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$Id")]
    public int? IdfReport { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSequence")]
    public int? IdSequence { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdTypeOperation")]
    public int? IdTypeOperation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdReport")]
    public int? IdReport { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Condition")]
    public string Condition { get; set; }
  }

  [DataContract()]
  public class TarifData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdTarif")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Actif?=Actif")]
    public bool Actif { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSequence")]
    public int? IdSequence { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Taux Tva=TauxTva")]
    public double TauxTva { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Prix")]
    public List<PrixData> Prix { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant")]
    public double Montant { get; set; } = 0;

    [DataMember()]
    [System.ComponentModel.Description("Livraison?=Livraison")]
    public bool Livraison { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Tva obligatoire?=TvaObligatoire")]
    public bool TvaObligatoire { get; set; }
  }

  [DataContract()]
  public class CalcPrixData
  {
    [DataMember()]
    public double MontantHt { get; set; } = 0;

    [DataMember()]
    public double MontantTva { get; set; } = 0;

    [DataMember()]
    public double MontantTtc
    {
      get
      {
        return Math.Round(MontantHt, 2) + Math.Round(MontantTva, 2);
      }
      set
      {
      }
    }
  }

  [DataContract()]
  public class PrixData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$IdPrix")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdTarif")]
    public int? IdTarif { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdAnalytique")]
    public int? IdAnalytique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("No ligne=NoLigne")]
    public int? NoLigne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant=Montant")]
    public double Montant { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$MontantTe")]
    public double MontantTe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Taux Tva=TauxTva")]
    public double? TauxTva { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code=Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ligne=Ligne")]
    public string Ligne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ligne Us=LigneUs")]
    public string LigneUs { get; set; }
  }

  [DataContract()]
  public class CodePromoGenereData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$Identifiant=IdCodePromo")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdUtilisateurCreation")]
    public int? IdUtilisateurCreation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Créateur=Utilisateurs_Nom")]
    public string Createur { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date création=DateCreation")]
    public DateTime? DateCreation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Util. Unique?=UtilisationUnique")]
    public bool UtilisationUnique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code=Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Emetteur=Emetteur")]
    public string Emetteur { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSociete")]
    public int? IdSociete { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("Société affecté")]
    public SocieteData SocieteAffecte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Société utilisé")]
    public SocieteData SocieteUtilise { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdPersonne")]
    public int? IdPersonne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Utilisé par")]
    public PersonneData Personne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSocieteAffecte")]
    public int? IdSocieteAffecte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdPersonneAffecte")]
    public int? IdPersonneAffecte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date début=DateDebut")]
    public DateTime? DateDebut { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date fin=DateFin")]
    public DateTime? DateFin { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date Util.=DateDerniereUtilisation")]
    public DateTime? DateDerniereUtilisation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant=Montant")]
    public double? Montant { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant Fixe=MontantFixe")]
    public double? MontantFixe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Pourcentage=Pourcentage")]
    public double? Pourcentage { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Paiement différé?=PaiementDiffere")]
    public bool? PaiementDiffere { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. Montant Fixe=NbMontantFixe")]
    public int? NbMontantFixe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. badges gratuits?=BadgesGratuits")]
    public int? BadgesGratuits { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. online gratuits?=OnlineGratuits")]
    public int? OnlineGratuits { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. PN gratuits?=PnGratuits")]
    public int? PnGratuits { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. Tarif Contrib Env.?=NbCarbone")]
    public int? NbCarbone { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ligne Facture=Facture")]
    public string Facture { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Modèle=ModeleCode")]
    public string ModeleCode { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$MontantCalcule")]
    public double? MontantCalcule { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$CodeContexte")]
    public string Contexte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Contexte")]
    public string LibelleContexte { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdUtilisation")]
    public int? IdUtilisation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type accred.=TypeAccred")]
    public string TypeAccred { get; set; }
  }

  [DataContract()]
  public class CodePromoGenereUtilisationData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$Identifiant=IdCodePromo")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdCodePromoGenere")]
    public int? IdCodePromoGenere { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date utilisation=DateUtilisation")]
    public DateTime? DateUtilisation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdSociete")]
    public int? IdSociete { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Société utilisé")]
    public SocieteData Societe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$IdPersonne")]
    public int? IdPersonne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Utilisé par")]
    public PersonneData Personne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb=Nb")]
    public int? Nb { get; set; }
  }


  [DataContract()]
  public class CodePromoData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$Identifiant=IdCodePromo")]
    public int? Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Util. Unique?=UtilisationUnique")]
    public bool UtilisationUnique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code=Code")]
    public string Code { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libelle=Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date début=DateDebut")]
    public DateTime? DateDebut { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date fin=DateFin")]
    public DateTime? DateFin { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant=Montant")]
    public double? Montant { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Montant Fixe=MontantFixe")]
    public double? MontantFixe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Pourcentage=Pourcentage")]
    public double? Pourcentage { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Paiement différé?=PaiementDiffere")]
    public bool? PaiementDiffere { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. Montant Fixe=NbMontantFixe")]
    public int? NbMontantFixe { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. badges gratuits?=BadgesGratuits")]
    public int? BadgesGratuits { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. online gratuits?=OnlineGratuits")]
    public int? OnlineGratuits { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. PN gratuits?=PnGratuits")]
    public int? PnGratuits { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Nb. Tarif Contrib Env.?=NbCarbone")]
    public int? NbCarbone { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code Contexte=Contexte")]
    public string Contexte { get; set; }


    [DataMember()]
    [System.ComponentModel.Description("Ligne Facture FR=FactureFr")]
    public string FactureFR { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Ligne Facture US=FactureUS")]
    public string FactureUS { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Type accred.=TypeAccred")]
    public string TypeAccred { get; set; }
  }

  [DataContract()]
  public class CodePromoContexteData
  {
    [DataMember()]
    public int? IdContexte { get; set; }

    [DataMember()]
    public string Libelle { get; set; }

    [DataMember()]
    public string Code { get; set; }
  }

  [DataContract()]
  public class JournalData
  {
    [DataMember()]
    [System.ComponentModel.Description("$$Identifiant=IdJournal")]
    public int Id { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libelle")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Code Sage=CodeSage")]
    public string CodeSage { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Visible?=Visible")]
    public bool Visible { get; set; }
  }


  [DataContract()]
  public class DesData
  {
    [DataMember()]
    public string Tva { get; set; }

    [DataMember()]
    public double? Facture { get; set; }

    [DataMember()]
    public double Avoir { get; set; }

    [DataMember()]
    public string Societe { get; set; }
  }

  public class TvaData
  {
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public bool Valide { get; set; }
    public bool Defaut { get; set; }
  }

  [DataContract()]
  public class PayboxData
  {
    [DataMember()]
    public int IdPaybox { get; set; }

    [DataMember()]
    public string Description { get; set; }

    [DataMember()]
    public string Cle { get; set; }

    [DataMember()]
    public string Rang { get; set; }

    [DataMember()]
    public string Site { get; set; }

    [DataMember()]
    public string IdMerchantVisa { get; set; }

    [DataMember()]
    public string IdMerchantAmex { get; set; }
  }
}
