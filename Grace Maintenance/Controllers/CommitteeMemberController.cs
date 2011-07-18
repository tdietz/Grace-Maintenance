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
    public class CommitteeMemberController : Controller
    {
        private readonly ICommitteeMemberRepository _repository;
        private readonly IMemberRepository _memberRepository;
        private readonly IGraceGlobalCacheService _graceGlobalCacheService;

        public CommitteeMemberController(ICommitteeMemberRepository repository, IMemberRepository memberRepository, IGraceGlobalCacheService graceGlobalCacheService)
        {
            _repository = repository;
            _memberRepository = memberRepository;
            _graceGlobalCacheService = graceGlobalCacheService;
        }

        //
        // GET: /CommitteeMember/Create
        public ActionResult Create(int id)
        {
            Grace.ViewModels.CommitteeMember committeeMember = new Grace.ViewModels.CommitteeMember();
            committeeMember.Members = _memberRepository.FindAllMembers().ToList().OrderBy(a => a.FullNameLastFirst);
            committeeMember.CommitteeRoles = _graceGlobalCacheService.CommitteeRoles;
            committeeMember.CommitteeMemberModel.CommitteeID = id;
            
            return View(committeeMember);
        } 

        //
        // POST: /CommitteeMember/Create
        [HttpPost]
        public ActionResult Create(Grace.ViewModels.CommitteeMember committeeMember)
        {
            if (TryValidateModel(committeeMember.CommitteeMemberModel))
                try
                {
                    _repository.Add(committeeMember.CommitteeMemberModel);
                    return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.Committee, new { id = committeeMember.CommitteeMemberModel.CommitteeID });
                }
                catch
                {
                    return View(committeeMember);
                }
            else
                return View(committeeMember);
        }

        //
        // GET: /CommitteeMember/Delete/5
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var committeeMember = _repository.GetCommitteeMember(id);
                int committeeID = committeeMember.CommitteeID;
                _repository.Delete(committeeMember);

                return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.Committee, new { id = committeeID });
            }
            catch
            {
                return View();
            }
        }
    }
}
