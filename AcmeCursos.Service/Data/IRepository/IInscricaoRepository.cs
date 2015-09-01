using AcmeCursos.Service.Business.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCursos.Service.Data.IRepository
{
    interface IInscricaoRepository
    {
        void Add(Inscricao inscricao);
        ICollection<Inscricao> GetAllByEstudante(int idEstudante);
    }
}
