using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccsess.Abstract;
using DataAccsess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
