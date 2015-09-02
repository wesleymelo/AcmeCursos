using AcmeCursos.Models;
using AcmeCursos.Presentation.CursoServiceRemoto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Presentation.Controllers
{
    public class CursoController : Controller
    {
        public ActionResult Index()
        {
            CursoServiceRemoto.CursoServiceClient cliente = new CursoServiceRemoto.CursoServiceClient();
            List<CursoServiceRemoto.CursoDTO> cursosDTO = cliente.GetAll();
            return View(Mapper.Map<List<Curso>>(cursosDTO));
        }

        public ActionResult Details(int id)
        {
            CursoServiceRemoto.CursoServiceClient cursoCliente = new CursoServiceRemoto.CursoServiceClient();
            ProfessorServiceRemote.ProfessorServiceClient professorCliente = new ProfessorServiceRemote.ProfessorServiceClient();

            Curso curso = Mapper.Map<CursoDTO, Curso>(cursoCliente.Find(id));

            if (curso == null)
            {
                return HttpNotFound();
            }

            curso.Professores = Mapper.Map<List<Professor>>(professorCliente.GetAllByCurso(id));

            return View("Details", curso);
        }

        public ActionResult Create()
        {
            CriaMultiSelectListProfessores();
            return View();
        }

        private void CriaMultiSelectListProfessores()
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
            var professores = Mapper.Map<List<Professor>>(cliente.GetAll());
            ViewBag.ProfessorSelectList = new MultiSelectList(professores, "Id", "NomeCompleto");
        }

        private void CriaMultiSelectListProfessores(int[] professoresId)
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
            var professores = Mapper.Map<List<Professor>>(cliente.GetAll());
            ViewBag.ProfessorSelectList = new MultiSelectList(professores, "Id", "NomeCompleto", professoresId.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Curso curso)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CursoServiceRemoto.CursoServiceClient clienteCurso = new CursoServiceRemoto.CursoServiceClient();
                    ProfessorServiceRemote.ProfessorServiceClient clienteProfessor = new ProfessorServiceRemote.ProfessorServiceClient();
                    List<Professor> professores = new List<Professor>();
                    curso.Professores = new List<Professor>();

                    Professor professor;
                    for (int i = 0; i < curso.ProfessoresId.Length; i++)
                    {
                        professor = Mapper.Map<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO, Professor>(clienteProfessor.Find(curso.ProfessoresId[i]));

                        professores.Add(professor);
                    }

                    CursoDTO cursoDTO = Mapper.Map<Curso, CursoDTO>(curso);

                    cursoDTO.Professores = Mapper.Map<List<ProfessorDTO>>(professores);

                    bool retorno = clienteCurso.Add(cursoDTO);

                    TempData["Mensagem"] = "Curso cadastrado com sucesso";
                    TempData["Sucesso"] = retorno;

                    return RedirectToAction("Index");

                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                    CriaMultiSelectListProfessores(curso.ProfessoresId);
                    return View("Create", curso);
                }

            }

            return View("Create", curso);
        }

        public ActionResult Edit(int id)
        {
            CursoServiceRemoto.CursoServiceClient cliente = new CursoServiceRemoto.CursoServiceClient();
            ProfessorServiceRemote.ProfessorServiceClient professorWS = new ProfessorServiceRemote.ProfessorServiceClient();

            Curso curso = Mapper.Map<CursoDTO, Curso>(cliente.Find(id));

            if (curso == null)
            {
                return HttpNotFound();
            }

            curso.Professores = Mapper.Map<List<Professor>>(professorWS.GetAllByCurso(curso.Id));
            curso.ProfessoresId = new int[curso.Professores.Count];

            for (int i = 0; i < curso.Professores.Count; i++)
            {
                curso.ProfessoresId[i] = curso.Professores.ElementAt(i).Id;
            }

            CriaMultiSelectListProfessores(curso.ProfessoresId);

            return View(curso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Curso curso)
        {
            if (ModelState.IsValid)
            {
                CursoServiceRemoto.CursoServiceClient cliente = new CursoServiceRemoto.CursoServiceClient();
                ProfessorServiceRemote.ProfessorServiceClient clienteProfessor = new ProfessorServiceRemote.ProfessorServiceClient();

                List<Professor> professores = new List<Professor>();
                curso.Professores = new List<Professor>();

                Professor professor;
                for (int i = 0; i < curso.ProfessoresId.Length; i++)
                {
                    professor = Mapper.Map<AcmeCursos.Presentation.ProfessorServiceRemote.ProfessorDTO, Professor>(clienteProfessor.Find(curso.ProfessoresId[i]));

                    professores.Add(professor);
                }

                CursoDTO cursoDTO = Mapper.Map<Curso, CursoDTO>(curso);

                cursoDTO.Professores = Mapper.Map<List<ProfessorDTO>>(professores);

                bool retorno = cliente.Update(cursoDTO);

                TempData["Sucesso"] = true;
                TempData["Mensagem"] = retorno ? "Curso atualizado com sucesso" : "Curso não pode ser atualizado";

                return RedirectToAction("Index");
            }

            return View("Edit", curso);
        }

        public ActionResult Delete(int id)
        {
            CursoServiceRemoto.CursoServiceClient cliente = new CursoServiceRemoto.CursoServiceClient();

            Curso curso = Mapper.Map<CursoDTO, Curso>(cliente.Find(id));

            if (curso == null)
            {
                return HttpNotFound();
            }

            return View(curso);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Curso curso)
        {
            CursoServiceRemoto.CursoServiceClient cursoWS = new CursoServiceRemoto.CursoServiceClient();
            curso = Mapper.Map<CursoDTO, Curso>(cursoWS.Find(curso.Id));
            CursoServiceRemoto.CursoServiceClient cliente = new CursoServiceRemoto.CursoServiceClient();

            bool retorno = cliente.Delete(Mapper.Map<Curso, CursoDTO>(curso));

            TempData["Mensagem"] = retorno ? "Curso excluído com sucesso" : "Curso não pode ser excluído";

            return RedirectToAction("Index");
        }
    }
}
