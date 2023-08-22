using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class FormulaireData
  {
    [DataMember()]
    [System.ComponentModel.Description("Identifiant")]
    public int? Id { get; set; }

    [DataMember()]
    public int IdEvenement { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Réponse unique?")]
    public bool ReponseUnique { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Libellé")]
    public string Libelle { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Formulaire")]
    public string Formulaire { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$FormulaireUs")]
    public string FormulaireUs { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Formulaire Fermeture")]
    public string FormulaireFermeture { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Formulaire Fermeture Us")]
    public string FormulaireFermetureUs { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Formulaire Validation")]
    public string FormulaireValidation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("$$Formulaire ValidationUs")]
    public string FormulaireValidationUs { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Campagne liées")]
    public int? IdCampagne { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Campagne Validation")]
    public int? IdCampagneValidation { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Campagne Négatif")]
    public int? IdCampagneNegatif { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date ouverture formulaire")]
    public DateTime? DateOuvertureFormulaire { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Date fermeture formulaire")]
    public DateTime? DateFermetureFormulaire { get; set; }

    [DataMember()]
    [System.ComponentModel.Description("Url")]
    public string Url { get; set; }
  }

  public class StatutFormulaireData
  {
    [System.ComponentModel.Description("$$Id")]
    public int Id { get; set; }
    public string Libelle { get; set; }
    public string MessageInternet { get; set; }
    public bool Accepte { get; set; }
    [System.ComponentModel.Description("$$IdReponseFormulaire ")]
    public string IdReponseFormulaire { get; set; }
  }
}