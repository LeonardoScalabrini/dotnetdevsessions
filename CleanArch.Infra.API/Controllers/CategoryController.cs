using CleanArch.Infra.API.DTO;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using CleanArch.Domain.Entities;

namespace CleanArch.Infra.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService CategoryService;

        private readonly IMapper Mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            CategoryService = categoryService;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> Get()
        {
            var categories = await CategoryService.GetCategories();
            if (categories == null)
            {
                return NotFound("Categories not found");
            }
            return Ok(Mapper.Map<IEnumerable<CategoryDTO>>(categories));
        }

        [HttpGet("{id:int}", Name = "GetCategory")]
        public async Task<ActionResult<CategoryDTO>> Get(int id)
        {
            var category = await CategoryService.GetById(id);
            if (category == null)
            {
                return NotFound("Category not found");
            }
            return Ok(Mapper.Map<CategoryDTO>(category));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryDTO categoryDto)
        {
            if (categoryDto == null)
                return BadRequest("Invalid Data");

            var category = Mapper.Map<Category>(categoryDto);

            if (category == null)
                return BadRequest("Invalid Data");

            await CategoryService.Add(category);

            return new CreatedAtRouteResult("GetCategory", new { id = categoryDto.Id },
                categoryDto);
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] CategoryDTO categoryDto)
        {
            if (id != categoryDto.Id)
                return BadRequest();

            if (categoryDto == null)
                return BadRequest();

            var category = Mapper.Map<Category>(categoryDto);

            if (category == null)
                return BadRequest();

            await CategoryService.Update(category);

            return Ok(categoryDto);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CategoryDTO>> Delete(int id)
        {
            var category = await CategoryService.GetById(id);
            if (category == null)
            {
                return NotFound("Category not found");
            }

            await CategoryService.Remove(id);

            return Ok(category);

        }
    }
}
