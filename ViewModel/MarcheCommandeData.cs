using Microsoft.VisualBasic;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace GrapesJsEditorHtml.ViewModel
{

    public class MarcheCommandeData
    {


      [Description("Identifiant=IdCommande")]
    
      [DataMember()]
      public int? Id { get; set; }

      [Description("Date création=DateCreation")]

      [DataMember()]
      public DateTime DateCreation { get; set; }

      [Description("Date modif.=DateModification")]
  
      [DataMember()]
      public DateTime DateModification { get; set; }

      [Description("$$IdUtilisateurModification")]
      [DataMember()]
      public int? IdUtilisateurModification { get; set; }

      [Description("Date commande=DateCommande")]

      [DataMember()]
      public DateTime? DateCommande { get; set; }

      [Description("$$IdCommandeStand")]
      [DataMember()]
      public int? IdCommandeStand { get; set; }

      [Description("$$IdTypeCommande")]
      [DataMember()]
      public string IdTypeCommande { get; set; }

      [Description("TypeCommande=mTypesCommandes")]
      
      [DataMember()]
      public MarcheTypeCommandeData TypeCommande { get; set; }

      [Description("$$IdSociete")]
      [DataMember()]
      public int? IdSociete { get; set; }

      [Description("Société=Societes")]
  
      [DataMember()]
      public SocieteData Societe { get; set; }

      // <Description("$$IdSocieteFacturee")>
      // <DataMember()>
      // Property IdSocieteFacturee As Integer?

      // <Description("$$Société facturée")>
      // <DataMember()>
      // Property SocieteFacturee As SocieteData

      [Description("$$IdSocieteDecoratrice")]
      [DataMember()]
      public int? IdSocieteDecoratrice { get; set; }

      [Description("Société décoratrice=SocieteDecoratrice")]
      [DataMember()]
      public SocieteData SocieteDecoratrice { get; set; }

      [Description("Contact=Personnes")]

      [DataMember()]
      public PersonneData Contact { get; set; }

      // Seulement pour les mailings
      [Description("Contact2=Contact2")]
   
      [DataMember()]
      public PersonneData Contact2 { get; set; }

      [Description("$$IdCompte")]
      [DataMember()]
      public int? IdCompte { get; set; }

      [Description("$$Compte")]
      [DataMember()]
      public CompteData Compte { get; set; }

      [Description("Année=Annee")]

      [DataMember()]
      public string Annee { get; set; }

      [Description("Référence=Reference")]
   
      [DataMember()]
      public string Reference { get; set; }

      [Description("Montant=MontantFacture")]

      [DataMember()]
      public double? MontantFacture { get; set; }

      [Description("Payé?=Paye")]
  
      [DataMember()]
      public bool Paye { get; set; }

      [Description("Code Statut exposant=Statut")]
   
      [DataMember()]
      public string CodeStatut { get; set; }

      [Description("Statut exposant=mStatutsCommandes")]
  
      [DataMember()]
      public StatutCommandeData Statut { get; set; }

      [Description("Code Statut paiement=StatutPaiement")]
   
      [DataMember()]
      public string CodeStatutPaiement { get; set; }

      [Description("Statut paiement=mStatutsPaiements")]
    
      [DataMember()]
      public StatutPaiementData StatutPaiement { get; set; }

      [Description("Date Statut=DateStatut")]

      [DataMember()]
      public DateTime? DateStatut { get; set; }

      [Description("Surface stand=Surface")]
      
      [DataMember()]
      public double? Surface { get; set; }

      [Description("Surface terrasse=SurfaceTerrasse")]
    
      [DataMember()]
      public double? SurfaceTerrasse { get; set; }

      [Description("Code Lieu=Lieu")]

      [DataMember()]
      public string IdLieu { get; set; }

      [Description("Lieu=mCommandesLieux")]
  
      [DataMember()]
      public CommandeLieuData Lieu { get; set; }

      [Description("Nb. bdg gratuit=NbBadgeGratuit")]

      [DataMember()]
      public int? NbBadgeGratuit { get; set; }

      [Description("Nb. bdg Online gratuit=NbOnlineGratuit")]
      [DataMember()]
      public int? NbOnlineGratuit { get; set; }


      [Description("Nb. bdg Festival=NbBadgeFestival")]

      [DataMember()]
      public int? NbBadgeFestival { get; set; }

      [Description("Nb. badges visit.")]

      [DataMember()]
      public int? NbBadgeJournalier
      {
        get
        {
          return System.Convert.ToInt32(Interaction.IIf(NbBadgeJournalierGratuit == null, 0, NbBadgeJournalierGratuit)) + System.Convert.ToInt32(Interaction.IIf(NbBadgeJournalierPayant == null, 0, NbBadgeJournalierPayant));
        }
        set
        {
        }
      }

      [Description("Nb. badges visit. payant=NbBadgeJournalier")]
     
      [DataMember()]
      public int? NbBadgeJournalierPayant { get; set; }

      [Description("Nb. badges visit. gratuit=NbBadgeJournalierGratuit")]
    
      [DataMember()]
      public int? NbBadgeJournalierGratuit { get; set; }

      [Description("Nb. jours bdg montages=NbBadgeMontage")]
   
      [DataMember()]
      public int? NbBadgeMontage { get; set; }

      [Description("$$IdHotesse1")]
      [DataMember()]
      public int? IdHotesse1 { get; set; }

      [Description("$$IdHotesse2")]
      [DataMember()]
      public int? IdHotesse2 { get; set; }

      // <Description("Badges journalier?=BadgesJournalier")>
      // <DataMember()>
      // Property BadgesJournalier As Boolean

      [Description("Fichier contrat=FichierContrat")]
   
      [DataMember()]
      public string FichierContrat { get; set; }

      [Description("N° Stand=NoStand")]
   
      [DataMember()]
      public string NoStand { get; set; }

      [Description("Stand Tel.=StandTel")]
  
      [DataMember()]
      public string StandTel { get; set; }

      [Description("$$IdTypeExposant")]
      [DataMember()]
      public string IdTypeExposant { get; set; }

      [Description("Type exposant=mTypesExposants")]
     
      [DataMember()]
      public TypeExposantData TypeExposant { get; set; }

      [Description("$$IdTypeStand")]
      [DataMember()]
      public string IdTypeStand { get; set; }

      [Description("Type stand=mTypesStands")]
 
      [DataMember()]
      public TypeStandData TypeStand { get; set; }

      [Description("$$IdReport")]
      [DataMember()]
      public int? IdReport { get; set; }

      [Description("$$IdOperation")]
      [DataMember()]
      public int? IdOperation { get; set; }

      [Description("$$IdFacture")]
      [DataMember()]
      public int? IdFacture { get; set; }

      [Description("Cmd en ligne?=CommandeEnLigne")]
      
      [DataMember()]
      public bool CommandeEnLigne { get; set; }

      [Description("Remise décorateur?=RemiseDecorateur")]
   
      [DataMember()]
      public bool RemiseDecorateur { get; set; }

      [Description("Facturé?=Facture")]
    
      [DataMember()]
      public bool Facture { get; set; }

      [Description("Co-exposant=CoExposant")]
      [DataMember()]
      public string CoExposant { get; set; }

      [Description("Sous-exposant=SousExposant")]
      [DataMember()]
      public string SousExposant { get; set; }

      [Description("Représentant=Representant")]
      [DataMember()]
      public string Representant { get; set; }

      [Description("Représentés=Representes")]
      [DataMember()]
      public string Representes { get; set; }

      [Description("Société facturée=SocieteFacturee")]
 
      [DataMember()]
      public string SocieteFacturee { get; set; }

      [Description("Adresse facturation=AdresseFacturation")]
   
      [DataMember()]
      public string AdresseFacturation { get; set; }

      [Description("N° Tva Intra. facture=NumeroTvaIntraFacture")]
     
      [DataMember()]
      public string NumeroTvaIntraFacture { get; set; }

      [Description("Société facturée paye Tva?=SocieteFactureeTva")]
     
      [DataMember()]
      public bool SocieteFactureeTva { get; set; }


      [Description("Compensation carbone=CompensationEnv")]
      [DataMember()]
      public double? CompensationEnv { get; set; }

      [Description("$$Info")]
      [DataMember()]
      public MarcheCommandeInfoDetailleeData InfoDetaillee { get; set; }

      //[Description("$$FiltreMenu")]
      //[DataMember()]
      //public string FiltreMenu { get; set; } = "NNNNYNNNNNNNNNNNNNNN";

      //[Description("Masquer moquette")]
//      public bool Filtre1
//      {
//        get
//        {
//          if (FiltreMenu.Length > 0)
//            return System.Convert.ToBoolean(Interaction.IIf(FiltreMenu.Substring(0, 1) == "Y", true, false));
//          else
//            return false;
//        }
//        set
//        {
//          if (FiltreMenu == "")
//            FiltreMenu = "NNNNYNNNNNNNNNNNNNNN";
//          if (value)
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 1, 1)' at character 8544
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 1, 1) = "Y"

// */
//          else
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 1, 1)' at character 8591
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 1, 1) = "N"

// */
//        }
//      }

//      [Description("Masquer mob. contr. ")]
//      public bool Filtre2
//      {
//        get
//        {
//          if (FiltreMenu.Length > 1)
//            return System.Convert.ToBoolean(Interaction.IIf(FiltreMenu.Substring(1, 1) == "Y", true, false));
//          else
//            return false;
//        }
//        set
//        {
//          if (FiltreMenu == "")
//            FiltreMenu = "NNNNYNNNNNNNNNNNNNNN";
//          if (value)
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 2, 1)' at character 9024
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 2, 1) = "Y"

// */
//          else
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 2, 1)' at character 9071
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 2, 1) = "N"

// */
//        }
//      }

//      [Description("Masquer enseigne")]
//      public bool Filtre3
//      {
//        get
//        {
//          if (FiltreMenu.Length > 2)
//            return System.Convert.ToBoolean(Interaction.IIf(FiltreMenu.Substring(2, 1) == "Y", true, false));
//          else
//            return false;
//        }
//        set
//        {
//          if (FiltreMenu == "")
//            FiltreMenu = "NNNNYNNNNNNNNNNNNNNN";
//          if (value)
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 3, 1)' at character 9500
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 3, 1) = "Y"

// */
//          else
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 3, 1)' at character 9547
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 3, 1) = "N"

// */
//        }
//      }

//      [Description("Maquer cloisons")]
//      public bool Filtre4
//      {
//        get
//        {
//          if (FiltreMenu.Length > 3)
//            return System.Convert.ToBoolean(Interaction.IIf(FiltreMenu.Substring(3, 1) == "Y", true, false));
//          else
//            return false;
//        }
//        set
//        {
//          if (FiltreMenu == "")
//            FiltreMenu = "NNNNYNNNNNNNNNNNNNNN";
//          if (value)
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 4, 1)' at character 9975
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 4, 1) = "Y"

// */
//          else
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 4, 1)' at character 10022
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 4, 1) = "N"

// */
//        }
//      }

//      [Description("Masquer soc. representée")]
//      public bool Filtre5
//      {
//        get
//        {
//          if (FiltreMenu.Length > 4)
//            return System.Convert.ToBoolean(Interaction.IIf(FiltreMenu.Substring(4, 1) == "Y", true, false));
//          else
//            return false;
//        }
//        set
//        {
//          if (FiltreMenu == "")
//            FiltreMenu = "NNNNYNNNNNNNNNNNNNNN";
//          if (value)
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 5, 1)' at character 10459
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 5, 1) = "Y"

// */
//          else
//            ;/* Cannot convert AssignmentStatementSyntax, CONVERSION ERROR: Conversion for MidExpression not implemented, please report this issue in 'Mid(FiltreMenu, 5, 1)' at character 10506
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitMidExpression(MidExpressionSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MidExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitAssignmentStatement(AssignmentStatementSyntax node)
//   at Microsoft.CodeAnalysis.VisualBasic.Syntax.AssignmentStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
//   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
//   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

//Input: 
//        Mid(FiltreMenu, 5, 1) = "N"

// */
//        }
//      }

      [Description("Notes=Notes")]

      [DataMember()]
      public string Notes { get; set; }

      [Description("$$Produits")]
      [DataMember()]
      public List<MarcheCommandeProduitData> Produits { get; set; }

      [Description("Condition contrat=fOperations")]
    
      [DataMember()]
      public OperationData Operation { get; set; }

      [Description("Facture=Facture")]
     
      [DataMember()]
      public OperationData OperationFacture { get; set; }

      [Description("Libellé")]
    
      [DataMember()]
      public string LibelleFr
      {
        get
        {
          if (TypeStand == null || Lieu == null || Surface == null)
          {
            if (Societe != null)
              return Societe.Nom;
            else
              return "";
          }
          else
          {
            string _Ret = TypeStand.Libelle;
            // If NoStand <> "" Then _Ret += " " + NoStand
            _Ret += " " + Lieu.Libelle;
            if (Surface > 0)
              _Ret += " " + Surface.ToString() + "m²";
            return _Ret;
          }
        }
        set
        {
        }
      }

      [Description("Libellé Us")]

      [DataMember()]
      public string LibelleUs
      {
        get
        {
          if (TypeStand == null || Lieu == null || Surface == null)
            return "";
          else
          {
            string _Ret = TypeStand.LibelleUs;
            // If NoStand <> "" Then _Ret += " " + NoStand
            _Ret += " " + Lieu.Libelle;
            if (Surface > 0)
              _Ret += " " + Surface.ToString() + "m²";
            return _Ret;
          }
        }
        set
        {
        }
      }

      //[Description("$$Titre")]
      //[DataMember()]
      //public string TitreFr
      //{
      //  get
      //  {
      //    if (TypeStand == null || Lieu == null)
      //    {
      //      if (Societe != null)
      //        return Societe.Nom;
      //      else
      //        return "";
      //    }
      //    else
      //    {
      //      string _Ret = "";
      //      if (IdTypeStand == "PAV")
      //        _Ret = "Mon Pavillon " + Lieu.Libelle;
      //      else if (CodeStatut == "ANN")
      //        _Ret = "Mon Stand " + Lieu.Libelle + " est annulé";
      //      else
      //        _Ret = "Mon Stand " + Lieu.Libelle;
      //      return _Ret;
      //    }
      //  }
      //  set
      //  {
      //  }
      //}


      [Description("$$TitreUs")]
      [DataMember()]
      public string TitreUs
      {
        get
        {
          if (TypeStand == null || Lieu == null)
          {
            if (Societe != null)
              return Societe.Nom;
            else
              return "";
          }
          else
          {
            string _Ret = "";
            if (IdTypeStand == "PAV")
              _Ret = "My " + Lieu.Libelle + " Pavillon";
            else if (CodeStatut == "ANN")
              _Ret = "My " + Lieu.Libelle + " Booth is canceled";
            else
              _Ret = "My " + Lieu.Libelle + " Booth";
            return _Ret;
          }
        }
        set
        {
        }
      }


      [Description("$$Produit stand")]
      [DataMember()]
      public MarcheCommandeProduitData ProduitStand
      {
        get
        {
          if (Produits != null)
          {
            foreach (MarcheCommandeProduitData _Produit in Produits)
            {
              if (_Produit.Produit != null && _Produit.Produit.IdLieu != "")
                return _Produit;
            }
          }
          return null/* TODO Change to default(_) if this is not a reference type */;
        }
        set
        {
        }
      }


      [Description("$$Produit stand")]
      [DataMember()]
      public MarcheCommandeProduitData ProduitTerrasse
      {
        get
        {
          if (Produits != null)
          {
            foreach (MarcheCommandeProduitData _Produit in Produits)
              ;/* Cannot convert MultiLineIfBlockSyntax, System.NotSupportedException: LikeExpression not supported!
   at ICSharpCode.CodeConverter.CSharp.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context)
   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.BinaryExpressionSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at ICSharpCode.CodeConverter.CSharp.VisualBasicConverter.MethodBodyVisitor.VisitMultiLineIfBlock(MultiLineIfBlockSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MultiLineIfBlockSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.Visit(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
   at ICSharpCode.CodeConverter.CSharp.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)

Input: 
          If _Produit.Produit IsNot Nothing AndAlso _Produit.Produit.LibelleFr.ToLower Like "*terra*e*" Then
            Return _Produit
          End If

 */
          }
          return null/* TODO Change to default(_) if this is not a reference type */;
        }
        set
        {
        }
      }
    }

    [DataContract()]
    public class MarchePanierData
    {
      [Description("$$Id")]
      [DataMember()]
      public int? IdPanier { get; set; }

      [Description("Année=Annee")]
      [DataMember()]
      public string Annee { get; set; }

      [Description("$$IdCommande")]
      [DataMember()]
      public int? IdCommande { get; set; }

      [Description("$$IdProduit")]
      [DataMember()]
      public int? IdProduit { get; set; }

      [Description("$$Produit=mProduits")]
      [DataMember()]
      public MarcheProduitData Produit { get; set; }

      [Description("Quantité=Quantite")]
      [DataMember()]
      public int Quantite { get; set; }

      // <Description("$$$Libellé Fr")>
      // <DataMember()>
      // Property LibelleFr As String

      // <Description("$$$Libellé Us")>
      // <DataMember()>
      // Property LibelleUs As String


      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }

      [Description("Montant unitaire")]
      [DataMember()]
      public double? Montant { get; set; }

      [Description("$$$Prix total")]
      [DataMember()]
      public double? PrixTotal
      {
        get
        {
          if (Montant == null)
            return 0;
          else
            return Math.Round(System.Convert.ToDouble(Montant * Quantite), 2);
        }
        set
        {
        }
      }
    }

    [Serializable]
    [DataContract()]
    public class TypeExposantData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdTypeExposant { get; set; }

      [Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }
    }

    [Serializable]
    [DataContract()]
    public class TypeStandData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdTypeStand { get; set; }

      [Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }

      [Description("Libellé Us=LibelleUs")]
      [DataMember()]
      public string LibelleUs { get; set; }

      [Description("$$Image")]
      [DataMember()]
      public string Image { get; set; }
    }

    [Serializable]
    [DataContract()]
    public class StatutExposantData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdStatut { get; set; }

      [Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }
    }

    [Serializable]
    [DataContract()]
    public class StatutCommandeData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdStatut { get; set; }

      [Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }
    }

    [Serializable]
    [DataContract()]
    public class StatutPaiementData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdStatut { get; set; }

      [Description("$$Ordre")]
      [DataMember()]
      public int Ordre { get; set; }

      [Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }
    }

    [Serializable]
    [DataContract()]
    public class CommandeLieuData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdLieu { get; set; }

      [Description("Visible=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }

      [Description("Nb. badges Festival=NbBadgeFestival")]
      [DataMember()]
      public int NbBadgeFestival { get; set; }

      [Description("$$Image")]
      [DataMember()]
      public string Image { get; set; }
    }

    [Serializable]
    [DataContract()]
    public class MarcheTypeCommandeData
    {
      [Description("$$Id")]
      [DataMember()]
      public string IdTypeCommande { get; set; }

      [Description("Visible?=Visible")]
      [DataMember()]
      public bool Visible { get; set; }

      [Description("Libellé=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }
    }

    [DataContract()]
    public class MarcheAssuranceStandData
    {
      [System.ComponentModel.Description("$$IdAssurance")]
      [DataMember()]
      public int? IdAssurance { get; set; }

      [System.ComponentModel.Description("$$IdLieu")]
      [DataMember()]
      public string IdLieu { get; set; }

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
    public class MarcheCompensationStandData
    {
      [System.ComponentModel.Description("$$IdCompensation")]
      [DataMember()]
      public int? IdCompensation { get; set; }

      [System.ComponentModel.Description("$$SurfaceMin")]
      [DataMember()]
      public double SurfaceMin { get; set; }

      [System.ComponentModel.Description("$$SurfaceMax")]
      [DataMember()]
      public double SurfaceMax { get; set; }

      [System.ComponentModel.Description("$$Montant")]
      [DataMember()]
      public double Montant { get; set; }
    }


    [DataContract()]
    public class MarcheCommandeInfoDetailleeData
    {
     

      [Description("$$Id")]
      [DataMember()]
      public int? IdInfoDetaillee { get; set; }

      [Description("$$IdCommande")]
      [DataMember()]
      public int IdCommande { get; set; }

      [Description("$$N° Ligne=IdLigne")]
      [DataMember()]
      public int IdLigne { get; set; } = 0;

      [Description("Prestataire=Prestataire")]
    
      [DataMember()]
      public string Prestataire { get; set; }

      [Description("Representé par=RepresentePar")]
    
      [DataMember()]
      public string RepresentePar { get; set; }

      [Description("Type matériel=TypeMateriel")]
 
      [DataMember()]
      public string TypeMateriel { get; set; }

      [Description("Date vérif.=DateVerification")]
   
      [DataMember()]
      public string DateVerification { get; set; }

      [Description("Visa entreprise=VisasEntreprise")]
     
      [DataMember()]
      public string VisasEntreprise { get; set; }

      [Description("Presta. Société=PrestaNom")]
    
      [DataMember()]
      public string PrestaNom { get; set; }

      [Description("Presta. Adresse 1=PrestaAdresse1")]
 
      [DataMember()]
      public string PrestaAdresse1 { get; set; }

      [Description("Presta. Adresse 2=PrestaAdresse2")]

      [DataMember()]
      public string PrestaAdresse2 { get; set; }

      [Description("Presta. Cp=PrestaCp")]
 
      [DataMember()]
      public string PrestaCp { get; set; }

      [Description("Presta. Ville=PrestaVille")]
   
      [DataMember()]
      public string PrestaVille { get; set; }

      [Description("Presta. Pays=PrestaPays")]
   
      [DataMember()]
      public string PrestaPays { get; set; }

      [Description("Presta. Tel=PrestaTel")]

      [DataMember()]
      public string PrestaTel { get; set; }

      [Description("Presta. Fax=PrestaFax")]
   
      [DataMember()]
      public string PrestaFax { get; set; }

      [Description("Presta. Email=PrestaEmail")]

      [DataMember()]
      public string PrestaEmail { get; set; }

      [Description("Presta. délégué=PrestaDelegue")]
      
      [DataMember()]
      public string PrestaDelegue { get; set; }

      [Description("Presta. fonction=PrestaFonction")]
   
      [DataMember()]
      public string PrestaFonction { get; set; }

      [Description("Presta. Nb. salariés=PrestaNbSalaries")]
     
      [DataMember()]
      public string PrestaNbSalaries { get; set; }

      [Description("Société décoratrice=SocieteDecoratice")]
    
      [DataMember()]
      public string SocieteDecoratice { get; set; }

      [Description("Contact nom=ContactNom")]
  
      [DataMember()]
      public string ContactNom { get; set; }

      [Description("Contact prénom=ContactPrenom")]
    
      [DataMember()]
      public string ContactPrenom { get; set; }

      [Description("Contact tel=ContactTelephone")]
    
      [DataMember()]
      public string ContactTelephone { get; set; }

      [Description("Village Pays=VillagePays")]
    
      [DataMember()]
      public string VillagePays { get; set; }

      [Description("Village Nom=VillageNom")]
    
      [DataMember()]
      public string VillageNom { get; set; }

      [Description("Village Adresse=VillageAdresse")]
    
      [DataMember()]
      public string VillageAdresse { get; set; }

      [Description("Village Contact=VillageContact")]

      [DataMember()]
      public string VillageContact { get; set; }

      [Description("Village Tel=VillageTelephone")]
  
      [DataMember()]
      public string VillageTelephone { get; set; }

      [Description("Village Email=VillageEmail")]
  
      [DataMember()]
      public string VillageEmail { get; set; }

      [Description("Village Contact 2=VillageContact2")]
    
      [DataMember()]
      public string VillageContact2 { get; set; }

      [Description("Village Tel 2=VillageTelephone2")]
     
      [DataMember()]
      public string VillageTelephone2 { get; set; }

      [Description("Village Email 2=VillageEmail2")]
   
      [DataMember()]
      public string VillageEmail2 { get; set; }

      [Description("Moquette=Moquette")]
    
      [DataMember()]
      public string Moquette { get; set; }

      [Description("Enseigne 1=Enseigne1")]
   
      [DataMember()]
      public string Enseigne1 { get; set; }

      [Description("Enseigne 2=Enseigne2")]
    
      [DataMember()]
      public string Enseigne2 { get; set; }

      [Description("Enseigne Publication=EnseignePublication")]
    
      [DataMember()]
      public string EnseignePublication { get; set; }

      [Description("Stockage Nom=StockageNom")]
  
      [DataMember()]
      public string StockageNom { get; set; }

      [Description("Stockage Prénom=StockagePrenom")]

      [DataMember()]
      public string StockagePrenom { get; set; }

      [Description("Stockage Tel=StockageTelephone")]
     
      [DataMember()]
      public string StockageTelephone { get; set; }

      [Description("Stockage Qté=StockageQuantite")]
    
      [DataMember()]
      public int? StockageQuantite { get; set; }

      [Description("Véhicule Société=VehiculeSociete")]
 
      [DataMember()]
      public string VehiculeSociete { get; set; }

      [Description("Véhicule Arrivée=VehiculeArrivee")]
 
      [DataMember()]
      public DateTime? VehiculeArrivee { get; set; }

      [Description("Véhicule Marque=VehiculeMarque")]
   
      [DataMember()]
      public string VehiculeMarque { get; set; }

      [Description("Véhicule Modèle=VehiculeModele")]
     
      [DataMember()]
      public string VehiculeModele { get; set; }

      [Description("Véhicule Volume=VehiculeVolume")]

      [DataMember()]
      public string VehiculeVolume { get; set; }

      [Description("Véhicule immatriculation=VehiculeImmatriculation")]
   
      [DataMember()]
      public string VehiculeImmatriculation { get; set; }

      [Description("Véhicule portable=VehiculePortable")]
    
      [DataMember()]
      public string VehiculePortable { get; set; }

      [Description("Véhicule dechgt.")]
    
      [DataMember()]
      public string VehiculeLibLieu_NOSAVE { get; set; }

      [Description("$$VehiculeLieu=VehiculeLieu")]
  
      [DataMember()]
      public string VehiculeLieu { get; set; }

      [Description("Véhicule ville orig.")]
    
      [DataMember()]
      public string VehiculeVille { get; set; }

      [Description("Véhicule pays orig.")]
  
      [DataMember()]
      public string VehiculePays { get; set; }

      [Description("Véhicule Km")]
     
      [DataMember()]
      public string VehiculeKm { get; set; }

      [Description("Véhicule Rotation")]
   
      [DataMember()]
      public string VehiculeRotation { get; set; }

      [Description("Véhicule Motorisation")]
   
      [DataMember()]
      public string VehiculeMotorisation { get; set; }

      [Description("Véhicule Réfrigéré")]
     
      [DataMember()]
      public string VehiculeRefrigere { get; set; }

      [Description("Vehicule statut=VehiculeStatut")]
   
      [DataMember()]
      public string VehiculeStatut { get; set; }

      [Description("Sous-Traitant Nom=SousTraitantNom")]
 
      [DataMember()]
      public string SousTraitantNom { get; set; }

      [Description("Sous-Traitant Pays=SousTraitantPays")]
     
      [DataMember()]
      public string SousTraitantPays { get; set; }

      [Description("Sous-Traitant Responsable=SousTraitantResponsable")]
 
      [DataMember()]
      public string SousTraitantResponsable { get; set; }

      [Description("Sous-Traitant Tel=SousTraitantTelephone")]
   
      [DataMember()]
      public string SousTraitantTelephone { get; set; }

      [Description("Sous-Traitant Email=SousTraitantEmail")]
 
      [DataMember()]
      public string SousTraitantEmail { get; set; }

      [Description("Assurance Qté=AssuranceQuantite")]
   
      [DataMember()]
      public int? AssuranceQuantite { get; set; }

      [Description("Assurance annulation=AssuranceAnnulation")]
 
      [DataMember()]
      public int? AssuranceAnnulation { get; set; }

      [Description("Drapeau=Drapeau")]
  
      [DataMember()]
      public string Drapeau { get; set; }

      [Description("EnseignePays=Enseigne Pays")]

      [DataMember()]
      public string EnseignePays { get; set; }

      [Description("AdresseLivraison=Adresse de livraison")]

      [DataMember()]
      public string AdresseLivraison { get; set; }

      // Uniquement pour les impressions

      [DataMember()]
      public MarcheCommandeData Commande { get; set; }
    }


    [DataContract()]
    public class MarcheCommandeRoleData
    {
      [System.ComponentModel.Description("Id.=IdRole")]
      [DataMember()]
      public string IdRole { get; set; }

      [System.ComponentModel.Description("Libelle=Libelle")]
      [DataMember()]
      public string Libelle { get; set; }
    }

    [DataContract()]
    public class MarcheCommandeDroitData
    {
      [DataMember()]
      public int? IdDroit { get; set; }

      [DataMember()]
      public int IdPersonne { get; set; }

      [DataMember()]
      public int IdCommande { get; set; }

      [DataMember()]
      public string IdRole { get; set; }

      [System.ComponentModel.Description("$$$NomPersonne")]
      [DataMember()]
      public string NomPersonne { get; set; }
    }


    [DataContract()]
    public class CalculatedTypeSetData
    {
      [DataMember()]
      public MarcheTypeSetData TypeSet { get; set; }

      [DataMember()]
      public int QuantiteMax { get; set; }

      [DataMember()]
      public int QuantiteCommandee { get; set; }

      [DataMember()]
      public string QuantiteTexte
      {
        get
        {
          return QuantiteCommandee.ToString() + "/" + QuantiteMax.ToString();
        }
        set
        {
        }
      }

      [DataMember()]
      public int IdCommande { get; set; }

      [DataMember()]
      public List<MarcheCommandeProduitData> Produits { get; set; }
    }

  }

