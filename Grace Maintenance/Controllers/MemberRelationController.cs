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
    public class MemberRelationController : Controller
    {
        private readonly IMemberRelationRepository _repository;
        private readonly IMemberRepository _memberRepository;
        private readonly IGraceGlobalCacheService _graceGlobalCacheService;

        public MemberRelationController(IMemberRelationRepository repository, IMemberRepository memberRepository, IGraceGlobalCacheService graceGlobalCacheService)
        {
            _repository = repository;
            _memberRepository = memberRepository;
            _graceGlobalCacheService = graceGlobalCacheService;
        }

        //
        // GET: /MemberRelation/Create
        public ActionResult Create(int id, int returnId)
        {
            Grace.ViewModels.MemberRelation memberRelation = new Grace.ViewModels.MemberRelation();
            memberRelation.Members = _memberRepository.FindAllMembers().ToList().OrderBy(a => a.FullNameLastFirst);
            memberRelation.MemberRelationTypes = _graceGlobalCacheService.MemberRelationTypes;
            memberRelation.MemberRelationModel.HeadMemberID = id;
            memberRelation.ReturnId = returnId;
            
            return View(memberRelation);
        } 

        //
        // POST: /MemberRelation/Create
        [HttpPost]
        public ActionResult Create(Grace.ViewModels.MemberRelation memberRelation)
        {
            if (TryValidateModel(memberRelation.MemberRelationModel))
                try
                {
                    _repository.Add(memberRelation.MemberRelationModel);
                    return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.Member, new {id=memberRelation.MemberRelationModel.HeadMemberID});
                }
                catch
                {
                    return View(memberRelation);
                }
            else
                return View(memberRelation);
        }

        //
        // GET: /MemberRelation/Edit/5
        public ActionResult Edit(int id)
        {
            var memberRelation = new Grace.ViewModels.MemberRelation(_repository.GetMemberRelation(id));

            return View(memberRelation);
        }

        //
        // POST: /MemberRelation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var memberRelation = new Grace.ViewModels.MemberRelation(_repository.GetMemberRelation(id));

            try
            {
                UpdateModel(memberRelation, collection.ToValueProvider());
                _repository.Update();
                return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.Member, new { id = memberRelation.MemberRelationModel.HeadMemberID });
            }
            catch
            {
                return View(memberRelation);
            }
        }

        //
        // POST: /MemberRelation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var memberRelation = _repository.GetMemberRelation(id);
                int memberID = memberRelation.HeadMemberID;
                _repository.Delete(memberRelation);

                return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.Member, new { id = memberID });
            }
            catch
            {
                return View();
            }
        }
    }
}
