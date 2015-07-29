using AutoMapper;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDB_Test.Models
{
    public class FileUserModel
    {


        public FileUserModel()
        {
        }

        public FileUserModel(FileUser model)
        {
            //Mapper.CreateMap<FileUser, FileUserModel>()
            //    .ForMember(m => m.Address, d => d.MapFrom(f => (f.Address ?? string.Empty).Split('\n')));

            Name = model.Name;
            Age = model.Age;
            Address = (model.Address ?? string.Empty).Split('\n').ToList();

        }
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Address { get; set; }
        public string Description { get; set; }
    }
}