using System.Collections.Generic;
using BookShop.Logic.Models;
using MediatR;

namespace BookShop.Logic.Queries
{
    public class GetAllBooks : IRequest<IEnumerable<Book>>
    {
    }
}