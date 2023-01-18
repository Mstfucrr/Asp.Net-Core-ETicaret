using ETicaret.Application.Repositories.Shop;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.MVC.Controllers;

public class ProductController : Controller
{
    private readonly IProductWriteRepository _productWriteRepository;
    // GET
    public IActionResult Index()
    {
        
        return Ok();
    }
}