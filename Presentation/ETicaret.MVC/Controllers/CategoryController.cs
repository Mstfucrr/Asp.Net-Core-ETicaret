using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.MVC.Controllers;

[Route("/[controller]")]
public class CategoryController : Controller
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly ICategoryReadRepository _categoryReadRepository;

    private readonly IProductWriteRepository _productWriteRepository;

    private readonly IProductReadRepository _productReadRepository;
    private readonly IOrderReadRepository _orderReadRepository;
    private readonly IOrderWriteRepository _orderWriteRepository;
    // GET
    public CategoryController(ICategoryWriteRepository categoryWriteRepository,
        ICategoryReadRepository categoryReadRepository, IProductReadRepository productReadRepository,
        IProductWriteRepository productWriteRepository, IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _categoryReadRepository = categoryReadRepository;
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
        _orderReadRepository = orderReadRepository;
        _orderWriteRepository = orderWriteRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Index() // Task olduğu için serviceRegistration scope patlamıyor eğer void olsaydı serviceRegistration singelton olmalıydı
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

        var c = _categoryReadRepository.GetyIdAsync("62b87bd0-c125-48be-9dc9-08e562b2acd9").Result;
        //await _orderWriteRepository.AddAsync(new Order()
        //{
        //    OrderNumber = "123123",
        //    TotalPrice = 1112.23M
        //});

        //await _orderWriteRepository.SaveAsync();
        //if (cs == null)
        //{
        //    return Ok(cs);
        //}
        //var product = await _productReadRepository.GetyIdAsync("ea8c8604-2881-4484-b6c5-7874a18ade5e");

        //var p = _productReadRepository.GetyIdAsync(product.Id.ToString()).Result;
        

        return Ok(new { categories, products });
    }

    [Route("category/{slug}")]
    [HttpGet("{slug}")] 
    public async Task<IActionResult> Index(string slug)
    {
        

        var products = await _productReadRepository.GetAll().Where(p => p.Category.Slug.Contains(slug)).Include(p=> p.Category).ToListAsync();


        var category = await _categoryReadRepository.GetSingleAsync(c => c.CreatedDate.Day == 4);

        category.Name = "TestName update";
        await _categoryWriteRepository.UpdateAsync(category);
        await _categoryWriteRepository.SaveAsync();


        //products.Category.Name = "Denem1";
        //await _categoryWriteRepository.SaveAsync();
        //var prs = await _productReadRepository.GetyIdAsync("1b3cd2a3-656c-460d-889a-6af56f323c99");

        return Ok(new { products });
    }

}
