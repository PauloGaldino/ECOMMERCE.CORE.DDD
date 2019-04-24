using Application.Interfaces.IAppPessoas;
using AutoMapper;
using Domain.Entities.Pessoas;
using ECOMMERCE.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECOMMERCE.UI.Controllers.Pessoa
{
    public class PessoaTipoViewModelController : Controller
    {
        private readonly IAppPessoaTipo _pessoaTipoApp;

        public PessoaTipoViewModelController(IAppPessoaTipo pessoaTipoApp)
        {
            _pessoaTipoApp = pessoaTipoApp;
        }

        // GET: PessoasTipos
        public ActionResult Index()
        {
            var pessoaTipoViewModel = Mapper.Map<IEnumerable<PessoaTipo>, IEnumerable<PessoaTipoViewModel>>(_pessoaTipoApp.Listar());
            return View(pessoaTipoViewModel);
        }

        // GET: PessoasTipos/Details/5
        public ActionResult Details(int id)
        {
            var pessoaTipo = _pessoaTipoApp.ObterPorId(id);
            var pessoaTipoViewModel = Mapper.Map<PessoaTipo, PessoaTipoViewModel>(pessoaTipo);

            return View(pessoaTipoViewModel);
        }

        // GET: PessoasTipos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PessoasTipos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaTipoViewModel pessoaTipo)
        {
            if (ModelState.IsValid)
            {
                var pessoaTipoDomain = Mapper.Map<PessoaTipoViewModel, PessoaTipo>(pessoaTipo);
                _pessoaTipoApp.Adicionar(pessoaTipoDomain);

                return RedirectToAction("Index");
            }

            return View(pessoaTipo);
        }

        // GET: PessoasTipos/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoaTipo = _pessoaTipoApp.ObterPorId(id);
            var pessoaTipoViewModel = Mapper.Map<PessoaTipo, PessoaTipoViewModel>(pessoaTipo);

            return View(pessoaTipoViewModel);
        }

        // POST: PessoasTipos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaTipoViewModel pessoaTipo)
        {
            if (ModelState.IsValid)
            {
                var pessoaTipoDomain = Mapper.Map<PessoaTipoViewModel, PessoaTipo>(pessoaTipo);
                _pessoaTipoApp.Atualizar(pessoaTipoDomain);

                return RedirectToAction("Index");
            }

            return View(pessoaTipo);
        }

        // GET: PessoasTipos/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoaTipo = _pessoaTipoApp.ObterPorId(id);
            var pessoaTipoViewModel = Mapper.Map<PessoaTipo, PessoaTipoViewModel>(pessoaTipo);

            return View(pessoaTipoViewModel);
        }

        // POST: PessoasTipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoaTipo = _pessoaTipoApp.ObterPorId(id);
            _pessoaTipoApp.Excluir(pessoaTipo);

            return RedirectToAction("Index");
        }
    }
}