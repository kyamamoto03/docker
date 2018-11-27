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
    public class InsertModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost(Todo todo)
        {
            var connectionString = "mongodb://root:root@mongo";
            var database = "TodoDB";
            var _client = new MongoClient(connectionString);
            var _database = _client.GetDatabase(database);

            var data = _database.GetCollection<Todo>("Todo");

            data.InsertOne(todo);

            return Redirect("/");
        }
    }
}