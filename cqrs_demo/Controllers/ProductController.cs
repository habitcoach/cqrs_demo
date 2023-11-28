using cqrs_demo.Commands;
using cqrs_demo.Models;
using cqrs_demo.Queries;
using cqrs_demo.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace cqrs_demo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ActionResult> Index()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return View(products);
        }

        [HttpGet]
        public Task<ActionResult> Create()
        {

            return Task.FromResult<ActionResult>(View());
        }


        [HttpPost]
        public async Task<ActionResult> Create(Product product)
        {

            await _mediator.Send(new AddProductCommand(product));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _mediator.Send(new GetProductsByIdQuery(id));
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Product product)
        {
            var productfromDB = await _mediator.Send(new UpdateProductCommand(product));
            return RedirectToAction(nameof(Index));

        }
    }
}
