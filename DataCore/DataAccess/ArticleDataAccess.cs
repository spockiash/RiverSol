﻿using DataCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCore.DataAccess
{
    public class ArticleDataAccess : IArticleDataAccess
    {
        private DataContext _db;

        public ArticleDataAccess(DataContext db)
        {
            this._db = db;
        }

        public Article Read(int id)
        {
            return _db.Articles.Find(id);
        }

        public bool Save(Article article)
        {
            _db.Add(article);
            return true;
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public Article SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> SelectAll()
        {
            var queryResult = _db.Articles;
            return queryResult.ToList();
        }
    }
}