﻿using CommandCore.Prefabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandCore.Services
{
    public interface IPublishingService
    {
        bool PublishData(ArticlePrefab articlePrefab);
    }
}