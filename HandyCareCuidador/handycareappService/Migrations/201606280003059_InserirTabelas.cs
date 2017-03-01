namespace handycareappService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InserirTabelas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Afazer", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Afazer", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Afazer", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Afazer", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Avaliacao", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Avaliacao", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Avaliacao", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Avaliacao", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ConCelular", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConCelular", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConCelular", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ConCelular", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ConclusaoAfazer", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConclusaoAfazer", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConclusaoAfazer", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ConclusaoAfazer", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ConEmail", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConEmail", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConEmail", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ConEmail", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ContatoEmergencia", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ContatoEmergencia", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ContatoEmergencia", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ContatoEmergencia", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ConTelefone", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConTelefone", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ConTelefone", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ConTelefone", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.CorenEnfermeiro", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.CorenEnfermeiro", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.CorenEnfermeiro", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.CorenEnfermeiro", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Cuidador", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Cuidador", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Cuidador", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Cuidador", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.CuidadorPaciente", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.CuidadorPaciente", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.CuidadorPaciente", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.CuidadorPaciente", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Familiar", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Familiar", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Familiar", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Familiar", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.FormaApresentacaoMedicamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.FormaApresentacaoMedicamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.FormaApresentacaoMedicamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.FormaApresentacaoMedicamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Foto", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Foto", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Foto", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Foto", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.FotoFamiliar", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.FotoFamiliar", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.FotoFamiliar", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.FotoFamiliar", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.MaterialUtilizado", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MaterialUtilizado", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MaterialUtilizado", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MaterialUtilizado", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Medicamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Medicamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Medicamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Medicamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.MedicamentoAdministrado", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MedicamentoAdministrado", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MedicamentoAdministrado", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MedicamentoAdministrado", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.MotivoCuidado", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MotivoCuidado", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MotivoCuidado", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MotivoCuidado", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.MotivoNaoConclusaoTarefa", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MotivoNaoConclusaoTarefa", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MotivoNaoConclusaoTarefa", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MotivoNaoConclusaoTarefa", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.MotivoNaoValidacaoConclusaoAfazer", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MotivoNaoValidacaoConclusaoAfazer", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.MotivoNaoValidacaoConclusaoAfazer", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.MotivoNaoValidacaoConclusaoAfazer", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Paciente", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Paciente", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Paciente", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Paciente", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.PacienteFamiliar", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.PacienteFamiliar", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.PacienteFamiliar", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.PacienteFamiliar", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.PeriodoTratamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.PeriodoTratamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.PeriodoTratamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.PeriodoTratamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.SubtipoFormaAdministracaoMedicamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.SubtipoFormaAdministracaoMedicamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.SubtipoFormaAdministracaoMedicamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.SubtipoFormaAdministracaoMedicamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.SubtipoViaAdministracaoMedicamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.SubtipoViaAdministracaoMedicamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.SubtipoViaAdministracaoMedicamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.SubtipoViaAdministracaoMedicamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.TipoTratamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.TipoTratamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.TipoTratamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.TipoTratamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ValidacaoAfazer", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ValidacaoAfazer", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ValidacaoAfazer", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ValidacaoAfazer", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ValidacaoCuidador", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ValidacaoCuidador", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ValidacaoCuidador", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ValidacaoCuidador", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.ViaAdministracaoMedicamento", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ViaAdministracaoMedicamento", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.ViaAdministracaoMedicamento", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.ViaAdministracaoMedicamento", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.Video", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Video", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Video", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Video", "Deleted", c => c.Boolean(nullable: true));

            AddColumn("dbo.VideoFamiliar", "CreatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.VideoFamiliar", "UpdatedAt", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.VideoFamiliar", "Version", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.VideoFamiliar", "Deleted", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            
        }
    }
}
