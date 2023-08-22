using Microsoft.EntityFrameworkCore.Metadata.Internal;

using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class PlanData
  {
    /// <summary>
    /// Identifiant du plan
    /// </summary>
    /// <remarks></remarks>
    [DataMember()]
    public int? Id { get; set; } = null;

    /// <summary>
    /// Nom du plan
    /// </summary>
    /// <remarks></remarks>
    [DataMember()]
    public string Libelle { get; set; }

    /// <summary>
    /// True si le plan est visible
    /// </summary>
    /// <remarks></remarks>
    [DataMember()]
    public bool Visible { get; set; }

    /// <summary>
    /// Date de dernière modification
    /// </summary>
    /// <remarks></remarks>
    [DataMember()]
    public DateTime DateModification { get; set; }

    [DataMember()]
    public string Annee { get; set; }

    [DataMember()]
    public bool ModeGrille { get; set; }

    [DataMember()]
    public bool DescriptionLibre { get; set; }
  }
  public class AlleeData
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public int IdPlan { get; set; }
    [DataMember()]
    public string Allee { get; set; }
  }

  [DataContract()]
  public class PorteData
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public int IdPlan { get; set; }
    [DataMember()]
    public string Porte { get; set; }
  }

  [DataContract()]
  public class TypeZoneData
  {
    [DataMember()]
    public int? Id { get; set; } 
    [DataMember()]
    public int IdPlan { get; set; }
    [DataMember()]
    public string TypeZone { get; set; }
    [DataMember()]
    public string NomCourt { get; set; }
    [DataMember()]
    public string Lettre { get; set; }
    [DataMember()]
    public int Valeur { get; set; }
  }

  [DataContract()]
  public class DesignationData
  {
    [DataMember()]
    public int? Id { get; set; }
    [DataMember()]
    public int IdPlan { get; set; }
    [DataMember()]
    public string Designation { get; set; }
  }
}

