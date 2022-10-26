/*
 * //**
 *  Created By Dulanji Vithanage (IT19142142), Imalshi Dias (IT19183978), Pawani Weerasinghe (IT19133546).
 * Copyright(c) 2022 . All Rights reserved.
 *  This project was done for the EAD Assignment  1
 * /
 */
using CRUD_TEST.models;

namespace CRUD_TEST.services
{

    //Customer Service Interface
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);

        void Update(string id, Student student);

        void Remove(string id);

    }
}
