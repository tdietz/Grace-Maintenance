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
    public class SSClassMemberController : Controller
    {
        private readonly ISSClassMemberRepository _repository;
        private readonly IMemberRepository _memberRepository;

        public SSClassMemberController(ISSClassMemberRepository repository, IMemberRepository memberRepository)
        {
            _repository = repository;
            _memberRepository = memberRepository;
        }

        //
        // GET: /SSClassMember/Create
        public ActionResult Create(int id)
        {
            Grace.ViewModels.SSClassMember ssClassMember = new Grace.ViewModels.SSClassMember();
            ssClassMember.Members = _memberRepository.FindAllMembers().ToList().OrderBy(a => a.FullNameLastFirst);
            ssClassMember.SSClassMemberModel.SSClassID = id;
            
            return View(ssClassMember);
        } 

        //
        // POST: /SSClassMember/Create
        [HttpPost]
        public ActionResult Create(Grace.ViewModels.SSClassMember ssClassMember)
        {
            if (TryValidateModel(ssClassMember.SSClassMemberModel))
                try
                {
                    _repository.Add(ssClassMember.SSClassMemberModel);
                    return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.SSClass, new { id = ssClassMember.SSClassMemberModel.SSClassID });
                }
                catch
                {
                    return View(ssClassMember);
                }
            else
                return View(ssClassMember);
        }

        //
        // GET: /SSClassMember/Delete/5
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var ssClassMember = _repository.GetSSClassMember(id);
                int ssClassID = ssClassMember.SSClassID;
                _repository.Delete(ssClassMember);

                return RedirectToAction(Config.ActionVariables.Edit, Config.ControllerVariables.SSClass, new { id = ssClassID });
            }
            catch
            {
                return View();
            }
        }
    }
}
