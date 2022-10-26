/*
 * //**
 *  Created By Dulanji Vithanage (IT19142142), Imalshi Dias (IT19183978), Pawani Weerasinghe (IT19133546).
 * Copyright(c) 2022 . All Rights reserved.
 *  This project was done for the EAD Assignment  1
 * /
 */
using CRUD_TEST.models;
using MongoDB.Driver;

namespace CRUD_TEST.services
{

    //Fuel Stattion MongoDB Main File
    public class PetrolShedService : IPetrolShjedService
    {
        private readonly IMongoCollection<PetrolShed> _students;


        //Initilizing the MongoDb Connection
        public PetrolShedService(IstudentStoreDatabseSettings settings, IMongoClient mongoClient)
        {

            var databas=mongoClient.GetDatabase("FirstDB");
            _students=databas.GetCollection<PetrolShed>("PetrolShedDAta");

        }

        //Function to Create A Fuel Station
        public PetrolShed Create(PetrolShed petrolShed)
        {
            _students.InsertOne(petrolShed);
            return petrolShed;
      
           
        }

        //Fucntion to get all the fuel Stations
        public List<PetrolShed> Get()
        {
            return _students.Find(petrolShed => true).ToList();
            
        }

        //Fuction to get the fuel station by ID 
        public PetrolShed Get(string id)
        {
            return _students.Find(petrolShed => petrolShed.Id == id).FirstOrDefault();
        }

        //Fucntion to remov ethe fuel station
        public void Remove(string id)
        {
            _students.DeleteOne(petrolShed => petrolShed.Id == id);
        }


        //Function to update the Fuel Station
        public void Update(string id, PetrolShed petrolShed)
        {
            _students.ReplaceOne(petrolShed => petrolShed.Id == id, petrolShed);
        }
    }
}
