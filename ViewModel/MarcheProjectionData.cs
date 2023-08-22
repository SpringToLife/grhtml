
using System.Runtime.Serialization;
namespace GrapesJsEditorHtml.ViewModel
{
  public class MarcheProjectionData
  {


    [System.ComponentModel.Description("$$Actif")]
    [DataMember()]
    public string Actif { get; set; } = "Y";

    [System.ComponentModel.Description("Identifiant=IdProjection")]
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

    [System.ComponentModel.Description("Date Modif. guide=DateModifGuide")]
    [DataMember()]
    public DateTime? DateModifGuide { get; set; }

    [System.ComponentModel.Description("$$IdCinando")]
    [DataMember()]
    public int? IdCinando { get; set; }

    [System.ComponentModel.Description("Id. Bdc=IdBdc")]
    [DataMember()]
    public int? IdBdc { get; set; }

    [System.ComponentModel.Description("$$Bdc")]
    [DataMember()]
    public MarcheBdcData Bdc { get; set; }

    [System.ComponentModel.Description("$$IdSociete")]
    [DataMember()]
    public int? IdSociete { get; set; }

    // <System.ComponentModel.Description("$$IdSocieteProjection")>
    // <DataMember()>
    // Property IdSocieteProjection As Integer?

    [System.ComponentModel.Description("Société=SocieteProj")]
    [DataMember()]
    public SocieteData Societe { get; set; }

    [System.ComponentModel.Description("Année=Annee")]
    [DataMember()]
    public string Annee { get; set; }

    [System.ComponentModel.Description("$$IdFilm")]
    [DataMember()]
    public int? IdFilm { get; set; }

    // <System.ComponentModel.Description("$$Films")>
    // <DataMember()>
    // Property Films As List(Of MarcheFilmData)

    [System.ComponentModel.Description("Film=mFilms")]
    [DataMember()]
    public MarcheFilmData Film { get; set; }

    [System.ComponentModel.Description("$$IdSalle")]
    [DataMember()]
    public int? IdSalle { get; set; }

    [System.ComponentModel.Description("Date Affectation=DateModificationAffectation")]
    [DataMember()]
    public DateTime? DateModificationAffectation { get; set; }

    [System.ComponentModel.Description("Statut Affectation=IdStatutAffectation")]
    [DataMember()]
    public string IdStatutAffectation { get; set; }

    [System.ComponentModel.Description("Statut affectation=mStatutsProjections")]
    [DataMember()]
    public MarcheStatutProjectionData StatutAffectation { get; set; }

    [System.ComponentModel.Description("$$IdStatutFacturation")]
    [DataMember()]
    public string IdStatutFacturation { get; set; }

    [System.ComponentModel.Description("Statut projection=mStatutsFacturationProjections")]
    [DataMember()]
    public MarcheStatutFacturationProjectionData StatutProjection { get; set; }

    [System.ComponentModel.Description("$$IdTypeProjection")]
    [DataMember()]
    public string IdTypeProjection { get; set; }

    [System.ComponentModel.Description("Type=mTypesProjections_TypeProjection")]
    [DataMember()]
    public string TypeProjection { get; set; }

    [System.ComponentModel.Description("$$IdProjOnline")]
    [DataMember()]
    public int? IdProjOnline { get; set; }

    [System.ComponentModel.Description("CST état=CstState")]
    [DataMember()]
    public string CstState { get; set; }

    [System.ComponentModel.Description("Date reprise=DateReprise")]
    [DataMember()]
    public DateTime? DateReprise { get; set; }

    [System.ComponentModel.Description("Date annulation=DateAnnulation")]
    [DataMember()]
    public DateTime? DateAnnulation { get; set; }

    [System.ComponentModel.Description("Durée proj.=Duree")]
    [DataMember()]
    public int? Duree { get; set; }

    //[System.ComponentModel.Description("Durée réelle")]
    //[DataMember()]
    //public int? DureeReelle
    //{
    //  get
    //  {
    //    if (Film != null)
    //    {
    //      if (Film.Trailer)
    //      {
    //        if (Trailer)
    //          return Duree;
    //        else
    //          return Film.DureeTrailer;
    //      }
    //      else
    //        return Film.Duree;
    //    }
    //    else
    //      return Duree;
    //  }
    //  set
    //  {
    //  }
    //}


    [System.ComponentModel.Description("Salle=mSalles")]
    [DataMember()]
    public MarcheSalleData Salle { get; set; }

    [System.ComponentModel.Description("Date/heure=DateProjection")]
    [DataMember()]
    public DateTime? DateProjection { get; set; }

    //[System.ComponentModel.Description("Date=Format(mProjections_DateProjection,'dd')")]
    //[DataMember()]
    //public string DateProj
    //{
    //  get
    //  {
    //    if (DateProjection == null)
    //      return "";
    //    else
    //      return (DateTime)DateProjection.ToString("dd");
    //  }
    //  set
    //  {
    //  }
    //}

    //[System.ComponentModel.Description("Heure=Format(mProjections_DateProjection,'HH:mm')")]
    //[DataMember()]
    //public string HeureProj
    //{
    //  get
    //  {
    //    if (DateProjection == null)
    //      return "";
    //    else
    //      return (DateTime)DateProjection.ToString("HH:mm");
    //  }
    //  set
    //  {
    //  }
    //}

    //[System.ComponentModel.Description("Fin projection")]
    //[DataMember()]
    //public DateTime? FinProjection
    //{
    //  get
    //  {
    //    if (DateProjection != null && DureeReelle != null)
    //      return (DateTime)DateProjection.AddMinutes(System.Convert.ToDouble(DureeReelle));
    //    else
    //      return default(Date?);
    //  }
    //  set
    //  {
    //  }
    //}

    [System.ComponentModel.Description("Organisateur=IdOrganisateur")]
    [DataMember()]
    public string IdOrganisateur { get; set; }

    [System.ComponentModel.Description("Gestionnaire Technique=IdGestionnaireTechnique")]
    [DataMember()]
    public string IdGestionnaireTechnique { get; set; }

    [System.ComponentModel.Description("Facturé?=Facture")]
    [DataMember()]
    public bool? Facture { get; set; }

    [System.ComponentModel.Description("Trailer en boucle?=Trailer")]
    [DataMember()]
    public bool? Trailer { get; set; }

    [System.ComponentModel.Description("Libellé=Libelle")]
    [DataMember()]
    public string Libelle { get; set; }

    //[System.ComponentModel.Description("$$DisplayName")]
    //[DataMember()]
    //public string DisplayName
    //{
    //  get
    //  {
    //    if (Libelle != "")
    //      return Libelle;
    //    else if (Film != null)
    //      return Film.Titre;
    //    else if (Tba)
    //      return "TBA";
    //    else if (Id == null)
    //      return "Nouvelle projection";
    //    else
    //      return "Sans titre";
    //  }
    //  set
    //  {
    //  }
    //}

    [System.ComponentModel.Description("Code Filtrage=Filtrage")]
    [DataMember()]
    public string CodeFiltrage { get; set; }

    [System.ComponentModel.Description("Filtrage=mFiltrages")]
    [DataMember()]
    public MarcheProjectionFiltrageData Filtrage { get; set; }

    [System.ComponentModel.Description("Tba?=Tba")]
    [DataMember()]
    public bool? Tba { get; set; } = false;

    [System.ComponentModel.Description("Réservé?=Reserve")]
    [DataMember()]
    public bool? Reserve { get; set; } = false;

    [System.ComponentModel.Description("Secrète?=Secrete")]
    [DataMember()]
    public bool? Secrete { get; set; } = false;

    [System.ComponentModel.Description("Montant=Montant")]
    [DataMember()]
    public double? Montant { get; set; }

    [System.ComponentModel.Description("Coefficient=Coefficient")]
    [DataMember()]
    public double Coefficient { get; set; }

    [System.ComponentModel.Description("Ctrl.Info.?=ControleInformatique")]
    [DataMember()]
    public bool? ControleInformatique { get; set; }

    [System.ComponentModel.Description("Répétition?=Repetition")]
    [DataMember()]
    public bool? Repetition { get; set; } = false;

    [System.ComponentModel.Description("Session=Session")]
    [DataMember()]
    public string Session { get; set; }

    //[System.ComponentModel.Description("$$Jour")]
    //[DataMember()]
    //public string Jour
    //{
    //  get
    //  {
    //    if (DateProjection == null)
    //      return "";
    //    else
    //      return (DateTime)DateProjection.ToString("dd");
    //  }
    //  set
    //  {
    //  }
    //}

    [System.ComponentModel.Description("$$NbSpectateurs")]
    [DataMember()]
    public int? NbSpectateurs { get; set; }

    [System.ComponentModel.Description("$$NbInvitations")]
    [DataMember()]
    public int? NbInvitations { get; set; }

    [System.ComponentModel.Description("Nb. Invit. Suppl.=NbInvitSuppl")]
    [DataMember()]
    public int NbInvitSuppl { get; set; } = 0;

    [System.ComponentModel.Description("Nb. Invit. Impr.=NbInvitImprime")]
    [DataMember()]
    public int NbInvitImprime { get; set; } = 0;

    [System.ComponentModel.Description("Nb. Invit. Totale")]
    public int NbInvitTotale
    {
      get
      {
        if (Salle != null)
          return Salle.NbInvitations + NbInvitSuppl;
        else
          return NbInvitSuppl;
      }
      set
      {
      }
    }

    [System.ComponentModel.Description("$$IdFormat")]
    [DataMember()]
    public int? IdFormat { get; set; }

    // <System.ComponentModel.Description("$$Nb. Invit. Suppl.2=NbInvitSuppl")>
    // <DataMember()>
    // Property NbInvitSuppl2 As Integer = 0

    // <System.ComponentModel.Description("$$Nb. Invit. Impr.2=NbInvitImprime2")>
    // <DataMember()>
    // Property NbInvitImprime2 As Integer = 0

    // <System.ComponentModel.Description("$$IdFormat2")>
    // <DataMember()>
    // Property IdFormat2 As Integer?

    // <System.ComponentModel.Description("$$Nb. Invit. Suppl.3=NbInvitSuppl")>
    // <DataMember()>
    // Property NbInvitSuppl3 As Integer = 0

    // <System.ComponentModel.Description("$$Nb. Invit. Impr.3=NbInvitImprime3")>
    // <DataMember()>
    // Property NbInvitImprime3 As Integer = 0

    // <System.ComponentModel.Description("$$IdFormat3")>
    // <DataMember()>
    // Property IdFormat3 As Integer?


    [System.ComponentModel.Description("Nb. Entrees=NbEntrees")]
    [DataMember()]
    public int NbEntrees { get; set; } = 0;

    [System.ComponentModel.Description("CodeBarres")]
    [DataMember()]
    public string CodeBarres { get; set; }

    [System.ComponentModel.Description("Date impression=DateImpression")]
    [DataMember()]
    public DateTime? DateImpression { get; set; }

    [System.ComponentModel.Description("Util. impression=UtilisateurImpression")]
    [DataMember()]
    public string UtilisateurImpression { get; set; }


    [System.ComponentModel.Description("Notes=Notes")]
    [DataMember()]
    public string Notes { get; set; }

    [System.ComponentModel.Description("$$IdOfficiel")]
    [DataMember()]
    public int? IdOfficiel { get; set; }

    [System.ComponentModel.Description("Commentaires hôtesses=Rapport")]
    [DataMember()]
    public string Rapport { get; set; }

    [System.ComponentModel.Description("Notes montage=NotesMontages")]
    [DataMember()]
    public string NotesMontages { get; set; }

    // <System.ComponentModel.Description("Visibilité=Visibilite")>
    // <DataMember()>
    // Public Property Visibilite As Integer = 2

    [System.ComponentModel.Description("Statut Technique=StatutTechnique")]
    [DataMember()]
    public string StatutTechnique { get; set; }

    [System.ComponentModel.Description("Date envoi rapport=DateEnvoiRapport")]
    [DataMember()]
    public DateTime? DateEnvoiRapport { get; set; }
  }


  // <DataContract()>
  // Public Class MarcheProjectionSupportData
  // <System.ComponentModel.Description("$$Id")>
  // <DataMember()>
  // Property IdSupport As Integer?

  // <System.ComponentModel.Description("Visible?=Visible")>
  // <DataMember()>
  // Property Visible As Boolean = True

  // <System.ComponentModel.Description("Libelle Fr.=LibelleFr")>
  // <DataMember()>
  // Property LibelleFr As String

  // <System.ComponentModel.Description("Libelle Us.=LibelleUs")>
  // <DataMember()>
  // Property LibelleUs As String
  // End Class

  [DataContract()]
  public class MarcheFormatImageData
  {
    [System.ComponentModel.Description("Code=IdFormatImage")]
    [DataMember()]
    public string IdFormatImage { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; } = true;

    [System.ComponentModel.Description("Libelle Fr.=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libelle Us.=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [System.ComponentModel.Description("Type Fr.=TypeFormatFr")]
    [DataMember()]
    public string TypeFormatFr { get; set; }

    [System.ComponentModel.Description("Type Us.=TypeFormatUs")]
    [DataMember()]
    public string TypeFormatUs { get; set; }
  }

  [DataContract()]
  public class MarcheProjectionOrganisateurData
  {
    [System.ComponentModel.Description("$$Id")]
    [DataMember()]
    public string IdOrganisateur { get; set; }

    [System.ComponentModel.Description("Organisateur=Organisateur")]
    [DataMember()]
    public string Organisateur { get; set; }

    [System.ComponentModel.Description("Organisateur Us=Organisateur Us")]
    [DataMember()]
    public string OrganisateurUs { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int? Ordre { get; set; }

    [System.ComponentModel.Description("$$SelectionFr")]
    [DataMember()]
    public string SelectionFr { get; set; }

    [System.ComponentModel.Description("$$SelectionUs")]
    [DataMember()]
    public string SelectionUS { get; set; }

    [System.ComponentModel.Description("$$CouleurImage")]
    [DataMember()]
    public string CouleurImage { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }

    [System.ComponentModel.Description("$$Groupes")]
    [DataMember()]
    public string Groupes { get; set; }

    [System.ComponentModel.Description("$$Emetteurs")]
    [DataMember()]
    public string Emetteurs { get; set; }
  }


  [DataContract()]
  public class MarcheDemandeProjectionData
  {
    [System.ComponentModel.Description("$$IdDemandeProj")]
    [DataMember()]
    public int? IdDemandeProj { get; set; }

    [System.ComponentModel.Description("Id. Demande=IdDemande")]
    [DataMember()]
    public int IdDemande { get; set; }

    [System.ComponentModel.Description("$$IdSalle")]
    [DataMember()]
    public int IdSalle { get; set; }

    [System.ComponentModel.Description("$$DateDemande")]
    [DataMember()]
    public string DateDemande { get; set; }

    [System.ComponentModel.Description("$$Creneau1")]
    [DataMember()]
    public bool Creneau1 { get; set; }

    [System.ComponentModel.Description("$$Creneau2")]
    [DataMember()]
    public bool Creneau2 { get; set; }

    [System.ComponentModel.Description("$$Creneau3")]
    [DataMember()]
    public bool Creneau3 { get; set; }

    [System.ComponentModel.Description("$$Creneau4")]
    [DataMember()]
    public bool Creneau4 { get; set; }

    [System.ComponentModel.Description("$$Creneau5")]
    [DataMember()]
    public bool Creneau5 { get; set; }

    [System.ComponentModel.Description("$$Creneau6")]
    [DataMember()]
    public bool Creneau6 { get; set; }

    [System.ComponentModel.Description("$$Creneau7")]
    [DataMember()]
    public bool Creneau7 { get; set; }

    [System.ComponentModel.Description("$$Creneau8")]
    [DataMember()]
    public bool Creneau8 { get; set; }

    [System.ComponentModel.Description("$$Creneau9")]
    [DataMember()]
    public bool Creneau9 { get; set; }

    [System.ComponentModel.Description("$$Creneau10")]
    [DataMember()]
    public bool Creneau10 { get; set; }
  }

  [DataContract()]
  public class MarcheDemandeFilmData
  {
    [System.ComponentModel.Description("$$IdDemandeFilm")]
    [DataMember()]
    public int? IdDemandeFilm { get; set; }

    [System.ComponentModel.Description("Id. Demande=IdDemande")]
    [DataMember()]
    public int IdDemande { get; set; }

    [System.ComponentModel.Description("$$IdFilm")]
    [DataMember()]
    public int IdFilm { get; set; }

    [System.ComponentModel.Description("Film=mFilms_")]
    [DataMember()]
    public MarcheFilmData Film { get; set; }

    [System.ComponentModel.Description("Type Projection=TypeProjection")]
    [DataMember()]
    public string TypeProjection { get; set; }

    [System.ComponentModel.Description("Durée=Duree")]
    [DataMember()]
    public int? Duree { get; set; }

    [System.ComponentModel.Description("Durée Creneau=DureeCreneau")]
    [DataMember()]
    public int? DureeCreneau { get; set; }

    [System.ComponentModel.Description("Confidentiel?=Confidentiel")]
    [DataMember()]
    public bool Confidentiel { get; set; }

    [System.ComponentModel.Description("Nb proj=NbProj")]
    [DataMember()]
    public int? NbProj { get; set; }

    [System.ComponentModel.Description("Notes=Notes")]
    [DataMember()]
    public string Notes { get; set; }

    [System.ComponentModel.Description("Dates demandés")]
    [DataMember()]
    public string DatesDemandes { get; set; }
  }

  // <DataContract()>
  // Public Class MarcheProjectionProgrammeData
  // <System.ComponentModel.Description("$$IdProgramme")>
  // <DataMember()>
  // Property IdProgramme As Integer?

  // <System.ComponentModel.Description("$$IdFilm")>
  // <DataMember()>
  // Property IdFilm As Integer?

  // <System.ComponentModel.Description("Film")>
  // <DataMember()>
  // Property Film As MarcheFilmData

  // <System.ComponentModel.Description("Trailer")>
  // <DataMember()>
  // Property Trailer As Boolean

  // <System.ComponentModel.Description("Durée=Duree")>
  // <DataMember()>
  // Property Duree As Integer

  // <System.ComponentModel.Description("Durée Creneau=DureeCreneau")>
  // <DataMember()>
  // Property DureeCreneau As Integer?
  // End Class

  [DataContract()]
  public class MarcheStatutProjectionData
  {
    [System.ComponentModel.Description("$$IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("Statut=IdStatut")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Statut=Statut")]
    [DataMember()]
    public string Statut { get; set; }

    [System.ComponentModel.Description("$$StatutSuivant")]
    [DataMember()]
    public string StatutSuivant { get; set; }

    [System.ComponentModel.Description("$$IdCampagne")]
    [DataMember()]
    public int? IdCampagne { get; set; }


    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int Ordre { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }

    [System.ComponentModel.Description("Message Fo Fr=MessageFoFr")]
    [DataMember()]
    public string MessageFoFr { get; set; }

    [System.ComponentModel.Description("Message Fo Us=MessageFoUs")]
    [DataMember()]
    public string MessageFoUs { get; set; }

    [System.ComponentModel.Description("Bouton Fr=BoutonFr")]
    [DataMember()]
    public string BoutonFr { get; set; }

    [System.ComponentModel.Description("Bouton Us=BoutonUs")]
    [DataMember()]
    public string BoutonUs { get; set; }
  }

  [DataContract()]
  public class MarcheProjectionFiltrageData
  {
    [System.ComponentModel.Description("$$IdFiltrage")]
    [DataMember()]
    public string IdFiltrage { get; set; }

    [System.ComponentModel.Description("Visible?=Visible")]
    [DataMember()]
    public bool Visible { get; set; }

    [System.ComponentModel.Description("Libellé Fr=LibelleFr")]
    [DataMember()]
    public string LibelleFr { get; set; }

    [System.ComponentModel.Description("Libellé Us=LibelleUs")]
    [DataMember()]
    public string LibelleUs { get; set; }
  }

  [DataContract()]
  public class MarcheProjectionDroitData
  {
    [DataMember()]
    public int? IdDroit { get; set; }

    [DataMember()]
    public int IdPersonne { get; set; }

    [DataMember()]
    public int IdProjection { get; set; }

    [DataMember()]
    public string Droit { get; set; }

    [System.ComponentModel.Description("$$$NomPersonne")]
    [DataMember()]
    public string NomPersonne { get; set; }
  }


  [DataContract()]
  public class MarcheProjectionRoleData
  {
    [System.ComponentModel.Description("Id.=IdRole")]
    [DataMember()]
    public string IdRole { get; set; }

    [System.ComponentModel.Description("Libelle=Libelle")]
    [DataMember()]
    public string Libelle { get; set; }
  }

  [DataContract()]
  public class MarcheStatutFacturationProjectionData
  {
    [System.ComponentModel.Description("Code=IdStatut")]
    [DataMember()]
    public string IdStatut { get; set; }

    [System.ComponentModel.Description("Statut=Statut")]
    [DataMember()]
    public string Statut { get; set; }

    [System.ComponentModel.Description("Ordre=Ordre")]
    [DataMember()]
    public int? Ordre { get; set; }

    [System.ComponentModel.Description("$$Couleur")]
    [DataMember()]
    public string Couleur { get; set; }
  }

  public class MarcheTypeProjectionData
  {
    [DataMember()]
    public string IdTypeProjection { get; set; }

    [DataMember()]
    public string TypeProjection { get; set; }
  }

}
