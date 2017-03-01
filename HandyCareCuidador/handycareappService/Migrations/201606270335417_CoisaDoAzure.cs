namespace handycareappService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoisaDoAzure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Afazer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AfaHorarioPrevisto = c.DateTime(nullable: false),
                        AfaObservacao = c.String(nullable: false, maxLength: 100, unicode: false),
                        AfaMedicamento = c.Int(),
                        AfaMaterial = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConclusaoAfazer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConHorarioConcluido = c.DateTime(nullable: false),
                        ConConcluido = c.Boolean(nullable: false),
                        ConAfazer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Afazer", t => t.ConAfazer)
                .Index(t => t.ConAfazer);
            
            CreateTable(
                "dbo.MotivoNaoConclusaoTarefa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MoExplicacao = c.String(nullable: false, maxLength: 100, unicode: false),
                        MoAfazer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConclusaoAfazer", t => t.MoAfazer)
                .Index(t => t.MoAfazer);
            
            CreateTable(
                "dbo.ValidacaoAfazer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ValFamId = c.Int(nullable: false),
                        ValAfazer = c.Int(nullable: false),
                        ValValidado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Familiar", t => t.ValFamId)
                .ForeignKey("dbo.ConclusaoAfazer", t => t.ValAfazer)
                .Index(t => t.ValFamId)
                .Index(t => t.ValAfazer);
            
            CreateTable(
                "dbo.Familiar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamParentesco = c.String(nullable: false, maxLength: 36),
                        FamContatoEmergencia = c.Int(nullable: false),
                        FamNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        FamSobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parentesco", t => t.FamParentesco)
                .Index(t => t.FamParentesco);
            
            CreateTable(
                "dbo.Avaliacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AvaCuidador = c.Int(nullable: false),
                        AvaFamiliar = c.Int(nullable: false),
                        AvaPontuacao = c.Double(nullable: false),
                        AvaDescricao = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuidador", t => t.AvaCuidador)
                .ForeignKey("dbo.Familiar", t => t.AvaFamiliar)
                .Index(t => t.AvaCuidador)
                .Index(t => t.AvaFamiliar);
            
            CreateTable(
                "dbo.Cuidador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CuiTipoCuidador = c.Int(nullable: false),
                        CuiValidacaoCuidador = c.Int(nullable: false),
                        CuiNome = c.String(nullable: false, maxLength: 70, unicode: false),
                        CuiSobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        CuiCidade = c.String(nullable: false, maxLength: 80, unicode: false),
                        CuiEstado = c.String(nullable: false, maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoCuidador", t => t.CuiTipoCuidador)
                .ForeignKey("dbo.ValidacaoCuidador", t => t.CuiValidacaoCuidador)
                .Index(t => t.CuiTipoCuidador)
                .Index(t => t.CuiValidacaoCuidador);
            
            CreateTable(
                "dbo.ContatoEmergencia",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ConTipo = c.Int(nullable: false),
                        ConPessoa = c.Int(nullable: false),
                        ConTelefone = c.Int(nullable: false),
                        ConCelular = c.Int(nullable: false),
                        ConEmail = c.Int(nullable: false),
                        ConDescricao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Id, t.ConTipo, t.ConPessoa })
                .ForeignKey("dbo.ConCelular", t => t.ConCelular)
                .ForeignKey("dbo.ConEmail", t => t.ConEmail)
                .ForeignKey("dbo.ConTelefone", t => t.ConTelefone)
                .ForeignKey("dbo.TipoContato", t => t.ConTipo)
                .ForeignKey("dbo.Cuidador", t => t.ConPessoa)
                .ForeignKey("dbo.Familiar", t => t.ConPessoa)
                .Index(t => t.ConTipo)
                .Index(t => t.ConPessoa)
                .Index(t => t.ConTelefone)
                .Index(t => t.ConCelular)
                .Index(t => t.ConEmail);
            
            CreateTable(
                "dbo.ConCelular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConCelular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConEmail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConEmail = c.String(nullable: false, maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConTelefone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConTelefone = c.String(nullable: false, maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoContato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipDescricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CuidadorPaciente",
                c => new
                    {
                        CuiId = c.Int(nullable: false),
                        PacId = c.Int(nullable: false),
                        CuiPeriodoTratamento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CuiId, t.PacId })
                .ForeignKey("dbo.Paciente", t => t.PacId)
                .ForeignKey("dbo.PeriodoTratamento", t => t.CuiPeriodoTratamento)
                .ForeignKey("dbo.Cuidador", t => t.CuiId)
                .Index(t => t.CuiId)
                .Index(t => t.PacId)
                .Index(t => t.CuiPeriodoTratamento);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PacNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        PacSobrenome = c.String(nullable: false, maxLength: 100, unicode: false),
                        PacIdade = c.DateTime(nullable: false, storeType: "date"),
                        PacMotivoCuidado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MotivoCuidado", t => t.PacMotivoCuidado)
                .Index(t => t.PacMotivoCuidado);
            
            CreateTable(
                "dbo.MotivoCuidado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MotDescricao = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoTratamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipDescricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        TipCuidado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MotivoCuidado", t => t.TipCuidado)
                .Index(t => t.TipCuidado);
            
            CreateTable(
                "dbo.PeriodoTratamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PerInicio = c.DateTime(nullable: false, storeType: "date"),
                        PerTermino = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FotoDados = c.Binary(nullable: false, storeType: "image"),
                        FotoDescricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        FotCuidador = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuidador", t => t.FotCuidador)
                .Index(t => t.FotCuidador);
            
            CreateTable(
                "dbo.TipoCuidador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipDescricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ValidacaoCuidador",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ValDocumento = c.Binary(nullable: false, storeType: "image"),
                        ValValidado = c.Boolean(nullable: false),
                        CorenEnfermeiro = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CorenEnfermeiro", t => t.CorenEnfermeiro)
                .Index(t => t.CorenEnfermeiro);
            
            CreateTable(
                "dbo.CorenEnfermeiro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CorenIdentificacao = c.String(nullable: false, maxLength: 20, unicode: false),
                        CorenValidado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Video",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VidDados = c.Binary(nullable: false),
                        VidDescricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        VidCuidador = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuidador", t => t.VidCuidador)
                .Index(t => t.VidCuidador);
            
            CreateTable(
                "dbo.VideoFamiliar",
                c => new
                    {
                        FamId = c.Int(nullable: false),
                        VidId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FamId, t.VidId })
                .ForeignKey("dbo.Video", t => t.VidId)
                .Index(t => t.VidId);
            
            CreateTable(
                "dbo.Parentesco",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 36),
                        ParDescricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        Deleted = c.Boolean(nullable: false),
                        UpdatedAt = c.DateTimeOffset(precision: 7),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.CreatedAt, clustered: true);
            
            CreateTable(
                "dbo.MotivoNaoValidacaoConclusaoAfazer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MoDescricao = c.String(nullable: false, maxLength: 150, unicode: false),
                        MoValidacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ValidacaoAfazer", t => t.MoValidacao)
                .Index(t => t.MoValidacao);
            
            CreateTable(
                "dbo.MaterialUtilizado",
                c => new
                    {
                        MatAfazer = c.Int(nullable: false),
                        MatUtilizado = c.Int(nullable: false),
                        MatQuantidadeUtilizada = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MatAfazer, t.MatUtilizado })
                .ForeignKey("dbo.Material", t => t.MatUtilizado)
                .ForeignKey("dbo.Afazer", t => t.MatAfazer)
                .Index(t => t.MatAfazer)
                .Index(t => t.MatUtilizado);
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatDescricao = c.String(nullable: false, maxLength: 50, unicode: false),
                        MatQuantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicamentoAdministrado",
                c => new
                    {
                        MedAfazer = c.Int(nullable: false),
                        MedAdministrado = c.Int(nullable: false),
                        MemQuantidadeAdministrada = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MedAfazer, t.MedAdministrado })
                .ForeignKey("dbo.Medicamento", t => t.MedAdministrado)
                .ForeignKey("dbo.Afazer", t => t.MedAfazer)
                .Index(t => t.MedAfazer)
                .Index(t => t.MedAdministrado);
            
            CreateTable(
                "dbo.Medicamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedQuantidade = c.Int(nullable: false),
                        MedApresentacao = c.Int(nullable: false),
                        MedViaAdministracao = c.Int(nullable: false),
                        MedDescricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormaApresentacaoMedicamento", t => t.MedApresentacao)
                .ForeignKey("dbo.ViaAdministracaoMedicamento", t => t.MedViaAdministracao)
                .Index(t => t.MedApresentacao)
                .Index(t => t.MedViaAdministracao);
            
            CreateTable(
                "dbo.FormaApresentacaoMedicamento",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ForSubtipo = c.Int(nullable: false),
                        FormaApresentacao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubtipoFormaAdministracaoMedicamento", t => t.ForSubtipo)
                .Index(t => t.ForSubtipo);
            
            CreateTable(
                "dbo.SubtipoFormaAdministracaoMedicamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubtipoFormaAdministracaoMedicamento = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ViaAdministracaoMedicamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ViaAdministracao = c.String(nullable: false, maxLength: 50, unicode: false),
                        ViaSubtipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubtipoViaAdministracaoMedicamento", t => t.ViaSubtipo)
                .Index(t => t.ViaSubtipo);
            
            CreateTable(
                "dbo.SubtipoViaAdministracaoMedicamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubtipoViaAdministracal = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoCuidadorDtoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TipDescricao = c.String(),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdatedAt = c.DateTimeOffset(precision: 7),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CreatedAt, clustered: true);
            
            CreateTable(
                "dbo.FotoFamiliar",
                c => new
                    {
                        FamId = c.Int(nullable: false),
                        FotId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FamId, t.FotId })
                .ForeignKey("dbo.Familiar", t => t.FamId, cascadeDelete: true)
                .ForeignKey("dbo.Foto", t => t.FotId, cascadeDelete: true)
                .Index(t => t.FamId)
                .Index(t => t.FotId);
            
            CreateTable(
                "dbo.PacienteFamiliar",
                c => new
                    {
                        FamId = c.Int(nullable: false),
                        PacId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FamId, t.PacId })
                .ForeignKey("dbo.Familiar", t => t.FamId, cascadeDelete: true)
                .ForeignKey("dbo.Paciente", t => t.PacId, cascadeDelete: true)
                .Index(t => t.FamId)
                .Index(t => t.PacId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MedicamentoAdministrado", "MedAfazer", "dbo.Afazer");
            DropForeignKey("dbo.ViaAdministracaoMedicamento", "ViaSubtipo", "dbo.SubtipoViaAdministracaoMedicamento");
            DropForeignKey("dbo.Medicamento", "MedViaAdministracao", "dbo.ViaAdministracaoMedicamento");
            DropForeignKey("dbo.MedicamentoAdministrado", "MedAdministrado", "dbo.Medicamento");
            DropForeignKey("dbo.FormaApresentacaoMedicamento", "ForSubtipo", "dbo.SubtipoFormaAdministracaoMedicamento");
            DropForeignKey("dbo.Medicamento", "MedApresentacao", "dbo.FormaApresentacaoMedicamento");
            DropForeignKey("dbo.MaterialUtilizado", "MatAfazer", "dbo.Afazer");
            DropForeignKey("dbo.MaterialUtilizado", "MatUtilizado", "dbo.Material");
            DropForeignKey("dbo.ConclusaoAfazer", "ConAfazer", "dbo.Afazer");
            DropForeignKey("dbo.ValidacaoAfazer", "ValAfazer", "dbo.ConclusaoAfazer");
            DropForeignKey("dbo.MotivoNaoValidacaoConclusaoAfazer", "MoValidacao", "dbo.ValidacaoAfazer");
            DropForeignKey("dbo.ValidacaoAfazer", "ValFamId", "dbo.Familiar");
            DropForeignKey("dbo.Familiar", "FamParentesco", "dbo.Parentesco");
            DropForeignKey("dbo.PacienteFamiliar", "PacId", "dbo.Paciente");
            DropForeignKey("dbo.PacienteFamiliar", "FamId", "dbo.Familiar");
            DropForeignKey("dbo.FotoFamiliar", "FotId", "dbo.Foto");
            DropForeignKey("dbo.FotoFamiliar", "FamId", "dbo.Familiar");
            DropForeignKey("dbo.ContatoEmergencia", "ConPessoa", "dbo.Familiar");
            DropForeignKey("dbo.Avaliacao", "AvaFamiliar", "dbo.Familiar");
            DropForeignKey("dbo.Video", "VidCuidador", "dbo.Cuidador");
            DropForeignKey("dbo.VideoFamiliar", "VidId", "dbo.Video");
            DropForeignKey("dbo.Cuidador", "CuiValidacaoCuidador", "dbo.ValidacaoCuidador");
            DropForeignKey("dbo.ValidacaoCuidador", "CorenEnfermeiro", "dbo.CorenEnfermeiro");
            DropForeignKey("dbo.Cuidador", "CuiTipoCuidador", "dbo.TipoCuidador");
            DropForeignKey("dbo.Foto", "FotCuidador", "dbo.Cuidador");
            DropForeignKey("dbo.CuidadorPaciente", "CuiId", "dbo.Cuidador");
            DropForeignKey("dbo.CuidadorPaciente", "CuiPeriodoTratamento", "dbo.PeriodoTratamento");
            DropForeignKey("dbo.TipoTratamento", "TipCuidado", "dbo.MotivoCuidado");
            DropForeignKey("dbo.Paciente", "PacMotivoCuidado", "dbo.MotivoCuidado");
            DropForeignKey("dbo.CuidadorPaciente", "PacId", "dbo.Paciente");
            DropForeignKey("dbo.ContatoEmergencia", "ConPessoa", "dbo.Cuidador");
            DropForeignKey("dbo.ContatoEmergencia", "ConTipo", "dbo.TipoContato");
            DropForeignKey("dbo.ContatoEmergencia", "ConTelefone", "dbo.ConTelefone");
            DropForeignKey("dbo.ContatoEmergencia", "ConEmail", "dbo.ConEmail");
            DropForeignKey("dbo.ContatoEmergencia", "ConCelular", "dbo.ConCelular");
            DropForeignKey("dbo.Avaliacao", "AvaCuidador", "dbo.Cuidador");
            DropForeignKey("dbo.MotivoNaoConclusaoTarefa", "MoAfazer", "dbo.ConclusaoAfazer");
            DropIndex("dbo.PacienteFamiliar", new[] { "PacId" });
            DropIndex("dbo.PacienteFamiliar", new[] { "FamId" });
            DropIndex("dbo.FotoFamiliar", new[] { "FotId" });
            DropIndex("dbo.FotoFamiliar", new[] { "FamId" });
            DropIndex("dbo.TipoCuidadorDtoes", new[] { "CreatedAt" });
            DropIndex("dbo.ViaAdministracaoMedicamento", new[] { "ViaSubtipo" });
            DropIndex("dbo.FormaApresentacaoMedicamento", new[] { "ForSubtipo" });
            DropIndex("dbo.Medicamento", new[] { "MedViaAdministracao" });
            DropIndex("dbo.Medicamento", new[] { "MedApresentacao" });
            DropIndex("dbo.MedicamentoAdministrado", new[] { "MedAdministrado" });
            DropIndex("dbo.MedicamentoAdministrado", new[] { "MedAfazer" });
            DropIndex("dbo.MaterialUtilizado", new[] { "MatUtilizado" });
            DropIndex("dbo.MaterialUtilizado", new[] { "MatAfazer" });
            DropIndex("dbo.MotivoNaoValidacaoConclusaoAfazer", new[] { "MoValidacao" });
            DropIndex("dbo.Parentesco", new[] { "CreatedAt" });
            DropIndex("dbo.Parentesco", new[] { "Id" });
            DropIndex("dbo.VideoFamiliar", new[] { "VidId" });
            DropIndex("dbo.Video", new[] { "VidCuidador" });
            DropIndex("dbo.ValidacaoCuidador", new[] { "CorenEnfermeiro" });
            DropIndex("dbo.Foto", new[] { "FotCuidador" });
            DropIndex("dbo.TipoTratamento", new[] { "TipCuidado" });
            DropIndex("dbo.Paciente", new[] { "PacMotivoCuidado" });
            DropIndex("dbo.CuidadorPaciente", new[] { "CuiPeriodoTratamento" });
            DropIndex("dbo.CuidadorPaciente", new[] { "PacId" });
            DropIndex("dbo.CuidadorPaciente", new[] { "CuiId" });
            DropIndex("dbo.ContatoEmergencia", new[] { "ConEmail" });
            DropIndex("dbo.ContatoEmergencia", new[] { "ConCelular" });
            DropIndex("dbo.ContatoEmergencia", new[] { "ConTelefone" });
            DropIndex("dbo.ContatoEmergencia", new[] { "ConPessoa" });
            DropIndex("dbo.ContatoEmergencia", new[] { "ConTipo" });
            DropIndex("dbo.Cuidador", new[] { "CuiValidacaoCuidador" });
            DropIndex("dbo.Cuidador", new[] { "CuiTipoCuidador" });
            DropIndex("dbo.Avaliacao", new[] { "AvaFamiliar" });
            DropIndex("dbo.Avaliacao", new[] { "AvaCuidador" });
            DropIndex("dbo.Familiar", new[] { "FamParentesco" });
            DropIndex("dbo.ValidacaoAfazer", new[] { "ValAfazer" });
            DropIndex("dbo.ValidacaoAfazer", new[] { "ValFamId" });
            DropIndex("dbo.MotivoNaoConclusaoTarefa", new[] { "MoAfazer" });
            DropIndex("dbo.ConclusaoAfazer", new[] { "ConAfazer" });
            DropTable("dbo.PacienteFamiliar");
            DropTable("dbo.FotoFamiliar");
            DropTable("dbo.TipoCuidadorDtoes");
            DropTable("dbo.SubtipoViaAdministracaoMedicamento");
            DropTable("dbo.ViaAdministracaoMedicamento");
            DropTable("dbo.SubtipoFormaAdministracaoMedicamento");
            DropTable("dbo.FormaApresentacaoMedicamento");
            DropTable("dbo.Medicamento");
            DropTable("dbo.MedicamentoAdministrado");
            DropTable("dbo.Material");
            DropTable("dbo.MaterialUtilizado");
            DropTable("dbo.MotivoNaoValidacaoConclusaoAfazer");
            DropTable("dbo.Parentesco");
            DropTable("dbo.VideoFamiliar");
            DropTable("dbo.Video");
            DropTable("dbo.CorenEnfermeiro");
            DropTable("dbo.ValidacaoCuidador");
            DropTable("dbo.TipoCuidador");
            DropTable("dbo.Foto");
            DropTable("dbo.PeriodoTratamento");
            DropTable("dbo.TipoTratamento");
            DropTable("dbo.MotivoCuidado");
            DropTable("dbo.Paciente");
            DropTable("dbo.CuidadorPaciente");
            DropTable("dbo.TipoContato");
            DropTable("dbo.ConTelefone");
            DropTable("dbo.ConEmail");
            DropTable("dbo.ConCelular");
            DropTable("dbo.ContatoEmergencia");
            DropTable("dbo.Cuidador");
            DropTable("dbo.Avaliacao");
            DropTable("dbo.Familiar");
            DropTable("dbo.ValidacaoAfazer");
            DropTable("dbo.MotivoNaoConclusaoTarefa");
            DropTable("dbo.ConclusaoAfazer");
            DropTable("dbo.Afazer");
        }
    }
}
