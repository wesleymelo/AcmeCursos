using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Business.Interfaces;
using AcmeCursos.Service.Data.DAL;
using AcmeCursos.Service.Data.IRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCursos.Service.Data.Repository
{
    public class CursoRepository : ICursoRepository
    {
        public ICollection<Curso> GetAll()
        {
            using (AppDBContext Context = new AppDBContext())
            {
                return Context.Cursos.ToList<Curso>();
            }
        }

        public Curso Find(int id)
        {
            using (AppDBContext Context = new AppDBContext())
            {
                return Context.Cursos.SingleOrDefault(c => c.Id == id);
            }
        }

        public bool Delete(Curso curso)
        {
            bool retorno = true;
            try
            {
                using (AppDBContext Context = new AppDBContext())
                {
                    Curso cursoTemp = Context.Cursos.FirstOrDefault(c => c.Id == curso.Id);
                    Context.Cursos.Remove(cursoTemp);
                    Context.SaveChanges();
                }
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }

        public void Add(Curso curso)
        {
            if (curso is IValidator)
            {
                ((IValidator)curso).Validate();
            }
            using (AppDBContext Context = new AppDBContext())
            {
                List<Professor> professores = new List<Professor>();

                foreach(Professor p in curso.Professores){
                    professores.Add(Context.Professores.FirstOrDefault(x => x.Id == p.Id));
                }

                curso.Professores = professores;

                Context.Cursos.Add(curso);
                Context.SaveChanges();
            }
        }

        public void Update(Curso curso)
        {
            using (AppDBContext Context = new AppDBContext())
            {
                List<Professor> professores = new List<Professor>();
                
                foreach (Professor p in curso.Professores)
                {
                    professores.Add(Context.Professores.FirstOrDefault(x => x.Id == p.Id));
                }

                curso = Context.Cursos.Include(x => x.Professores).FirstOrDefault(c => c.Id == curso.Id);
                curso.Professores = professores;
                Context.SaveChanges();
            }

        }

        public ICollection<Curso> GetAllWithProfessores()
        {
            using (AppDBContext Context = new AppDBContext())
            {
                return Context.Cursos.Include(typeof(Professor).Name).ToList<Curso>();
            }
        }

        public Curso FindWithProfessores(int id)
        {
            Curso curso = new Curso();
            using (AppDBContext Context = new AppDBContext())
            {
                curso = Context.Cursos.Include(typeof(Professor).Name).SingleOrDefault(c => c.Id == id);
            }

            return curso;
        }


        public ICollection<Curso> GetAllByProfessor(int idProfessor)
        {
            ICollection<Curso> cursos = new List<Curso>();

            using (AppDBContext Context = new AppDBContext())
            {
                Professor professor = Context.Professores.Include(c => c.Cursos).SingleOrDefault(c => c.Id == idProfessor);

                cursos = professor.Cursos;
            }

            foreach (Curso c in cursos)
            {
                c.Professores = new HashSet<Professor>();
            }

            return cursos;
        }
    }
}
