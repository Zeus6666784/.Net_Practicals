using Microsoft.AspNetCore.Mvc;
using P5_B.Models;
public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        Product p = new Product();

        p.Name = "Laptop";
        p.Price = 50000;

        _context.Products.Add(p);
        _context.SaveChanges();

        return Content("Product Inserted Successfully");
    }
}
