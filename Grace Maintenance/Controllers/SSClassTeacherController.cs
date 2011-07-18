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
    public class SSClassTeacherController : Controller
    {
        private readonly ISSClassTeacherRepository _repository;
        private readonly IMemberRepository _memberRepository;
        private readonly IGraceGlobalCacheService _graceGlobalCacheService;

        public SSClassTeacherController(ISSClassTeacherRepository repository, IMemberRepository memberRepository, IGraceGlobalCacheService graceGlobalCacheService)
        {
            _repository = repository;
            _memberRepository = memberRepository;
            _graceGlobalCacheService = graceGlobalCacheService;
        }

        //
        // GET: /SSClassTeacher/Create
        public ActionResult Create(int id)
        {
            Grace.ViewModels.SSClassTeacher ssClassTeacher = new Grace.ViewModels.SSClassTeacher();
            ssClassTeacher.Members = _memberRepository.FindAllMembers().ToList().OrderBy(a => a.FullNameLastFirst);
            ssClassTeacher.SSClassTeacherTypes = _graceGlobalCacheService.SSClassTeacherTypes;
            ssClassTeacher.SSClassTeacherModel.SSClassID = id;
            
            return View(ssClassTeacher);
        } 

        //
        // POST: /SSClassTeacher/Create
        [HttpPost]
        public ActionResult Create(Grace.ViewModels.SSClassTeacher ssClassTeacher)
        {
            if (TryValidateModel(ssClassTeacher.SSClassTeacherModel))
                try
                {
                    _repository.Add(ssClassTeacher.SSClassTeacherModel);
                    return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.SSClass, new { id = ssClassTeacher.SSClassTeacherModel.SSClassID });
                }
                catch
                {
                    return View(ssClassTeacher);
                }
            else
                return View(ssClassTeacher);
        }

        //
        // GET: /SSClassTeacher/Delete/5
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var ssClassTeacher = _repository.GetSSClassTeacher(id);
                int ssClassID = ssClassTeacher.SSClassID;
                _repository.Delete(ssClassTeacher);

                return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.SSClass, new { id = ssClassID });
            }
            catch
            {
                return View();
            }
        }
    }
}
