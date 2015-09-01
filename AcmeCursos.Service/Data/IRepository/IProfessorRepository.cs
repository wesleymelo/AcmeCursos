using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcmeCursos.Service.Business.Object;

namespace AcmeCursos.Service.Data.IRepository
{
    public interface IProfessorRepository
    {
        ICollection<Professor> GetAll();
        ICollection<Professor> GetAllWithCursos();
        ICollection<Professor> GetAllByCurso(int idCurso);
        Professor Find(int id);
        Professor FindWithCursos(int id);
        bool Delete(Professor professor);
        void Add(Professor professor);
        void Update(Professor professor);
    }
}
