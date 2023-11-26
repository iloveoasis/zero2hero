using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HeroBlazorApp.Data
{
    public class UserService
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<User>> GetUsersAsync()
        {
            var streamTask = client.GetStreamAsync("https://jsonplaceholder.typicode.com/users");
            var users = await JsonSerializer.DeserializeAsync<List<User>>(await streamTask);
            return users;
        }
    }
}