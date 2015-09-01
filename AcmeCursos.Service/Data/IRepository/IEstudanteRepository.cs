using AcmeCursos.Service.Business.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCursos.Service.Data.IRepository
{
    interface IEstudanteRepository
    {
        ICollection<Estudante> GetAll();
        ICollection<Estudante> GetAllWithInscricoes();
        Estudante Find(int id);
        Estudante FindWithInscricoes(int id);
        void Delete(Estudante estudante);
        void Add(Estudante estudante);
        void Update(Estudante estudante);
        void SaveChanges();
    }
}
