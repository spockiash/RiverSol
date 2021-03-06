﻿using IdentityLib.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCApp.EntityServices;
using MVCApp.Models;
using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    [Authorize(Roles = RoleDef.Admin)]
    public class AdminController : Controller
    {
        #region fields
        private IArticleModelService _articleService;
        private readonly IAccountModelService _accountService;
        private readonly ICredentialsService _credentialsService;

        #endregion
        #region ctor
        public AdminController(IArticleModelService articleService,
                                IAccountModelService accountService,
                                ICredentialsService credentialsService)
        {
            this._articleService = articleService;
            this._accountService = accountService;
            this._credentialsService = credentialsService;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Articles()
        //{
        //    var articles = _articleService.FetchArticles();
        //    return View(articles);
        //}

        //public IActionResult Accounts()
        //{
        //    var accounts = _accountService.GetAllAccounts();
        //    return View(accounts);
        //}
        

        //public IActionResult Synchronize()
        //{
        //    //retrieves all users in identity database
            
        //    var usersFromIdentity = _credentialsService.RetrieveUsers().Result;

        //    //performs synchronization of all users registered in app
        //    var resultAccounts = _accountService.Synchronize(usersFromIdentity);
        //    return View("Accounts", resultAccounts);
        //}

        //[HttpGet]
        //public IActionResult SearchUser(string searchQuery)
        //{
        //    var resultAccounts = _accountService.GetMatchingAccounts(searchQuery);

        //    return PartialView("_AccountsPartial", resultAccounts);
        //}

        //[HttpGet]
        //public IActionResult SortBy(string sortMode) 
        //{
        //    //sort and  return
        //    //if sortMode is null, no mode is tripped and unsorted list is returned
        //    var result = _accountService.SortAllAccounts(sortMode);
        //    return PartialView("_AccountsPartial", result);
        //}

        //[HttpGet]
        //public IActionResult Delete(int Id)
        //{
        //    //remove user from identity database
        //    var eventRes = _credentialsService.DeleteUser(Id, this.User);
        //    //delete user from main database
        //    if (eventRes)
        //    {
        //        _accountService.DeleteAccount(Id);
        //        return StatusCode(200, "User has been deleted");

        //    }
        //    return StatusCode(403, "Cannot delete this user");
        //}


    }
}
