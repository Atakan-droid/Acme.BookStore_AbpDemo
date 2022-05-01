using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book,Guid> _repository;

        public BookStoreDataSeederContributor(IRepository<Book, Guid> repository)
        {
            _repository = repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _repository.GetCountAsync() <= 0)
            {
                await _repository.InsertAsync(
                    new Book
                    {
                        Name="1987",
                        Type=BookType.Science,
                        PublishDate=new DateTime(1948,6,23),
                        Price=19.84f
                    },
                    autoSave: true);
                await _repository.InsertAsync(
                    new Book
                    {
                        Name = "The Hitchhiker's Guide to the Galaxy",
                        Type = BookType.Adventure,
                        PublishDate = new DateTime(1988, 4, 2),
                        Price = 42.0f
                    },
                    autoSave: true);
            }
        }
    }
}
