using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.MVC.Controllers;

public class CategoryController : Controller
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly ICategoryReadRepository _categoryReadRepository;

    private readonly IProductWriteRepository _productWriteRepository;

    private readonly IProductReadRepository _productReadRepository;
    // GET
    public CategoryController(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository, IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _categoryReadRepository = categoryReadRepository;
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        //var category = new Category
        //{
        //    Name = "TestName as üğ",
        //    Description = "TestDescription",
        //    CreatedDate = DateTime.UtcNow,
        //    UpdatedDate = DateTime.UtcNow,
        //    Id = Guid.NewGuid(),
        //    Status = true,
        //};
        //category.CreateSlug();
        //var category2 = new Category
        //{
        //    Name = "TestName as üğ",
        //    Description = "TestDescription",
        //    CreatedDate = DateTime.UtcNow,
        //    UpdatedDate = DateTime.UtcNow,
        //    Id = Guid.NewGuid(),
        //    Status = true,
        //    ParentCategory = category,
        //};
        //category2.CreateSlug();
        
        //var product = new Product
        //{
        //    Name = "TestProductName ö",
        //    Description = "TestProductDescription",
        //    CreatedDate = DateTime.UtcNow,
        //    UpdatedDate = DateTime.UtcNow,
        //    Id = Guid.NewGuid(),
        //    Status = true,
        //    Category = category2,
        //    Price = 100.214m,
        //    Stock = 100,
        //};
        //product.GenerateSlug();
        
        
        //await _categoryWriteRepository.AddRangeAsync(new List<Category>
        //{
        //    category,category2
        //});
        //await _productWriteRepository.AddAsync(product);
        //await _categoryWriteRepository.SaveAsync();
        //await _productWriteRepository.SaveAsync();
        var categories = _categoryReadRepository.GetAll().ToList();
        var products = _productReadRepository.GetAll().ToList();



        
        //if (cs == null)
        //{
        //    return Ok(cs);
        //}
        //var product = await _productReadRepository.GetyIdAsync("ea8c8604-2881-4484-b6c5-7874a18ade5e");

        //var p = _productReadRepository.GetyIdAsync(product.Id.ToString()).Result;


        return Ok(new { categories, products });
    }
}