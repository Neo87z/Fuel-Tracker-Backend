/*
 * //**
 *  Created By Dulanji Vithanage (IT19142142), Imalshi Dias (IT19183978), Pawani Weerasinghe (IT19133546).
 * Copyright(c) 2022 . All Rights reserved.
 *  This project was done for the EAD Assignment  1
 * /
 */
namespace CRUD_TEST.models
{
    //interface to Handle DatabseSettings
    public interface IstudentStoreDatabseSettings
    {
        string StudentCoursesCollectionName { get;set;}
        string ConnectionString { get; set;}        

        string DatabaseName { get; set;}    
    }
}
