﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiaheng.House2.Vote.Entities;
using Jiaheng.House2.Vote.Repository.Interfaces;

namespace Jiaheng.House2.Vote.Repository.Dao
{
    public class ArticlesRepository : VoteRepository<Selectobj_articles>, IArticlesRepository<Selectobj_articles>
    {

    }
}
