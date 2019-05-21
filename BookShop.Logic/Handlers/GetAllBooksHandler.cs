using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BookShop.Data;
using BookShop.Logic.Models;
using BookShop.Logic.Queries;
using MediatR;

namespace BookShop.Logic.Handlers
{
    public class GetAllBooksHandler:IRequestHandler<GetAllBooks, IEnumerable<Book>>
    {
        public Task<IEnumerable<Book>> Handle(GetAllBooks request, CancellationToken cancellationToken)
        {
            var items = BookStorage.Books.Select(b => new Book()
                                                      {
                                                          Id = b.Id,
                                                          Price = b.Price,
                                                          Title = b.Title
                                                      }).ToArray();

            return Task.FromResult((IEnumerable<Book>)items);
        }
    }
}