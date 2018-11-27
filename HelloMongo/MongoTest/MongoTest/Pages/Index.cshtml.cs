using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using MongoTest.Model;

namespace MongoTest.Pages
{
    public class IndexModel : PageModel
    {
        public List<Todo> Todos;

        public void OnGet()
        {
            Todos = GetAll();
        }

        private List<Todo>GetAll()
        {
            var connectionString = "mongodb://root:root@mongo";
            var database = "TodoDB";
            var _client = new MongoClient(connectionString);
            var _database = _client.GetDatabase(database);

            var data = _database.GetCollection<Todo>("Todo");

            var rets = data.Find(_ => true).ToList();
            return rets;
        }
    }
}
