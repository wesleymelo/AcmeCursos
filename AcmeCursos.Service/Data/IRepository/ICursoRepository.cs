using AcmeCursos.Service.Business.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCursos.Service.Data.IRepository
{
    public interface ICursoRepository
    {
        ICollection<Curso> GetAll();
        ICollection<Curso> GetAllWithProfessores();
        ICollection<Curso> GetAllByProfessor(int idProfessor);
        Curso Find(int id);
        Curso FindWithProfessores(int id);
        bool Delete(Curso estudante);
        void Add(Curso estudante);
        void Update(Curso estudante);
    }
}
