using S2SBookstore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2SBookstore.Client.Interfaces
{
    public interface IBookApiClient
    {
        Task<List<Book>> GetBooksAsync();
        Task DeleteBookAsync(Book book);
    }
}
