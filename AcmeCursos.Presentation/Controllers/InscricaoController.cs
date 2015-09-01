using AcmeCursos.Models;
using AcmeCursos.Presentation.InscricaoServiceRemoto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Presentation.Controllers
{
    public class InscricaoController : Controller
    {
        // GET: Inscricao
        public ActionResult CadastrarEstudante()
        {
            EstudanteServiceRemoto.EstudanteServiceClient clienteWSEstudante = new EstudanteServiceRemoto.EstudanteServiceClient();
            CursoServiceRemoto.CursoServiceClient clienteWSCurso = new CursoServiceRemoto.CursoServiceClient();

            var estudantes = clienteWSEstudante.GetAllEstudantes();
            var cursos = clienteWSCurso.GetAll();

            List<SelectListItem> selectEstudantes = estudantes.Select(e => new SelectListItem()
            {
                Text = string.Format("{0} {1} - Cod. {2}", e.Nome, e.SobreNome, e.Id),
                Value = e.Id.ToString()

            }).ToList();

            List<SelectListItem> selectCursos = cursos.Select(c => new SelectListItem()
            {
                Text = c.Nome,
                Value = c.Id.ToString()
            }).ToList();

            ViewBag.CursoId = selectCursos;
            ViewBag.EstudanteId = selectEstudantes;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarEstudante(Inscricao inscricao)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InscricaoServiceRemoto.InscricaoServiceClient inscricaoWS = new InscricaoServiceRemoto.InscricaoServiceClient();
                    CursoServiceRemoto.CursoServiceClient cursoWS = new CursoServiceRemoto.CursoServiceClient();
                    EstudanteServiceRemoto.EstudanteServiceClient estudanteWS = new EstudanteServiceRemoto.EstudanteServiceClient();
                    inscricao.Curso = Mapper.Map<CursoServiceRemoto.CursoDTO, Curso>(cursoWS.Find(inscricao.CursoId));
                    inscricao.Estudante = Mapper.Map<EstudanteServiceRemoto.EstudanteDTO, Estudante>(estudanteWS.FindEstudante(inscricao.EstudanteId));

                    InscricaoDTO inscricaoDTO = new InscricaoDTO();
                    //inscricaoDTO.Curso = Mapper.Map<Curso, CursoDTO>(inscricao.Curso);
                    //inscricaoDTO.Estudante = Mapper.Map<Estudante, EstudanteDTO>(inscricao.Estudante);
                    //inscricaoDTO.Id = inscricao.Id;
                    inscricaoDTO.EstudanteId = inscricao.EstudanteId;
                    inscricaoDTO.CursoId = inscricao.CursoId;
                    inscricaoDTO.DataInscricao = DateTime.Now;

                    bool retorno = inscricaoWS.Add(inscricaoDTO);

                    TempData["Mensagem"] = "Inscrição realizada com sucesso";
                    TempData["Sucesso"] = retorno;

                    return RedirectToAction("CadastrarEstudante");
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                    return RedirectToAction("CadastrarEstudante");
                }
            }

            return View(inscricao);
        }
    }
}
