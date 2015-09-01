using AcmeCursos.Models;
using AcmeCursos.Presentation.InscricaoServiceRemoto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Presentation.Controllers
{
    public class EstudanteController : Controller
    {

        // GET: Estudante
        public ActionResult Index()
        {
            EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();
            List<EstudanteServiceRemoto.EstudanteDTO> estudantesDTO = cliente.GetAllEstudantes();
            return View(Mapper.Map<List<Estudante>>(estudantesDTO));
        }

        // GET: Estudante/Details/5
        public ActionResult Details(int id)
        {
            EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();
            InscricaoServiceRemoto.InscricaoServiceClient inscricoesWS = new InscricaoServiceRemoto.InscricaoServiceClient();
            CursoServiceRemoto.CursoServiceClient cursoWS = new CursoServiceRemoto.CursoServiceClient();

            Estudante estudante = Mapper.Map<EstudanteServiceRemoto.EstudanteDTO, Estudante>(cliente.FindEstudante(id));

            if (estudante == null)
            {
                return HttpNotFound();
            }

            List<InscricaoServiceRemoto.InscricaoDTO> inscricoes = inscricoesWS.GetAllByEstudante(id);
            estudante.Inscricoes = Mapper.Map<List<Inscricao>>(inscricoes);

            foreach(Inscricao i in estudante.Inscricoes){
                i.Curso = Mapper.Map<CursoServiceRemoto.CursoDTO, Curso>(cursoWS.Find(i.CursoId));
            }
            


            return View("Details", estudante);
        }

        // GET: Estudante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();
                estudante.DataMatricula = DateTime.Now;
                cliente.AddEstudante(Mapper.Map<Estudante, EstudanteServiceRemoto.EstudanteDTO>(estudante));

                TempData["Mensagem"] = "Estudante cadastrado com sucesso!";
                TempData["Sucesso"] = true;

                return RedirectToAction("Index");
            }

            return View("Create", estudante);
        }

        // GET: Estudante/Edit/5
        public ActionResult Edit(int id)
        {
            EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();

            Estudante estudante = Mapper.Map<EstudanteServiceRemoto.EstudanteDTO, Estudante>(cliente.FindEstudante(id));

            if (estudante == null)
            {
                return HttpNotFound();
            }

            return View(estudante);
        }

        // POST: Estudante/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();

                cliente.UpdateEstudante(Mapper.Map<Estudante, EstudanteServiceRemoto.EstudanteDTO>(estudante));

                TempData["Mensagem"] = "Estudante atualizado com sucesso!";
                TempData["Sucesso"] = true;

                return RedirectToAction("Index");
            }

            return View("Edit", estudante);
        }

        // GET: Estudante/Delete/5
        public ActionResult Delete(int id)
        {
            EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();

            Estudante estudante = Mapper.Map<EstudanteServiceRemoto.EstudanteDTO, Estudante>(cliente.FindEstudante(id));

            if (estudante == null)
            {
                return HttpNotFound();
            }

            return View("Delete", estudante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Estudante estudante)
        {
            EstudanteServiceRemoto.EstudanteServiceClient cliente = new EstudanteServiceRemoto.EstudanteServiceClient();
            estudante = Mapper.Map<EstudanteServiceRemoto.EstudanteDTO, Estudante>(cliente.FindEstudante(estudante.Id));
            cliente.DeleteEstudante(Mapper.Map<Estudante, EstudanteServiceRemoto.EstudanteDTO>(estudante));
            TempData["Mensagem"] = "Estudante excluído com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
