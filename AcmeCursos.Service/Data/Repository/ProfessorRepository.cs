using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Business.Interfaces;
using AcmeCursos.Service.Data.DAL;
using AcmeCursos.Service.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCursos.Service.Data.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        public ICollection<Professor> GetAll()
        {
            using (AppDBContext Context = new AppDBContext())
            {
                return Context.Professores.ToList<Professor>();
            }
        }

        public Professor Find(int id)
        {
            using (AppDBContext Context = new AppDBContext())
            {
                return Context.Professores.SingleOrDefault(c => c.Id == id);
            }
        }

        public bool Delete(Professor professor)
        {
            bool retorno = true;
            try
            {
                using (AppDBContext Context = new AppDBContext())
                {
                    Professor professorTemp = Context.Professores.FirstOrDefault(c => c.Id == professor.Id);
                    Context.Professores.Remove(professorTemp);
                    Context.SaveChanges();
                }
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public void Add(Professor professor)
        {
            if (professor is IValidator)
            {
                ((IValidator)professor).Validate();
            }
            using (AppDBContext Context = new AppDBContext())
            {
                Context.Professores.Add(professor);
                Context.SaveChanges();
            }
        }

        public void Update(Professor professor)
        {
            if (professor is IValidator)
            {
                ((IValidator)professor).Validate();
            }
            using (AppDBContext Context = new AppDBContext())
            {
                Context.Entry(professor).State = EntityState.Modified;
                Context.SaveChanges();
            }
        }

        public ICollection<Professor> GetAllWithCursos()
        {
            using (AppDBContext Context = new AppDBContext())
            {
                return Context.Professores.Include(typeof(Curso).Name).ToList<Professor>();
            }
        }

        public Professor FindWithCursos(int id)
        {

            Professor professor = new Professor();

            using (AppDBContext Context = new AppDBContext())
            {
                professor = Context.Professores.Include(typeof(Curso).Name).FirstOrDefault(c => c.Id == id);
            }

            return professor;
        }

        public ICollection<Professor> GetAllByCurso(int idCurso)
        {
            ICollection<Professor> professores = new List<Professor>();

            using (AppDBContext Context = new AppDBContext())
            {
                Curso curso = Context.Cursos.Include(c => c.Professores).SingleOrDefault(c => c.Id == idCurso);
                
                professores = curso.Professores;
            }

            foreach (Professor p in professores)
            {
                p.Cursos = new HashSet<Curso>();
            }

            return professores;

        }
    }
}
