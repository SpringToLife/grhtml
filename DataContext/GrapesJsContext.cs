using GrapesJsEditorHtml.ViewModel;

using Microsoft.EntityFrameworkCore;

namespace GrapesJsEditorHtml.DataContext
{
  public partial class GrapesJsContext : DbContext
  {
    public GrapesJsContext()
    {
    }

    public GrapesJsContext(DbContextOptions<GrapesJsContext> options)
            : base(options)
    {
    }


    public virtual DbSet<SalleData> _SalleDatas { get; set; } = null!;
    public virtual DbSet<OrganisationData> _OrganisationDatas { get; set; } = null!;
    public virtual DbSet<CompteData> _CompteDatas { get; set; } = null!;
    public DbSet<CompteEtatData> _CompteEtatDatas { get; set; }
    public virtual DbSet<PersonneData> _PersonneDatas { get; set; } = null!;
    public virtual DbSet<ListeTypeData> _ListeTypeDatas { get; set; } = null!;
    public virtual DbSet<PlanData> _PlanDatas { get; set; } = null!;
    public virtual DbSet<MailerConfigData> _MailerConfigDatas { get; set; } = null!;
    public virtual DbSet<HelpData> _HelpDatas { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CompteData>()
          .HasOne(c => c.Etats)
          .WithOne()
          .HasForeignKey<CompteData>(c => c.IdCompte)
          .HasPrincipalKey<CompteEtatData>(ce => ce.ComptesEtats_IdCompteEtat);

      modelBuilder.Entity<CompteData>()
         .HasOne(c => c.Organisation)
         .WithOne()
         .HasForeignKey<CompteData>(c => c.IdOrganisation)
         .HasPrincipalKey<OrganisationAccredData>(ce => ce.IdOrganisation);

      modelBuilder.Entity<AccreditationData>()
         .HasOne(c => c.Contingent)
         .WithOne()
         .HasForeignKey<AccreditationData>(c => c.Contingent.IdOrganisation)
         .HasPrincipalKey<OrganisationData>(ce => ce.IdOrganisation);

      modelBuilder.Entity<AccreditationData>()
         .HasOne(c => c.Societe)
          .WithMany()
         .HasForeignKey(c => c.IdSociete.ToString());

      modelBuilder.Entity<AccreditationData>()
         .HasOne(c => c.IdEmetteur.ToString())
         .WithOne()
         .HasForeignKey<AccreditationData>(c => c.IdEmetteur.ToString())
         .HasPrincipalKey<EmetteurData>(ce => ce.IdEmetteur);

      modelBuilder.Entity<AccreditationData>()
         .HasOne(c => c.IdFilm.ToString())
         .WithOne()
         .HasForeignKey<AccreditationData>(c => c.IdFilm)
         .HasPrincipalKey<FilmData>(ce => ce.IdFilm);

      modelBuilder.Entity<AccreditationData>()
         .HasOne(c => c.StatutDetail.IdStatutDetail.ToString())
         .WithOne()
         .HasForeignKey<AccreditationData>(c => c.StatutDetail.IdStatutDetail)
         .HasPrincipalKey<StatutDetailData>(ce => ce.IdStatutDetail);

      modelBuilder.Entity<AccreditationData>()
         .HasOne(c => c.Statut.IdStatut.ToString())
         .WithOne()
         .HasForeignKey<AccreditationData>(c => c.Statut.IdStatut)
         .HasPrincipalKey<StatutData>(ce => ce.IdStatut);

      modelBuilder.Entity<PersonneData>()
         .HasOne(c => c.Civilite.ToString())
         .WithOne()
         .HasForeignKey<PersonneData>(c => c.Civilite.IdCivilite)
         .HasPrincipalKey<CiviliteData>(ce => ce.IdCivilite);

      modelBuilder.Entity<PersonneData>()
      .HasOne(c => c.IdPersonne.ToString())
      .WithOne()
      .HasForeignKey<PersonneData>(c => c.IdPersonne.ToString())
      .HasPrincipalKey<SocieteData>(ce => ce.Selectionneur.IdPersonne);


    }

    

  }
   

  }


       