/*
 * //**
 *  Created By Dulanji Vithanage (IT19142142), Imalshi Dias (IT19183978), Pawani Weerasinghe (IT19133546).
 * Copyright(c) 2022 . All Rights reserved.
 *  This project was done for the EAD Assignment  1
 * /
 */
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace CRUD_TEST.models
{

    //Main Customer Model
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }=String.Empty;

        [BsonElement("Fname")]
        public string Fname { get; set; } = String.Empty;

        [BsonElement("Lname")]
        public string Sender { get; set; }=String.Empty ;

        [BsonElement("Email")]
        public string Message { get; set; }=String.Empty ;

        [BsonElement("Password")]
        public string Password { get; set; } = String.Empty;


        [BsonElement("PlateNumber")]
        public string PlateNumber { get; set; } = String.Empty;

        [BsonElement("ModelNumber")]
        public string ModelNumber { get; set; } = String.Empty;

        [BsonElement("Color")]
        public string Color { get; set; } = String.Empty;

        [BsonElement("Type")]
        public string Type { get; set; } = String.Empty;
    }
} 
