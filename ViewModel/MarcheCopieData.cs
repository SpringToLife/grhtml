using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GrapesJsEditorHtml.ViewModel
{
  public class MarcheCopieData
  {
  
      [System.ComponentModel.Description("$$Librairie")]
      [IgnoreDataMember]
      public string Library { get; set; } = "Services.MarcheCopie.MarcheCopieClient, Services";

      [System.ComponentModel.Description("$$LibrairieDirecte")]
      [IgnoreDataMember]
      public string LibraryDirect { get; set; } = "WcfService.MarcheCopie, WcfService";

      [DataMember()]
      [System.ComponentModel.Description("$$OldValue")]
      [IgnoreDataMember]
      public MarcheCopieData OldData { get; set; }

      [System.ComponentModel.Description("$$Id")]
      [DataMember()]
      public int? Id { get; set; }

      [System.ComponentModel.Description("$$IdUtilisateurModification=IdUtilisateurModification")]
      [DataMember()]
      public int? IdUtilisateurModification { get; set; }

      [System.ComponentModel.Description("Date de création=DateCreation")]
      [DataMember()]
      public DateTime? DateCreation { get; set; }

      [System.ComponentModel.Description("Date de Modification=DateModification")]
      [DataMember()]
      public DateTime? DateModification { get; set; }

      [System.ComponentModel.Description("$$IdFilm")]
      [DataMember()]
      public int? IdFilm { get; set; }

      [System.ComponentModel.Description("Film=mFilms")]
      [DataMember()]
      public MarcheFilmData Film { get; set; }

      [System.ComponentModel.Description("$$IdSupport")]
      [DataMember()]
      public string IdSupport { get; set; }

      [System.ComponentModel.Description("Support=mFormatsCopies")]
      [DataMember()]
      public MarcheFormatCopieData Support { get; set; }

      [System.ComponentModel.Description("N° Copie=NoCopie")]
      [DataMember()]
      public string NoCopie { get; set; }

      [System.ComponentModel.Description("Sous-Titre=SousTitre")]
      [DataMember()]
      public string SousTitre { get; set; }

      [System.ComponentModel.Description("Statut demat=Statut")]
      [DataMember()]
      public string Statut { get; set; }

      [System.ComponentModel.Description("Version=Version")]
      [DataMember()]
      public string Version { get; set; }

      [System.ComponentModel.Description("Livreur=Livreur")]
      [DataMember()]
      public string Livreur { get; set; }

      [System.ComponentModel.Description("Zone=Zone")]
      [DataMember()]
      public string Zone { get; set; }

      [System.ComponentModel.Description("Expéditeur=Expediteur")]
      [DataMember()]
      public string Expediteur { get; set; }

      [System.ComponentModel.Description("Année=Annee")]
      [DataMember()]
      public string Annee { get; set; }

      [System.ComponentModel.Description("Notes=Notes")]
      [DataMember()]
      public string Notes { get; set; }

      [System.ComponentModel.Description("$$Mouvements")]
      [DataMember()]
      public List<MarcheCopieMouvementData> Mouvements { get; set; }
    }


    [DataContract()]
    public class MarcheCopieMouvementData
    {
      [System.ComponentModel.Description("$$Id")]
      [DataMember()]
      public int? IdMouvement { get; set; }

      [System.ComponentModel.Description("$$IdUtilisateurModification=IdUtilisateurModification")]
      [DataMember()]
      public int? IdUtilisateurModification { get; set; }

      [System.ComponentModel.Description("Date de création=DateCreation")]
      [DataMember()]
      public DateTime? DateCreation { get; set; }

      [System.ComponentModel.Description("Date de Modification=DateModification")]
      [DataMember()]
      public DateTime? DateModification { get; set; }

      [System.ComponentModel.Description("$$IdCopie")]
      [DataMember()]
      public int? IdCopie { get; set; }

      [System.ComponentModel.Description("Date=DateMouvement")]
      [DataMember()]
      public DateTime? DateMouvement { get; set; }

      [System.ComponentModel.Description("Type=TypeMouvement")]
      [DataMember()]
      public string TypeMouvement { get; set; }

      [System.ComponentModel.Description("Bordereau=Bordereau")]
      [DataMember()]
      public string Bordereau { get; set; }

      [System.ComponentModel.Description("Livreur=Livreur")]
      [DataMember()]
      public string Livreur { get; set; }

      [System.ComponentModel.Description("Contact=Contact")]
      [DataMember()]
      public string Contact { get; set; }

      [System.ComponentModel.Description("Destination=Destination")]
      [DataMember()]
      public string Destination { get; set; }

      [System.ComponentModel.Description("N° tracking=NoTracking")]
      [DataMember()]
      public string NoTracking { get; set; }

      [System.ComponentModel.Description("Notes=Notes")]
      [DataMember()]
      public string Notes { get; set; }

      [System.ComponentModel.Description("$$Copie")]
      [DataMember()]
      public MarcheCopieData Copie { get; set; }
    }


    [DataContract()]
    public class MarcheFormatCopieData
    {
      [System.ComponentModel.Description("Code=IdFormatCopie")]
      [DataMember()]
      public string IdFormatCopie { get; set; }

      [System.ComponentModel.Description("Visible?=Visible")]
      [DataMember()]
      public bool Visible { get; set; } = true;

      [System.ComponentModel.Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }

      [System.ComponentModel.Description("Ordre=Ordre")]
      [DataMember()]
      public int Ordre { get; set; }
    }

  }

