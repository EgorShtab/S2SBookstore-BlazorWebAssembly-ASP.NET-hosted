using S2SBookstore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2SBookstore.Client.Interfaces
{
    public interface IBookDataService
    {
        public Task<List<Book>> GetBooksAsync();
        public Task DeleteBookAsync(Book book);
    }
}
