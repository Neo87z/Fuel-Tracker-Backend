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
    //Interface for Fuel Station Service
    public interface IPetrolShjedService
    {
        List<PetrolShed> Get();
        PetrolShed Get(string id);
        PetrolShed Create(PetrolShed student);
        void Update(string id, PetrolShed student);

        void Remove(string id);

    }
}
