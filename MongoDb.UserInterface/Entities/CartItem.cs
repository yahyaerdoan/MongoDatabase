﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDb.UserInterface.Entities
{
    public class CartItem
    {
        //BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public string Id { get; set; }

       
        //public string CartId { get; set; }

      
        //public Cart Cart { get; set; }
        public string ProductId { get; set; }

      
        //public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
