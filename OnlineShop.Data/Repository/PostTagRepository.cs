﻿using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repository
{
    public interface IPostTagsRepository { }
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagsRepository
    {
        protected PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}