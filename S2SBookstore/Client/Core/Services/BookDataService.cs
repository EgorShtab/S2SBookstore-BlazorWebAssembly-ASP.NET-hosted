using S2SBookstore.Client.Interfaces;
using S2SBookstore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace S2SBookstore.Client.Core.Services
{
    public class BookDataService : IBookDataService
    {
        private readonly IBookApiClient httpClient;
        public BookDataService(IBookApiClient client)
        {
            httpClient = client;
        }
        public async Task<List<Book>> GetBooksAsync()
        {
            return await httpClient.GetBooksAsync();
        }
        public async Task DeleteBookAsync(Book book)
        {
            await httpClient.DeleteBookAsync(book);
        }
    }
}
