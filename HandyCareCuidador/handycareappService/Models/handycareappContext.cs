using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Tables;
using handycareappService.DataObjects;

namespace handycareappService.Models
{
    public class handycareappContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        private const string connectionStringName = "Name=MS_TableConnectionString";

        public handycareappContext() : base(connectionStringName)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        
        public virtual DbSet<Afazer> Afazer { get; set; }
        public virtual DbSet<PacienteFamiliar> PacienteFamiliar { get; set; }
        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<ConCelular> ConCelular { get; set; }
        public virtual DbSet<ConclusaoAfazer> ConclusaoAfazer { get; set; }
        public virtual DbSet<ConEmail> ConEmail { get; set; }
        public virtual DbSet<ContatoEmergencia> ContatoEmergencia { get; set; }
        public virtual DbSet<ConTelefone> ConTelefone { get; set; }
        public virtual DbSet<CorenEnfermeiro> CorenEnfermeiro { get; set; }
        public virtual DbSet<Cuidador> Cuidador { get; set; }
        public virtual DbSet<CuidadorPaciente> CuidadorPaciente { get; set; }
        public virtual DbSet<Familiar> Familiar { get; set; }
        public virtual DbSet<FormaApresentacaoMedicamento> FormaApresentacaoMedicamento { get; set; }
        public virtual DbSet<Foto> Foto { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialUtilizado> MaterialUtilizado { get; set; }
        public virtual DbSet<Medicamento> Medicamento { get; set; }
        public virtual DbSet<MedicamentoAdministrado> MedicamentoAdministrado { get; set; }
        public virtual DbSet<MotivoCuidado> MotivoCuidado { get; set; }
        public virtual DbSet<MotivoNaoConclusaoTarefa> MotivoNaoConclusaoTarefa { get; set; }
        public virtual DbSet<MotivoNaoValidacaoConclusaoAfazer> MotivoNaoValidacaoConclusaoAfazer { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<PeriodoTratamento> PeriodoTratamento { get; set; }
        public virtual DbSet<SubtipoFormaAdministracaoMedicamento> SubtipoFormaAdministracaoMedicamento { get; set; }
        public virtual DbSet<SubtipoViaAdministracaoMedicamento> SubtipoViaAdministracaoMedicamento { get; set; }
        public virtual DbSet<TipoContato> TipoContato { get; set; }
        public virtual DbSet<TipoCuidador> TipoCuidador { get; set; }
        public virtual DbSet<TipoTratamento> TipoTratamento { get; set; }
        public virtual DbSet<ValidacaoAfazer> ValidacaoAfazer { get; set; }
        public virtual DbSet<Camera> Camera { get; set; }

        public virtual DbSet<ValidacaoCuidador> ValidacaoCuidador { get; set; }
        public virtual DbSet<ViaAdministracaoMedicamento> ViaAdministracaoMedicamento { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<VideoFamiliar> VideoFamiliar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
            modelBuilder.Entity<Afazer>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Afazer>()
                .Property(e => e.AfaObservacao)
                .IsUnicode(false);

            modelBuilder.Entity<Afazer>()
                .Property(e => e.AfaPaciente)
                .IsUnicode(false);
            modelBuilder.Entity<Camera>()
    .Property(e => e.Id)
    .IsUnicode(false);

            modelBuilder.Entity<Camera>()
                .Property(e => e.CamFamiliar)
                .IsUnicode(false);

            modelBuilder.Entity<Camera>()
                .Property(e => e.CamIPv4)
                .IsUnicode(false);

            modelBuilder.Entity<Camera>()
                .Property(e => e.CamIPv6)
                .IsUnicode(false);

            modelBuilder.Entity<PacienteFamiliar>()
    .Property(e => e.PacId)
    .IsUnicode(false);

            modelBuilder.Entity<PacienteFamiliar>()
                .Property(e => e.FamId)
                .IsUnicode(false);

            modelBuilder.Entity<PacienteFamiliar>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Afazer>()
                .HasMany(e => e.ConclusaoAfazer)
                .WithRequired(e => e.Afazer)
                .HasForeignKey(e => e.ConAfazer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Afazer>()
                .HasMany(e => e.MaterialUtilizado)
                .WithRequired(e => e.Afazer)
                .HasForeignKey(e => e.MatAfazer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Afazer>()
                .HasMany(e => e.MedicamentoAdministrado)
                .WithRequired(e => e.Afazer)
                .HasForeignKey(e => e.MedAfazer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.AvaCuidador)
                .IsUnicode(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.AvaFamiliar)
                .IsUnicode(false);

            modelBuilder.Entity<Avaliacao>()
                .Property(e => e.AvaDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<ConCelular>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ConCelular>()
                .HasMany(e => e.ContatoEmergencia)
                .WithRequired(e => e.ConNumCelular)
                .HasForeignKey(e => e.ConCelular)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConclusaoAfazer>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ConclusaoAfazer>()
                .Property(e => e.ConAfazer)
                .IsUnicode(false);

            modelBuilder.Entity<ConclusaoAfazer>()
                .HasMany(e => e.MotivoNaoConclusaoTarefa)
                .WithRequired(e => e.ConclusaoAfazer)
                .HasForeignKey(e => e.MoAfazer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConclusaoAfazer>()
                .HasMany(e => e.ValidacaoAfazer)
                .WithRequired(e => e.ConclusaoAfazer)
                .HasForeignKey(e => e.ValAfazer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ConEmail>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ConEmail>()
                .Property(e => e.ConEnderecoEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ConEmail>()
                .HasMany(e => e.ContatoEmergencia)
                .WithRequired(e => e.ConEnderecoEmail)
                .HasForeignKey(e => e.ConEmail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContatoEmergencia>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ContatoEmergencia>()
                .Property(e => e.ConTelefone)
                .IsUnicode(false);

            modelBuilder.Entity<ContatoEmergencia>()
                .Property(e => e.ConCelular)
                .IsUnicode(false);

            modelBuilder.Entity<ContatoEmergencia>()
                .Property(e => e.ConEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ContatoEmergencia>()
                .Property(e => e.ConTipo)
                .IsUnicode(false);

            modelBuilder.Entity<ContatoEmergencia>()
                .Property(e => e.ConPessoa)
                .IsUnicode(false);

            modelBuilder.Entity<ConTelefone>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ConTelefone>()
                .Property(e => e.ConNumTelefone)
                .IsUnicode(false);

            modelBuilder.Entity<ConTelefone>()
                .HasMany(e => e.ContatoEmergencia)
                .WithRequired(e => e.ConNumTelefone)
                .HasForeignKey(e => e.ConTelefone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CorenEnfermeiro>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<CorenEnfermeiro>()
                .Property(e => e.CorenIdentificacao)
                .IsUnicode(false);

            modelBuilder.Entity<CorenEnfermeiro>()
                .HasMany(e => e.ValidacaoCuidador)
                .WithOptional(e => e.CorenEnfermeiro1)
                .HasForeignKey(e => e.CorenEnfermeiro);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.CuiTipoCuidador)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.CuiValidacaoCuidador)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.CuiNome)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.CuiSobrenome)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.CuiCidade)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .Property(e => e.CuiEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Cuidador>()
                .HasMany(e => e.Avaliacao)
                .WithRequired(e => e.Cuidador)
                .HasForeignKey(e => e.AvaCuidador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuidador>()
                .HasMany(e => e.ContatoEmergencia)
                .WithRequired(e => e.Cuidador)
                .HasForeignKey(e => e.ConPessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuidador>()
                .HasMany(e => e.CuidadorPaciente)
                .WithRequired(e => e.Cuidador)
                .HasForeignKey(e => e.CuiId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuidador>()
                .HasMany(e => e.Foto)
                .WithRequired(e => e.Cuidador)
                .HasForeignKey(e => e.FotCuidador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuidador>()
                .HasMany(e => e.Video)
                .WithRequired(e => e.Cuidador)
                .HasForeignKey(e => e.VidCuidador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CuidadorPaciente>()
                .Property(e => e.CuiId)
                .IsUnicode(false);

            modelBuilder.Entity<CuidadorPaciente>()
                .Property(e => e.PacId)
                .IsUnicode(false);

            modelBuilder.Entity<CuidadorPaciente>()
                .Property(e => e.CuiPeriodoTratamento)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamParentesco)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamContatoEmergencia)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamNome)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamSobrenome)
                .IsUnicode(false);
            modelBuilder.Entity<Familiar>()
    .HasMany(e => e.Avaliacao)
    .WithRequired(e => e.Familiar)
    .HasForeignKey(e => e.AvaFamiliar)
    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Familiar>()
            .Property(e => e.Id)
            .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamParentesco)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamContatoEmergencia)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamNome)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.FamSobrenome)
                .IsUnicode(false);

            modelBuilder.Entity<Familiar>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Familiar>()
                .HasMany(e => e.FotoFamiliar)
                .WithRequired(e => e.Familiar)
                .HasForeignKey(e => e.FamId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Familiar>()
    .HasMany(e => e.VideoFamiliar)
    .WithRequired(e => e.Familiar)
    .HasForeignKey(e => e.VidId)
    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Familiar>()
.HasMany(e => e.Camera)
.WithRequired(e => e.Familiar)
.HasForeignKey(e => e.CamFamiliar)
.WillCascadeOnDelete(false);
            modelBuilder.Entity<Familiar>()
.HasMany(e => e.PacienteFamiliar)
.WithRequired(e => e.Familiar)
.HasForeignKey(e => e.FamId)
.WillCascadeOnDelete(false);
            modelBuilder.Entity<FormaApresentacaoMedicamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<FormaApresentacaoMedicamento>()
                .Property(e => e.ForSubtipo)
                .IsUnicode(false);

            modelBuilder.Entity<FormaApresentacaoMedicamento>()
                .Property(e => e.FormaApresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<FormaApresentacaoMedicamento>()
                .HasMany(e => e.Medicamento)
                .WithRequired(e => e.FormaApresentacaoMedicamento)
                .HasForeignKey(e => e.MedApresentacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.FotoDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.FotCuidador)
                .IsUnicode(false);

            modelBuilder.Entity<Foto>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Foto>()
                .HasMany(e => e.FotoFamiliar)
                .WithRequired(e => e.Foto)
                .HasForeignKey(e => e.FotId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FotoFamiliar>()
                .Property(e => e.FamId)
                .IsUnicode(false);

            modelBuilder.Entity<FotoFamiliar>()
                .Property(e => e.FotId)
                .IsUnicode(false);

            modelBuilder.Entity<FotoFamiliar>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Material>()
                .Property(e => e.MatDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Material>()
                .Property(e => e.MatQuantidade)
                .IsRequired();

            modelBuilder.Entity<Material>()
                 .Property(e => e.Version)
                 .IsFixedLength()
                 .IsRowVersion();

            modelBuilder.Entity<Material>()
                .HasMany(e => e.MaterialUtilizado)
                .WithRequired(e => e.Material)
                .HasForeignKey(e => e.MatUtilizado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaterialUtilizado>()
                .Property(e => e.MatAfazer)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialUtilizado>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MaterialUtilizado>()
                .Property(e => e.MatUtilizado)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamento>()
                .Property(e => e.MedApresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamento>()
                .Property(e => e.MedViaAdministracao)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamento>()
                .Property(e => e.MedDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamento>()
                .HasMany(e => e.MedicamentoAdministrado)
                .WithRequired(e => e.Medicamento)
                .HasForeignKey(e => e.MedAdministrado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedicamentoAdministrado>()
                .Property(e => e.MedAfazer)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentoAdministrado>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentoAdministrado>()
                .Property(e => e.MedAdministrado)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoCuidado>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoCuidado>()
                .Property(e => e.MotDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoCuidado>()
                .HasMany(e => e.Paciente)
                .WithRequired(e => e.MotivoCuidado)
                .HasForeignKey(e => e.PacMotivoCuidado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoCuidado>()
                .HasMany(e => e.TipoTratamento)
                .WithRequired(e => e.MotivoCuidado)
                .HasForeignKey(e => e.TipCuidado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoNaoConclusaoTarefa>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoNaoConclusaoTarefa>()
                .Property(e => e.MoExplicacao)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoNaoConclusaoTarefa>()
                .Property(e => e.MoAfazer)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoNaoValidacaoConclusaoAfazer>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoNaoValidacaoConclusaoAfazer>()
                .Property(e => e.MoDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoNaoValidacaoConclusaoAfazer>()
                .Property(e => e.MoValidacao)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.PacNome)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.PacSobrenome)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .Property(e => e.PacMotivoCuidado)
                .IsUnicode(false);

            modelBuilder.Entity<Paciente>()
                .HasMany(e => e.CuidadorPaciente)
                .WithRequired(e => e.Paciente)
                .HasForeignKey(e => e.PacId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Paciente>()
    .HasMany(e => e.PacienteFamiliar)
    .WithRequired(e => e.Paciente)
    .HasForeignKey(e => e.PacId)
    .WillCascadeOnDelete(false);
            modelBuilder.Entity<Parentesco>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.ParDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Parentesco>()
                .HasMany(e => e.Familiar)
                .WithRequired(e => e.Parentesco)
                .HasForeignKey(e => e.FamParentesco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PeriodoTratamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<PeriodoTratamento>()
                .HasMany(e => e.CuidadorPaciente)
                .WithRequired(e => e.PeriodoTratamento)
                .HasForeignKey(e => e.CuiPeriodoTratamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubtipoFormaAdministracaoMedicamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<SubtipoFormaAdministracaoMedicamento>()
                .Property(e => e.SubtipoFormaAdministracaoMedicamento1)
                .IsUnicode(false);

            modelBuilder.Entity<SubtipoFormaAdministracaoMedicamento>()
                .HasMany(e => e.FormaApresentacaoMedicamento)
                .WithRequired(e => e.SubtipoFormaAdministracaoMedicamento)
                .HasForeignKey(e => e.ForSubtipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubtipoViaAdministracaoMedicamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<SubtipoViaAdministracaoMedicamento>()
                .Property(e => e.SubtipoViaAdministracal)
                .IsUnicode(false);

            modelBuilder.Entity<SubtipoViaAdministracaoMedicamento>()
                .HasMany(e => e.ViaAdministracaoMedicamento)
                .WithRequired(e => e.SubtipoViaAdministracaoMedicamento)
                .HasForeignKey(e => e.ViaSubtipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContato>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContato>()
                .Property(e => e.TipDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContato>()
                .HasMany(e => e.ContatoEmergencia)
                .WithRequired(e => e.TipoContato)
                .HasForeignKey(e => e.ConTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoCuidador>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuidador>()
                .Property(e => e.TipDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuidador>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<TipoCuidador>()
                .HasMany(e => e.Cuidador)
                .WithRequired(e => e.TipoCuidador)
                .HasForeignKey(e => e.CuiTipoCuidador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoTratamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTratamento>()
                .Property(e => e.TipDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTratamento>()
                .Property(e => e.TipCuidado)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacaoAfazer>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacaoAfazer>()
                .Property(e => e.ValFamId)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacaoAfazer>()
                .Property(e => e.ValAfazer)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacaoAfazer>()
                .HasMany(e => e.MotivoNaoValidacaoConclusaoAfazer)
                .WithRequired(e => e.ValidacaoAfazer)
                .HasForeignKey(e => e.MoValidacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ValidacaoCuidador>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacaoCuidador>()
                .Property(e => e.CorenEnfermeiro)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacaoCuidador>()
                .HasMany(e => e.Cuidador)
                .WithRequired(e => e.ValidacaoCuidador)
                .HasForeignKey(e => e.CuiValidacaoCuidador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ViaAdministracaoMedicamento>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<ViaAdministracaoMedicamento>()
                .Property(e => e.ViaAdministracao)
                .IsUnicode(false);

            modelBuilder.Entity<ViaAdministracaoMedicamento>()
                .Property(e => e.ViaSubtipo)
                .IsUnicode(false);

            modelBuilder.Entity<ViaAdministracaoMedicamento>()
                .HasMany(e => e.Medicamento)
                .WithRequired(e => e.ViaAdministracaoMedicamento)
                .HasForeignKey(e => e.MedViaAdministracao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.VidDescricao)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.VidCuidador)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.Version)
                .IsFixedLength();

            modelBuilder.Entity<Video>()
                .HasMany(e => e.VideoFamiliar)
                .WithRequired(e => e.Video)
                .HasForeignKey(e => e.VidId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VideoFamiliar>()
                .Property(e => e.FamId)
                .IsUnicode(false);

            modelBuilder.Entity<VideoFamiliar>()
                .Property(e => e.VidId)
                .IsUnicode(false);

            modelBuilder.Entity<VideoFamiliar>()
                .Property(e => e.Version)
                .IsFixedLength();

            base.OnModelCreating(modelBuilder);
        }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Camera> Cameras { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.VideoFamiliar> VideoFamiliars { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Foto> Fotoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.PacienteFamiliar> PacienteFamiliars { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.FotoFamiliar> FotoFamiliars { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.TipoCuidador> TipoCuidadors { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.CuidadorPaciente> CuidadorPacientes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ValidacaoCuidador> ValidacaoCuidadors { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.MaterialUtilizado> MaterialUtilizadoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.MedicamentoAdministrado> MedicamentoAdministradoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ConCelular> ConCelulars { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ConclusaoAfazer> ConclusaoAfazers { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ConEmail> ConEmails { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ContatoEmergencia> ContatoEmergencias { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ConTelefone> ConTelefones { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.CorenEnfermeiro> CorenEnfermeiroes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Cuidador> Cuidadors { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Familiar> Familiars { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.FormaApresentacaoMedicamento> FormaApresentacaoMedicamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Foto> Fotoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Material> Materials { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Medicamento> Medicamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.MotivoCuidado> MotivoCuidadoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.MotivoNaoConclusaoTarefa> MotivoNaoConclusaoTarefas { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.MotivoNaoValidacaoConclusaoAfazer> MotivoNaoValidacaoConclusaoAfazers { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Paciente> Pacientes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Parentesco> Parentescoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.PeriodoTratamento> PeriodoTratamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.SubtipoFormaAdministracaoMedicamento> SubtipoFormaAdministracaoMedicamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.SubtipoViaAdministracaoMedicamento> SubtipoViaAdministracaoMedicamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.TipoContato> TipoContatoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.TipoTratamento> TipoTratamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ValidacaoAfazer> ValidacaoAfazers { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.ViaAdministracaoMedicamento> ViaAdministracaoMedicamentoes { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Video> Videos { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Avaliacao> Avaliacaos { get; set; }

        //public System.Data.Entity.DbSet<handycareappService.DataObjects.Afazer> Afazers { get; set; }
    }

}
