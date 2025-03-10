using Models;

namespace Interfaces;

interface IBookRepository
{
    Book GetById(int id);
    Dictionary<int, Book> Find(string query);
    void Add(Book book);
    void Update(Book book);
    void Delete(int id);
}