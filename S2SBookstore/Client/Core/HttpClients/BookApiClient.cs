using S2SBookstore.Client.Interfaces;
using S2SBookstore.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace S2SBookstore.Client.Core.HttpClients
{
    public class BookApiClient:IBookApiClient
    {
        private readonly HttpClient httpClient;
        public BookApiClient(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            string url = "api/books";
            return await httpClient.GetFromJsonAsync<List<Book>>(url);
        }

        public async Task DeleteBookAsync(Book book)
        {
            await httpClient.DeleteAsync("api/books?bookID="+book.ID);
        }
    }
}
