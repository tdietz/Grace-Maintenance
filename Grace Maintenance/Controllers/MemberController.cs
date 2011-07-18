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
    public class MemberController : Controller
    {
        private readonly IMemberRepository _repository;
        private readonly IGraceConfigService _graceConfigService;
        private readonly IGraceSessionService _graceSessionService;
        private readonly IGraceGlobalCacheService _graceGlobalCacheService;

        public MemberController(IMemberRepository repository, IGraceConfigService graceConfigService, IGraceSessionService graceSessionService, IGraceGlobalCacheService graceGlobalCacheService)
        {
            _repository = repository;
            _graceConfigService = graceConfigService;
            _graceSessionService = graceSessionService;
            _graceGlobalCacheService = graceGlobalCacheService;
        }

        //
        // GET: /Member/
        public ActionResult Index(string lastName, GridSortOptions sort)
        {
            var members = new Grace.ViewModels.MemberList(_repository.FindAllMembers());
            
            if (sort.Column == null)
            {
                if (_graceSessionService.MemberSort != null)
                {
                    sort = _graceSessionService.MemberSort;
                }
                else
                {
                    sort = new GridSortOptions();
                    sort.Column = "LastName";
                }
            } 

            if (string.IsNullOrWhiteSpace(lastName) && _graceSessionService.LastName != null) lastName = _graceSessionService.LastName;

            if (sort.Column != null)
            {
                members.MembersModel = members.MembersModel.OrderBy(sort.Column, sort.Direction);
            }

            // Filter on LastName
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                members.MembersModel = members.MembersModel.Where(a => a.LastName.ToLower().Contains(lastName.ToLower()));
            }
            _graceSessionService.LastName = lastName;
            _graceSessionService.MemberSort = sort;
            members.LastName = lastName;
            ViewData[Config.ViewDataVariables.Sort] = sort;
            return View(members);
        }

        //
        // GET: /Member/Create
        public ActionResult Create()
        {
            Grace.ViewModels.Member member = new Grace.ViewModels.Member();
            member.States = _graceGlobalCacheService.States;
            member.MemberJoinTypes = _graceGlobalCacheService.MemberJoinTypes;
            member.MemberLeaveTypes = _graceGlobalCacheService.MemberLeaveTypes;
            member.MemberModel.ChurchID = _graceConfigService.ChurchID;
            return View(member);
        } 

        //
        // POST: /Member/Create
        [HttpPost]
        public ActionResult Create(Grace.ViewModels.Member member)
        {
            if (TryValidateModel(member.MemberModel))
                try
                {
                    _repository.Add(member.MemberModel);
                    return RedirectToAction(Config.ActionVariables.Index);
                }
                catch
                {
                    return View(member);
                }
            else
                return View(member);
        }
        
        //
        // GET: /Member/Edit/5
        public ActionResult Edit(int id)
        {
            var member = new Grace.ViewModels.Member(_repository.GetMember(id));
            member.States = _graceGlobalCacheService.States;
            member.MemberJoinTypes = _graceGlobalCacheService.MemberJoinTypes;
            member.MemberLeaveTypes = _graceGlobalCacheService.MemberLeaveTypes;

            return View(member);
        }

        //
        // POST: /Member/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var member = new Grace.ViewModels.Member(_repository.GetMember(id));

            try
            {
                UpdateModel(member, collection.ToValueProvider());
                _repository.Update();
                return RedirectToAction(Config.ActionVariables.Index);
            }
            catch
            {
                return View(member);
            }
        }

        //
        // POST: /Member/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var member = _repository.GetMember(id);
                _repository.Delete(member);
 
                return RedirectToAction(Config.ActionVariables.Index);
            }
            catch
            {
                return View();
            }
        }
    }
}
