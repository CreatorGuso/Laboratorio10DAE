using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Producto;

[Route("orders")]
[ApiController]
public class OrdersController : Controller
{
    private readonly ProdctoModels _db;

    [HttpPost]
    public async Task<ActionResult<int>> PlaceOrder(Order order)
    {
        Producto.CreatedTime = DateTime.Now;
        
        _db.Orders.Attach(Producto);
        await _db.SaveChangesAsync();

        return Producto.ProductID;
    }
}

