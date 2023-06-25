﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Core.DataAccess
{
    public interface IRepostoryBase<TEntity>
    {

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity,bool>>filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter=null);
    
    }
}
