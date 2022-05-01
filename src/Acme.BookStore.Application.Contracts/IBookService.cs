using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface IBookService:ICrudAppService<BookDTO,Guid,CreateUpdateBookDTO>
    {
    }
}
