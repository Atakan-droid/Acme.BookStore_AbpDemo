using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book,BookDTO>().ReverseMap();
        CreateMap<Book, CreateUpdateBookDTO>().ReverseMap();
    }
}
