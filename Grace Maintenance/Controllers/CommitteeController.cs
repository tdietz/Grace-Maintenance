using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grace.Models;
using Grace.Core;
using MvcContrib.Sorting;
using MvcContrib.UI.Grid;

namespace Grace.Controllers
{
    public class CommitteeController : Controller
    {
        private readonly ICommitteeRepository _repository;
        private readonly IGraceConfigService _graceConfigService;
        private readonly IGraceSessionService _graceSessionService;

        public CommitteeController(ICommitteeRepository repository, IGraceConfigService graceConfigService, IGraceSessionService graceSessionService)
        {
            _repository = repository;
            _graceConfigService = graceConfigService;
            _graceSessionService = graceSessionService;
        }

        //
        // GET: /Committee/
        public ActionResult Index(GridSortOptions sort)
        {
            var committeees = new Grace.ViewModels.CommitteeList(_repository.FindAllCommittees());
            
            if (sort.Column == null)
            {
                if (_graceSessionService.CommitteeSort != null)
                {
                    sort = _graceSessionService.CommitteeSort;
                }
                else
                {
                    sort = new GridSortOptions();
                    sort.Column = "Name";
                }
            } 

            if (sort.Column != null)
            {
                committeees.CommitteesModel = committeees.CommitteesModel.OrderBy(sort.Column, sort.Direction);
            }

            _graceSessionService.CommitteeSort = sort;
            ViewData[Config.ViewDataVariables.Sort] = sort;
            return View(committeees);
        }

        //
        // GET: /Committee/Create
        public ActionResult Create()
        {
            Grace.Models.Committee committee = new Grace.Models.Committee();
            committee.ChurchID = _graceConfigService.ChurchID;
            return View(committee);
        } 

        //
        // POST: /Committee/Create
        [HttpPost]
        public ActionResult Create(Grace.Models.Committee committee)
        {
            if (ModelState.IsValid)
                try
                {
                    _repository.Add(committee);
                    return RedirectToAction(Config.ActionVariables.Index);
                }
                catch
                {
                    return View(committee);
                }
            else
                return View(committee);
        }
        
        //
        // GET: /Committee/Edit/5
        public ActionResult Edit(int id, string exception)
        {
            var committee = new Grace.ViewModels.Committee(_repository.GetCommittee(id));
            if (!string.IsNullOrWhiteSpace(exception)) committee.Exception = exception; 

            return View(committee);
        }

        //
        // POST: /Committee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var committee = new Grace.ViewModels.Committee(_repository.GetCommittee(id));

            try
            {
                UpdateModel(committee, collection.ToValueProvider());
                _repository.Update();
                return RedirectToAction(Config.ActionVariables.Index);
            }
            catch
            {
                return View(committee);
            }
        }

        //
        // POST: /Committee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var committee = _repository.GetCommittee(id);
                _repository.Delete(committee);
 
                return RedirectToAction(Config.ActionVariables.Index);
            }
            catch(Exception ex)
            {
                return RedirectToAction(Core.Config.ActionVariables.Edit, new { id = id, exception = ex.Message });
            }
        }
    }
}
