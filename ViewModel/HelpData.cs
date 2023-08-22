using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class HelpData
  {
    [Key]
    public int? Id { get; set; }

    [DataMember()]
    public int IdLink { get; set; }

    [DataMember()]
    public int? IdListeType { get; set; }

    [DataMember()]
    public bool Actif { get; set; }

    [DataMember()]
    public string Description { get; set; }

    [DataMember()]
    public string TitreFr { get; set; }

    [DataMember()]
    public string TitreUs { get; set; }

    [DataMember()]
    public string ContenuFr { get; set; }

    [DataMember()]
    public string ContenuUs { get; set; }

    [DataMember()]
    public string PdfCss { get; set; }

    [DataMember()]
    public string HeaderFr { get; set; }

    [DataMember()]
    public string HeaderUs { get; set; }

    [DataMember()]
    public string FooterFr { get; set; }

    [DataMember()]
    public string FooterUs { get; set; }

    [DataMember()]
    public ListeTypeData ListeType { get; set; }
  }

  public class ListeTypeData
  {
    [DataMember()]
    public int? Id { get; set; }

    [DataMember()]
    public string Table { get; set; }

    [DataMember()]
    public string Type { get; set; }

    [DataMember()]
    public string Source { get; set; }

    [DataMember()]
    public string FieldId { get; set; }

    [DataMember()]
    public string FieldAnnee { get; set; }

    [DataMember()]
    public string FieldDateImpression { get; set; }

    [DataMember()]
    public string FieldBaseId { get; set; }

    [DataMember()]
    public string FieldBaseDateImpression { get; set; }

    [DataMember()]
    public string FieldPhoto { get; set; }

    [DataMember()]
    public string FieldIdPersonne { get; set; }

    [DataMember()]
    public string FieldIdSociete { get; set; }

    [DataMember()]
    public string FieldPhotoId { get; set; }

    [DataMember()]
    public string Racine { get; set; }

    [DataMember()]
    public string Suffixe { get; set; }

    [DataMember()]
    public string Exclude { get; set; }
  }
}