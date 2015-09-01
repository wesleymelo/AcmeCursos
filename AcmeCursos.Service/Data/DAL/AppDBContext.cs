using AcmeCursos.Service.Business.Object;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AcmeCursos.Service.Data.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("AcmeCursosConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBContext, Configuration>());
        }

        public virtual DbSet<Estudante> Estudantes { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Inscricao> Inscricoes { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}