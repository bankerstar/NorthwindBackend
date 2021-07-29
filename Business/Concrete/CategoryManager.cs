using Business.Abstract;
using Business.Constants;
using Core.Utility.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> Add(Category category)
        {
            return new SuccsessDataResult<Category>(_categoryDal.Add(category));

        }
        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccsessResult(Messages.CategoryDeleted, Messages.CategoryDeletedId);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccsessDataResult<Category>(_categoryDal.Get(c => c.CategoryID == categoryId));

        }
        public IDataResult<List<Category>> GetList()
        {
            return new SuccsessDataResult<List<Category>>(_categoryDal.GetList().ToList());

        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccsessResult(Messages.CategoryUpdated, Messages.CategoryUpdatedId);
        }
    }
}
