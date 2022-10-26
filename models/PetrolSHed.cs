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

    //Main Fuel Station Model
    [BsonIgnoreExtraElements]
    public class PetrolShed
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }=String.Empty;

        [BsonElement("OwnerName")]
        public string OwnerName { get; set; } = String.Empty;

        [BsonElement("OwnerContactNo")]
        public string OwnerContactNo { get; set; } = String.Empty;

        [BsonElement("PetrolShedNAme")]
        public string PetrolShedNAme { get; set; }=String.Empty ;

        [BsonElement("Location")]
        public string Location { get; set; }=String.Empty ;

        [BsonElement("Status")]
        public string Status { get; set; } = String.Empty;


        [BsonElement("Fuel")]
        public string Fuel { get; set; } = String.Empty;

        [BsonElement("LastRefill")]
        public string LastRefill { get; set; } = String.Empty;

        [BsonElement("NextRefill")]
        public string NextRefill { get; set; } = String.Empty;

        [BsonElement("TwoWheel")]
        public string TwoWheel { get; set; } ="0";


        [BsonElement("ThreeWheel")]
        public string ThreeWheel { get; set; } = "0";

        [BsonElement("FourWheel")]
        public string FourWheel { get; set; } ="0";


        [BsonElement("Other")]
        public string Other { get; set; } = "0";


        [BsonElement("WaitTime")]
        public string WaitTime { get; set; } = String.Empty;

        [BsonElement("IncmonningTwowheel")]
        public Boolean IncmonningTwowheel { get; set; } = false;


        [BsonElement("IncmonningThreewheel")]
        public Boolean IncmonningThreewheel { get; set; } = false;


        [BsonElement("IncmonningFourwheel")]
        public Boolean IncmonningFourwheel { get; set; } = false;


        [BsonElement("IncmonningOther")]
        public Boolean IncmonningOther { get; set; } = false;


        [BsonElement("FulPumping")]
        public Boolean FulPumping { get; set; } = false;


        [BsonElement("AddFuel")]
        public Boolean AddFuel { get; set; } = false;


        [BsonElement("ChangeRefillDaate")]
        public Boolean IncommingRefilDate { get; set; } = false;



    }
} 
