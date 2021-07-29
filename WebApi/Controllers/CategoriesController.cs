using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();

            if (!result.Succsess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int categoryId)
        {
            var result = _categoryService.GetById(categoryId);

            if (!result.Succsess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Category category)
        {
            var result = _categoryService.Add(category);

            if (!result.Succsess)
                return BadRequest(result);

            return Ok(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Category category)
        {
            var result = _categoryService.Update(category);

            if (!result.Succsess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (!result.Succsess)
                return BadRequest(result);

            return Ok(result);
        }
    }
}

