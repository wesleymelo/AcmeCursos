namespace AcmeCursos.Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursos",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Descricao = c.String(),
                    DataLimiteInscricao = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Professores",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Sobrenome = c.String(),
                    Titulacao = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Estudante",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    SobreNome = c.String(),
                    DataMatricula = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Inscricoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    CursoId = c.Int(nullable: false),
                    EstudanteId = c.Int(nullable: false),
                    DataInscricao = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudante", t => t.EstudanteId, cascadeDelete: true)
                .Index(t => t.CursoId)
                .Index(t => t.EstudanteId);

            CreateTable(
                "dbo.ProfessorCurso",
                c => new
                {
                    Professor_Id = c.Int(nullable: false),
                    Curso_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Professor_Id, t.Curso_Id })
                .ForeignKey("dbo.Professores", t => t.Professor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cursos", t => t.Curso_Id, cascadeDelete: true)
                .Index(t => t.Professor_Id)
                .Index(t => t.Curso_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Inscricoes", "EstudanteId", "dbo.Estudante");
            DropForeignKey("dbo.Inscricoes", "CursoId", "dbo.Cursos");
            DropForeignKey("dbo.ProfessorCurso", "Curso_Id", "dbo.Cursos");
            DropForeignKey("dbo.ProfessorCurso", "Professor_Id", "dbo.Professores");
            DropIndex("dbo.ProfessorCurso", new[] { "Curso_Id" });
            DropIndex("dbo.ProfessorCurso", new[] { "Professor_Id" });
            DropIndex("dbo.Inscricoes", new[] { "EstudanteId" });
            DropIndex("dbo.Inscricoes", new[] { "CursoId" });
            DropTable("dbo.ProfessorCurso");
            DropTable("dbo.Inscricoes");
            DropTable("dbo.Estudante");
            DropTable("dbo.Professores");
            DropTable("dbo.Cursos");
        }
    }
}
