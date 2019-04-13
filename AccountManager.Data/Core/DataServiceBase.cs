using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager.Data.Core
{
   public abstract class DataServiceBase<TEntity, TContext>
        where TEntity: class
       where TContext:DbContext 
    {
        public DataServiceBase(IMapper mapper, TContext context)
        {
            Context = context;
            Mapper = mapper;
        }

        protected TContext Context { get; set; }
        protected IMapper Mapper { get; set; }

        public IQueryable<TDTO>  GeTAll<TDTO>()
        {
            DbSet<TEntity> table = Context.Set<TEntity>();
            return Mapper.ProjectTo<TDTO>(table);
        }
    }
}
