﻿using DataCore.Entities;
using IdentityLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCore.Factories
{
    public interface IAccountFactory
    {
        List<Account> ConstructAccounts(List<User> users, bool isNew = false, bool isDefault = false);
        Account GetAccount(int Id);
        IEnumerable<Account> GetAll();
        List<Account> ConstructMatching(string matchString);
    }
}
