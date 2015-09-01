using AcmeCursos.Models;
using AcmeCursos.Presentation.ProfessorServiceRemote;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace AcmeCursos.Presentation.Controllers
{
    public class ProfessorController : Controller
    {
        public ActionResult Index()
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
            List<ProfessorServiceRemote.ProfessorDTO> professores = cliente.GetAll();
            return View(Mapper.Map<List<Professor>>(professores));
        }

        public ActionResult Details(int id)
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
            CursoServiceRemoto.CursoServiceClient clienteCurso = new CursoServiceRemoto.CursoServiceClient();

            Professor professor = Mapper.Map<ProfessorDTO, Professor>(cliente.Find(id));

            if (professor == null)
            {
                return HttpNotFound();
            }

            professor.Cursos = Mapper.Map<List<Curso>>(clienteCurso.GetAllByProfessor(id));

            return View("Details", professor);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
                bool retorno = cliente.Add(Mapper.Map<Professor, ProfessorDTO>(professor));

                TempData["Mensagem"] = "Professor cadastrado com sucesso";

                return RedirectToAction("Index");
            }

            return View("Create", professor);
        }

        public ActionResult Edit(int id)
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();

            Professor professor = Mapper.Map<ProfessorDTO, Professor>(cliente.Find(id));

            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Professor professor)
        {
            if (ModelState.IsValid)
            {
                ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
                bool retorno = cliente.Update(Mapper.Map<Professor, ProfessorDTO>(professor));
                TempData["Mensagem"] = "Professor atualizado com sucesso";

                return RedirectToAction("Index");
            }

            return View("Edit", professor);
        }

        public ActionResult Delete(int id)
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();

            Professor professor = Mapper.Map<ProfessorDTO, Professor>(cliente.Find(id));

            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Professor professor)
        {
            ProfessorServiceRemote.ProfessorServiceClient cliente = new ProfessorServiceRemote.ProfessorServiceClient();
            professor = Mapper.Map<ProfessorDTO, Professor>(cliente.Find(professor.Id));
            bool retorno = cliente.Delete(Mapper.Map<Professor, ProfessorDTO>(professor));
            TempData["Mensagem"] = "Professor excluído com sucesso";

            return RedirectToAction("Index");
        }

    }
}
