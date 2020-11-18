﻿using CommandCore.Prefabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCore.Factories
{
    public interface IArticlePrefactory
    {
        List<ArticlePrefab> CreateArticle();
        List<ArticlePrefab> CreateArticles();

    }
}