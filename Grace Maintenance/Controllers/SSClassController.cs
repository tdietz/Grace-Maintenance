using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grace.Models;
using Grace.Core;
using MvcContrib.Sorting;
using MvcContrib.UI.Grid;
using Ninject;
using Ninject.Modules;

namespace Grace.Controllers
{
    public class SSClassController : Controller
    {
        private readonly ISSClassRepository _repository;
        private readonly IGraceConfigService _graceConfigService;
        public readonly IGraceSessionService _graceSessionService;

        public SSClassController(ISSClassRepository repository, IGraceConfigService graceConfigService, IGraceSessionService graceSessionService)
        {
            _repository = repository;
            _graceConfigService = graceConfigService;
            _graceSessionService = graceSessionService;
        }

        //
        // GET: /SSClass/
        public ActionResult Index(GridSortOptions sort)
        {
            var ssClasses = new Grace.ViewModels.SSClassList(_repository.FindAllSSClasses());
            
            if (sort.Column == null)
            {
                if (_graceSessionService.SSClassSort != null)
                {
                    sort = _graceSessionService.SSClassSort;
                }
                else
                {
                    sort = new GridSortOptions();
                    sort.Column = "ShortDescription";
                }
            } 

            if (sort.Column != null)
            {
                ssClasses.SSClassesModel = ssClasses.SSClassesModel.OrderBy(sort.Column, sort.Direction);
            }

            _graceSessionService.SSClassSort = sort;
            ViewData[Config.ViewDataVariables.Sort] = sort;
            return View(ssClasses);
        }

        //
        // GET: /SSClass/Create
        public ActionResult Create()
        {
            Grace.Models.SSClass ssClass = new Grace.Models.SSClass();
            ssClass.ChurchID = _graceConfigService.ChurchID;
            return View(ssClass);
        } 

        //
        // POST: /SSClass/Create
        [HttpPost]
        public ActionResult Create(Grace.Models.SSClass ssClass)
        {
            if (ModelState.IsValid)
                try
                {
                    _repository.Add(ssClass);
                    return RedirectToAction(Config.ActionVariables.Index);
                }
                catch
                {
                    return View(ssClass);
                }
            else
                return View(ssClass);
        }
        
        //
        // GET: /SSClass/Edit/5
        public ActionResult Edit(int id, string exception)
        {
            var ssClass = new Grace.ViewModels.SSClass(_repository.GetSSClass(id));
            if (!string.IsNullOrWhiteSpace(exception)) ssClass.Exception = exception; 

            return View(ssClass);
        }

        //
        // POST: /SSClass/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var ssClass = new Grace.ViewModels.SSClass(_repository.GetSSClass(id));

            try
            {
                UpdateModel(ssClass, collection.ToValueProvider());
                _repository.Update();
                return RedirectToAction(Config.ActionVariables.Index);
            }
            catch
            {
                return View(ssClass);
            }
        }

        //
        // POST: /SSClass/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var ssClass = _repository.GetSSClass(id);
                _repository.Delete(ssClass);
 
                return RedirectToAction(Config.ActionVariables.Index);
            }
            catch(Exception ex)
            {
                return RedirectToAction(Core.Config.ActionVariables.Edit, new { id = id, exception = ex.Message });
            }
        }
    }
}
