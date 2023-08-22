using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
namespace GrapesJsEditorHtml.ViewModel
{
  public class MarcheProduitData
  {
    
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public int? Id { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; } = true;

    [System.ComponentModel.Description("$$IdTypeProduit")]
    [DataMember()]
    public int? IdTypeProduit { get; set; }

    [System.ComponentModel.Description("Type Produit=mTypesProduits")]
    [DataMember()]
    public MarcheTypeProduitData TypeProduit { get; set; }

    [System.ComponentModel.Description("Référence=Reference")]
    [DataMember()]
    public string Reference { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [System.ComponentModel.Description("Description Fr=DescriptionFr")]
    [DataMember()]
    public string DescriptionFr { get; set; }

    [System.ComponentModel.Description("Description Us=DescriptionUs")]
    [DataMember()]
    public string DescriptionUs { get; set; }

    [System.ComponentModel.Description("Facture Fr=FactureFr")]
    [DataMember()]
    public string FactureFr { get; set; }

    [System.ComponentModel.Description("Facture Us=FactureUs")]
    [DataMember()]
    public string FactureUs { get; set; }

    [System.ComponentModel.Description("Image=Image")]
    [DataMember()]
    public string Image { get; set; }

    [System.ComponentModel.Description("$$IdSequence")]
    [DataMember()]
    public int? IdSequence { get; set; }

    [System.ComponentModel.Description("$$IdAnalytique")]
    [DataMember()]
    public int? IdAnalytique { get; set; }

    [System.ComponentModel.Description("$$IdMenu")]
    [DataMember()]
    public int? IdMenu { get; set; }

    [System.ComponentModel.Description("Prix Ht=PrixHt")]
    [DataMember()]
    public double? PrixHt { get; set; }

    [System.ComponentModel.Description("Base Surface=BaseSurface")]
    [DataMember()]
    public int? BaseSurface { get; set; }

    [System.ComponentModel.Description("Prix Suppl. HT=PrixSupplementaireHT")]
    [DataMember()]
    public double? PrixSupplementaireHT { get; set; }

    [System.ComponentModel.Description("Quota Total=QuotaTotal")]
    [DataMember()]
    public int? QuotaTotal { get; set; }

    [System.ComponentModel.Description("Quota par Société=QuotaSociete")]
    [DataMember()]
    public int? QuotaSociete { get; set; }

    [System.ComponentModel.Description("Base dégressif=BaseDegressif")]
    [DataMember()]
    public int? BaseDegressif { get; set; }

    [System.ComponentModel.Description("Prix dégressif HT=PrixDegressifHT")]
    [DataMember()]
    public double? PrixDegressifHT { get; set; }

    [System.ComponentModel.Description("$$IdTypeSet")]
    [DataMember()]
    public int? IdTypeSet { get; set; }

    [System.ComponentModel.Description("Type Set=mTypesSet")]
    [DataMember()]
    public MarcheTypeSetData TypeSet { get; set; }

    [System.ComponentModel.Description("$$IdFournisseur")]
    [DataMember()]
    public int? IdFournisseur { get; set; }

    [System.ComponentModel.Description("Fournisseur=mFournisseurs")]
    [DataMember()]
    public MarcheFournisseurData Fournisseur { get; set; }

    [System.ComponentModel.Description("$$IdProduitGroupe")]
    [DataMember()]
    public int? IdProduitGroupe { get; set; }

    [System.ComponentModel.Description("Produit Groupe=mProduitsGroupes")]
    [DataMember()]
    public MarcheProduitGroupeData ProduitGroupe { get; set; }

    [System.ComponentModel.Description("Besoin install.?=Installation")]
    [DataMember()]
    public bool? Installation { get; set; }

    [System.ComponentModel.Description("$$IdCouleur")]
    [DataMember()]
    public int? IdCouleur { get; set; }

    [System.ComponentModel.Description("$$IdReport")]
    [DataMember()]
    public int? IdReport { get; set; }

    [System.ComponentModel.Description("$$IdLieu")]
    [DataMember()]
    public string IdLieu { get; set; }

    [System.ComponentModel.Description("Assurance=Assurance")]
    [DataMember()]
    public string Assurance { get; set; }

    [System.ComponentModel.Description("Force TVA=ForceTva")]
    [DataMember()]
    public bool ForceTva { get; set; } = false;

    [System.ComponentModel.Description("Taux Tva=TauxTva")]
    [DataMember()]
    public double? TauxTva { get; set; }

    [System.ComponentModel.Description("Nb. jours bdg visiteurs=NbBadgesVisiteurs")]
    [DataMember()]
    public int? NbBadgesVisiteurs { get; set; }
  }

  [DataContract()]
  public class MarcheProduitCouleurData
  {
    [System.ComponentModel.Description("$$IdCouleur")]
    [DataMember()]
    public int? IdCouleur { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }
  }

  [DataContract()]
  public class MarcheTypeSetData
  {
    [System.ComponentModel.Description("$$IdTypeSet")]
    [DataMember()]
    public int? IdTypeSet { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }
  }

  [DataContract()]
  public class MarcheTypeProduitData
  {
    [System.ComponentModel.Description("$$IdTypeProduit")]
    [DataMember()]
    public int? IdTypeProduit { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; } = true;

    [System.ComponentModel.Description("Libellé=Libelle")]
    [DataMember()]
    public string Libelle { get; set; }

    [System.ComponentModel.Description("$$IdTypeCommande")]
    [DataMember()]
    public string IdTypeCommande { get; set; }
  }

  [DataContract()]
  public class MarcheProduitGroupeData
  {
    [System.ComponentModel.Description("$$IdProduitGroupe")]
    [DataMember()]
    public int? IdProduitGroupe { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [System.ComponentModel.Description("$$IdProduitGroupeMaitre")]
    [DataMember()]
    public int? IdProduitGroupeMaitre { get; set; }
  }

  [DataContract()]
  public class MarcheFournisseurData
  {
    [System.ComponentModel.Description("$$IdFournisseur")]
    [DataMember()]
    public int? IdFournisseur { get; set; }

    [System.ComponentModel.Description("Code=Code")]
    [DataMember()]
    public string Code { get; set; }

    [System.ComponentModel.Description("Fournisseur=Fournisseur")]
    [DataMember()]
    public string Fournisseur { get; set; }

    [System.ComponentModel.Description("Email=Email")]
    [DataMember()]
    public string Email { get; set; }
  }

  [DataContract()]
  public class MarcheAssuranceProduitData
  {
    [System.ComponentModel.Description("$$IdAssurance")]
    [DataMember()]
    public int? IdAssurance { get; set; }

    [System.ComponentModel.Description("$$LimiteInferieure")]
    [DataMember()]
    public int LimiteInferieure { get; set; }

    [System.ComponentModel.Description("$$LimiteSuperieure")]
    [DataMember()]
    public int LimiteSuperieure { get; set; }

    [System.ComponentModel.Description("$$Montant")]
    [DataMember()]
    public string Montant { get; set; }
  }

  [DataContract()]
  public class MarcheProduitContractuelData
  {
    [DataMember()]
    public int? IdProduitContractuel { get; set; }

    [DataMember()]
    public int SurfaceMin { get; set; }

    [DataMember()]
    public int SurfaceMax { get; set; }

    [DataMember()]
    public int? IdTypeSet { get; set; }

    [DataMember()]
    public int Nombre { get; set; }
  }


  [DataContract()]
  public class MarcheCommandeProduitData
  {
    

    [Description("Identifiant=IdCommandeProduit")]
    [DataMember()]
    public int? Id { get; set; }

    [Description("$$IdProduit")]
    [DataMember()]
    public int? IdProduit { get; set; }

    [Description("$$IdCodePromo")]
    [DataMember()]
    public int? IdCodePromo { get; set; }

    [Description("$$IdCommande")]
    [DataMember()]
    public int? IdCommande { get; set; }

    [Description("Quantité=Quantite")]
    [DataMember()]
    public double Quantite { get; set; }

    [Description("Commande=mCommandes")]
    [DataMember()]
    public MarcheCommandeData Commande { get; set; }

    [Description("Produit=mProduits")]
    [DataMember()]
    public MarcheProduitData Produit { get; set; }

    [Description("$$Code Promo=viewCodesPromos")]
    [DataMember()]
    public CodePromoGenereData CodePromo { get; set; }

    [Description("Montant=Montant")]
    [DataMember()]
    public double? Montant { get; set; }

    [Description("Libellé=Libelle")]
    [DataMember()]
    public string Libelle { get; set; }
  }
}