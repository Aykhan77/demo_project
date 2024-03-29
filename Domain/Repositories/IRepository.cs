﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity Create(TEntity entity);
    }
}
