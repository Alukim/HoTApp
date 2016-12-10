using susziMobilne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace susziMobilne
{
    public interface IRestService
    {
        Task<string> CheckUser(string login,string password);
        Task<User> GetUser(string login, string password);

        //Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        //Task DeleteTodoItemAsync(string id);
    }
}
