using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Business.Interfaces;
using AcmeCursos.Service.Data.DAL;
using AcmeCursos.Service.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AcmeCursos.Service.Data.Repository
{
    public class EstudanteRepository : IEstudanteRepository
    {
        private AppDBContext Context { get; set; }

        public EstudanteRepository() : this(new AppDBContext()) { }

        public EstudanteRepository(AppDBContext Context)
        {
            this.Context = Context;
        }

        public ICollection<Estudante> GetAll()
        {
            return Context.Estudantes.ToList<Estudante>();
        }

        public ICollection<Estudante> GetAllWithInscricoes()
        {
            return Context.Estudantes.Include(typeof(Inscricao).Name).ToList();
        }

        public Estudante Find(int id)
        {
            return Context.Estudantes.Find(id);
        }

        public Estudante FindWithInscricoes(int id)
        {
            return Context.Estudantes.Include(typeof(Inscricao).Name).SingleOrDefault(a => a.Id == id);
        }

        public void Delete(Estudante estudante)
        {
            if (estudante == null)
            {
                throw new ArgumentNullException("estudante");
            }

            Estudante estudanteTemporario = Context.Estudantes.FirstOrDefault(c => c.Id == estudante.Id);

            Context.Estudantes.Remove(estudanteTemporario);
            SaveChanges();
        }

        public void Add(Estudante estudante)
        {
            if (estudante == null)
            {
                throw new ArgumentNullException("estudante");
            }
            if (estudante is IValidator)
            {
                ((IValidator)estudante).Validate();
            }

            Context.Estudantes.Add(estudante);
            SaveChanges();
        }

        public void Update(Estudante estudante)
        {
            if (estudante == null)
            {
                throw new ArgumentNullException("estudante");
            }
            if (estudante is IValidator)
            {
                ((IValidator)estudante).Validate();
            }

            Estudante estudanteTemporario = Context.Estudantes.FirstOrDefault(c => c.Id == estudante.Id);

            if (estudanteTemporario != null)
            {
                estudanteTemporario.Nome = estudante.Nome;
                estudanteTemporario.SobreNome = estudante.SobreNome;
                SaveChanges();
            }

        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Context != null)
                {
                    Context.Dispose();
                    Context = null;
                }
            }
        }

        #endregion
    }
}
