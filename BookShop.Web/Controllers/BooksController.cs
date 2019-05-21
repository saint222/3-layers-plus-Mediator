using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Logic.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Web.Controllers
{

    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/books")]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            var result = await _mediator.Send(new GetAllBooks());
            return result.Any() ? (IActionResult)Ok(result) : NotFound();

        }
    }
}