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
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;


        //Initilizing the MongoDb Connection
        public StudentService(IstudentStoreDatabseSettings settings, IMongoClient mongoClient)
        {

            var databas=mongoClient.GetDatabase("FirstDB");
            _students=databas.GetCollection<Student>("UserInfo");

        }

        //Add the customer
        public Student Create(Student student)
        {
            _students.InsertOne(student);
            return student;
      
           
        }
        //Gettign All Customer Data
        public List<Student> Get()
        {
            return _students.Find(student => true).ToList();
            
        }

        //Get Customer Dat By ID
        public Student Get(string id)
        {
            return _students.Find(student => student.Id == id).FirstOrDefault();
        }

        //Remove Customer

        public void Remove(string id)
        {
            _students.DeleteOne(student => student.Id == id);
        }


        //Update Customer Data
        public void Update(string id, Student student)
        {
            _students.ReplaceOne(student => student.Id == id,student);
        }
    }
}
