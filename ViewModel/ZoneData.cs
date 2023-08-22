using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class ZoneData
  {
    /// <summary>
    ///   ''' Identifiant de la zone
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public int? Id { get; set; } 

    [System.ComponentModel.Description("$$VirtualId")]
    [DataMember()]
    public int? VirtualId { get; set; }

    /// <summary>
    ///   ''' Date de dernière modification
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [System.ComponentModel.Description("$$DateModification")]
    [DataMember()]
    public DateTime DateModification { get; set; }

    /// <summary>
    ///   ''' Identifiant du modèle
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [System.ComponentModel.Description("$$IdModele")]
    [DataMember()]
    public int? IdModele { get; set; }

    [System.ComponentModel.Description("$$IdPlan")]
    [DataMember()]
    public int IdPlan { get; set; }

    [System.ComponentModel.Description("Plan=bPlans")]
    [DataMember()]
    public PlanData Plan { get; set; }

    // ''' <summary>
    // ''' Modèle de la zone
    // ''' </summary>
    // ''' <remarks></remarks>
    // <DataMember()>
    // ReadOnly Property Modele As ModeleData
    // Get
    // Return (New Modele).Load(IdModele)
    // End Get
    // End Property

    /// <summary>
    ///   ''' Libellé feuillade de la zone
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [System.ComponentModel.Description("$$IdDesignation")]
    [DataMember()]
    public int? IdDesignation { get; set; }

    [System.ComponentModel.Description("Désignation")]
    [DataMember()]
    public string Designation { get; set; }

    /// <summary>
    ///   ''' Libellé de l'allée de la zone
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [System.ComponentModel.Description("$$IdAllee")]
    [DataMember()]
    public int? IdAllee { get; set; }

    [System.ComponentModel.Description("Allée=bAllees")]
    [DataMember()]
    public AlleeData Allee { get; set; }

    /// <summary>
    ///   ''' Libellé porte de la zone
    ///   ''' </summary>
    ///   ''' <remarks></remarks>
    [System.ComponentModel.Description("$$IdPorte")]
    [DataMember()]
    public int? IdPorte { get; set; }

    [System.ComponentModel.Description("Porte=bPortes")]
    [DataMember()]
    public PorteData Porte { get; set; }

    [System.ComponentModel.Description("$$IdTypeZone")]
    [DataMember()]
    public int? IdTypeZone { get; set; }

    [System.ComponentModel.Description("Type Zone=TypeZone")]
    [DataMember()]
    public TypeZoneData TypeZone { get; set; }

    [System.ComponentModel.Description("$$Valeur")]
    [DataMember()]
    public int Valeur { get; set; }

    [System.ComponentModel.Description("$$IsDebutDeRang")]
    [DataMember()]
    public bool IsDebutDeRang { get; set; }

    [System.ComponentModel.Description("$$IsFinDeRang")]
    [DataMember()]
    public bool IsFinDeRang { get; set; }

    [System.ComponentModel.Description("$$CanCreate")]
    [DataMember()]
    public bool CanCreate { get; set; } = true;

    [System.ComponentModel.Description("$$DebutX")]
    [DataMember()]
    public int DebutX { get; set; }

    [System.ComponentModel.Description("$$DebutX")]
    [DataMember()]
    public int FinX { get; set; }

    [System.ComponentModel.Description("$$DebutY")]
    [DataMember()]
    public int DebutY { get; set; }

    [System.ComponentModel.Description("$$FinY")]
    [DataMember()]
    public int FinY { get; set; }

    [System.ComponentModel.Description("Numéroté?=Numerote")]
    [DataMember()]
    public bool Numerote { get; set; } = false;

    [System.ComponentModel.Description("$$ForceNumerote")]
    [DataMember()]
    public bool ForceNumerote { get; set; } = false;

    [System.ComponentModel.Description("Bloqué?=Bloque")]
    [DataMember()]
    public bool Bloque { get; set; } = false;

    [System.ComponentModel.Description("PMR?=PMR")]
    [DataMember()]
    public bool PMR { get; set; } = false;

    [System.ComponentModel.Description("SansBillet?=SansBillet")]
    [DataMember()]
    public bool SansBillet { get; set; } = false;


    [System.ComponentModel.Description("Libellé=Libelle")]
    [DataMember()]
    public string Libelle { get; set; } = "";

    [System.ComponentModel.Description("$$Affectations")]
    [DataMember()]
    public List<AffectationData> Affectations { get; set; }
  }

}
