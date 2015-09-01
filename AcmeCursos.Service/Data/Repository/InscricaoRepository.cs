using AcmeCursos.Service.Business.Object;
using AcmeCursos.Service.Business.Interfaces;
using AcmeCursos.Service.Data.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeCursos.Service.Data.IRepository;

namespace AcmeCursos.Service.Data.Repository
{
    public class InscricaoRepository : IInscricaoRepository
    {
        public void Add(Inscricao inscricao)
        {
            if (inscricao is IValidator)
            {
                ((IValidator)inscricao).Validate();
            }
            using (AppDBContext Context = new AppDBContext())
            {
                Context.Inscricoes.Add(inscricao);
                Context.SaveChanges();
            }
        }


        public ICollection<Inscricao> GetAllByEstudante(int idEstudante)
        {
            ICollection<Inscricao> inscricoes = new List<Inscricao>();

            using (AppDBContext Context = new AppDBContext())
            {
                Estudante estudante = Context.Estudantes.Include(e => e.Inscricoes).SingleOrDefault(c => c.Id == idEstudante);

                inscricoes = estudante.Inscricoes;
            }

            foreach (Inscricao i in inscricoes)
            {
                i.Estudante = new Estudante(); ;
            }

            return inscricoes;
        }
    }
}
