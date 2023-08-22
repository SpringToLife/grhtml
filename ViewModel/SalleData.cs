using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class CouleurData
  {
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public int? Id { get; set; } 

    [System.ComponentModel.Description("$$IdSalle")]
    [DataMember()]
    public int IdSalle { get; set; }

    [System.ComponentModel.Description("Couleur=Couleur")]
    [DataMember()]
    public string Couleur { get; set; }
  }

  [DataContract()]
  public class SalleData
  {
    /// <summary>
    ///   ''' Identifiant de la salle
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [DataMember()]
    public int? Id { get; set; } 

    [DataMember()]
    public int? IdProj { get; set; } 

    /// <summary>
    ///   ''' Nom de la salle
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [DataMember()]
    public string Libelle { get; set; }

    [DataMember()]
    public string Libelle2 { get; set; }

    /// <summary>
    ///   ''' Date de dernière modification
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [DataMember()]
    public DateTime DateModification { get; set; }

    /// <summary>
    ///   ''' True si la salle est visible
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [DataMember()]
    public bool Visible { get; set; }

    [DataMember()]
    public bool VisiblePresse { get; set; }

    [DataMember()]
    public bool VisibleWatch { get; set; }

    [DataMember()]
    public List<PlanSalleData> Plans { get; set; }

    [DataMember()]
    public string Annee { get; set; }

    [DataMember()]
    public int Ordre { get; set; }

    [DataMember()]
    public int? IdFormat { get; set; }

    [DataMember()]
    public int? IdFormateBillet { get; set; }
  }

  [DataContract()]
  public class PlanSalleData
  {
    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public int? IdPlan { get; set; }
    [DataMember()]
    public int? IdSalle { get; set; }

    [DataMember()]
    public int NbPlacesTotales { get; set; } = 0;

    [DataMember()]
    public int NbPlacesAffectees { get; set; } = 0;

    [DataMember()]
    public string DynamicLibelle { get; set; }

    [DataMember()]
    public PlanData Plan { get; set; }

    [DataMember()]
    public string PlanLibelle { get; set; }

    [DataMember()]
    public int OffsetX { get; set; }

    [DataMember()]
    public int OffsetY { get; set; }

    [DataMember()]
    public int Largeur { get; set; }

    [DataMember()]
    public int Hauteur { get; set; }
  }
}
