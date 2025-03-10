using Models;
using Interfaces;

namespace Repositories;

class BookRepository : IBookRepository
{
    public Book GetById(int id)
    {
        throw new NotImplementedException();
    }
    
    public Dictionary<int, Book> Find(string query)
    {
        throw new NotImplementedException();
    }
    
    public void Add(Book book)
    {
        throw new NotImplementedException();
    }
    
    public void Update(Book book)
    {
        throw new NotImplementedException();
    }
    
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}