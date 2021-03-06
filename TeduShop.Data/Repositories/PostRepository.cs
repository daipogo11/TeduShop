﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetByAlias(string alias);
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactoty) : base(dbFactoty)
        {

        }

        public IEnumerable<Post> GetByAlias(string alias)
        {
            return this.DbContext.Posts.Where(x => x.Alias == alias);
        }
    }
}
