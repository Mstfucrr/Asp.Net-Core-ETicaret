using ETicaret.Application.Repositories.Shop;
using ETicaret.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

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
        var category = await _categoryReadRepository.GetyIdAsync("1da398a1-8797-43a6-99d5-e95cbbeaded4");

        var product = await _productReadRepository.GetyIdAsync("ea8c8604-2881-4484-b6c5-7874a18ade5e");

        var p = _productReadRepository.GetyIdAsync(product.Id.ToString()).Result;


        return Ok(new { category, p});
    }
}