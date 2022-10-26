/*
 * //**
 *  Created By Dulanji Vithanage (IT19142142), Imalshi Dias (IT19183978), Pawani Weerasinghe (IT19133546).
 * Copyright(c) 2022 . All Rights reserved.
 *  This project was done for the EAD Assignment  1
 * /
 */
namespace CRUD_TEST.models
{

    //Database Settings
    public class StudentStoreDatabseSettings:IstudentStoreDatabseSettings
    {
        public string StudentCoursesCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; }= String.Empty;

        public string DatabaseName { get; set; } = String.Empty;
    }
}
