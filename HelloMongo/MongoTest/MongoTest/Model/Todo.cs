using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoTest.Model
{
    public class Todo
    {
        public ObjectId _id { get; set; }
        public int TodoId { get; set; }
        public string TodoName { get; set; }
    }
}
