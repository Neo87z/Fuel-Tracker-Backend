/*
 * //**
 *  Created By Dulanji Vithanage (IT19142142), Imalshi Dias (IT19183978), Pawani Weerasinghe (IT19133546).
 * Copyright(c) 2022 . All Rights reserved.
 *  This project was done for the EAD Assignment  1
 * /
 */
using CRUD_TEST.models;
using CRUD_TEST.services;
using Microsoft.AspNetCore.Mvc;


namespace CRUD_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetrolShedController : ControllerBase
    {


       
        private readonly IPetrolShjedService petrolShjedService;
        public PetrolShedController(IPetrolShjedService IPetrolShjedService)
        {
            this.petrolShjedService = IPetrolShjedService;

        }
        // Get Fucntion to Get All The Fuel Station Data
        [HttpGet]
        public ActionResult<List<PetrolShed>>Get()
        {
            return petrolShjedService.Get();
        }

        // Fucntion To Get The Station Data By ID
        [HttpPost("{id}")]
        public ActionResult<PetrolShed> Get(string id)
        {
            var petrolShed = this.petrolShjedService.Get(id);
            if(petrolShed == null)
            {
                return NotFound("Not Found");
            }
            return petrolShed;
        }

        // Fucntion To Add new Station
        [HttpPost]
        public ActionResult<PetrolShed> Post([FromBody] PetrolShed petrolShed)
        {
            petrolShjedService.Create(petrolShed);
            return CreatedAtAction(nameof(Get), new { id = petrolShed.Id }, petrolShed);


        }

        // Function to Update Fuel Station Data
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] PetrolShed petrolShed)
        {
     


            var ExistsingStudent= petrolShjedService.Get(id);
            if(ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            petrolShjedService.Update(id, petrolShed);
            return NoContent();
        }

        //Function to Fuel Station Dat By ID
        [HttpPost("/api/PetrolShed/UpdateShedData/{id}")]
        public ActionResult UpdateShedData(string id, [FromBody] PetrolShed petrolShed)
        {



            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            ExistsingStudent.OwnerName = petrolShed.OwnerName;
            ExistsingStudent.OwnerContactNo = petrolShed.OwnerContactNo;
            ExistsingStudent.PetrolShedNAme = petrolShed.PetrolShedNAme;
            ExistsingStudent.Location = petrolShed.Location;
       
            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }


        //Function To Update Fuel Station Fuel and Refill Times
        [HttpPost("/api/PetrolShed/updateStationFuel/{id}")]
        public ActionResult updateStationFuel(string id, [FromBody] PetrolShed petrolShed)
        {



            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            ExistsingStudent.Fuel = petrolShed.Fuel;
            DateTime now = DateTime.Now;
            ExistsingStudent.LastRefill = now.ToLongDateString();

            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }

        //Function To Update Vehciled Incmming and Exitings
        [HttpPost("/api/PetrolShed/UpdateVehciles/{id}")]
        public ActionResult UpdateVehciles(string id, [FromBody] PetrolShed petrolShed)
        {
            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            if(petrolShed.IncmonningTwowheel == true)
            {
                int x = Int32.Parse(ExistsingStudent.TwoWheel);
                int y = Int32.Parse(petrolShed.TwoWheel);
                int final = x + y;

                ExistsingStudent.TwoWheel = final.ToString();
                ExistsingStudent.IncmonningTwowheel = false;

            }
            if (petrolShed.IncmonningThreewheel == true)
            {
                int x = Int32.Parse(ExistsingStudent.ThreeWheel);
                int y = Int32.Parse(petrolShed.ThreeWheel);
                int final = x + y;

                ExistsingStudent.ThreeWheel = final.ToString();
                ExistsingStudent.IncmonningThreewheel = false;

            }
            if (petrolShed.IncmonningFourwheel == true)
            {
                int x = Int32.Parse(ExistsingStudent.FourWheel);
                int y = Int32.Parse(petrolShed.FourWheel);
                int final = x + y;

                ExistsingStudent.FourWheel = final.ToString();
                ExistsingStudent.IncmonningFourwheel = false;

            }
            if (petrolShed.IncmonningOther == true)
            {
                int x = Int32.Parse(ExistsingStudent.Other);
                int y = Int32.Parse(petrolShed.Other);
                int final = x + y;

                ExistsingStudent.Other = final.ToString();
                ExistsingStudent.IncmonningOther = false;

            }


            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }



        //Function To Update Fuel Exit Queue
        [HttpPost("/api/PetrolShed/ExitQueue/{id}")]
        public ActionResult ExitQueue(string id, [FromBody] PetrolShed petrolShed)
        {
            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            if (petrolShed.IncmonningTwowheel == true)
            {
                int x = Int32.Parse(ExistsingStudent.TwoWheel);
              
                x = x - 1;

                ExistsingStudent.TwoWheel = x.ToString();
                ExistsingStudent.IncmonningTwowheel = false;

            }
            if (petrolShed.IncmonningThreewheel == true)
            {
                int x = Int32.Parse(ExistsingStudent.ThreeWheel);
             
                x = x - 1;

                ExistsingStudent.ThreeWheel = x.ToString();
                ExistsingStudent.IncmonningThreewheel = false;

            }
            if (petrolShed.IncmonningFourwheel == true)
            {
                int x = Int32.Parse(ExistsingStudent.FourWheel);
                
                x = x - 1;

                ExistsingStudent.FourWheel = x.ToString();
                ExistsingStudent.IncmonningFourwheel = false;

            }
            if (petrolShed.IncmonningOther == true)
            {
                int x = Int32.Parse(ExistsingStudent.Other);
               
                x = x - 1;

                ExistsingStudent.Other = x.ToString();
                ExistsingStudent.IncmonningOther = false;

            }


            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }

        //Function To Update Fuel Station Fuel Fuel Ammount

        [HttpPost("/api/PetrolShed/UpdateFuel/{id}")]
        public ActionResult UpdateFuel(string id, [FromBody] PetrolShed petrolShed)
        {
            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            if (petrolShed.FulPumping == true)
            {
                int x = Int32.Parse(ExistsingStudent.Fuel);
                int y = Int32.Parse(petrolShed.Fuel);
                int final = x - y;

                ExistsingStudent.Fuel = final.ToString();
                ExistsingStudent.FulPumping = false;

            }
           
            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }


        //Function To Add Fuel Station Fuel 
        [HttpPut("/api/PetrolShed/AddFuel/{id}")]
        public ActionResult AddFuel(string id, [FromBody] PetrolShed petrolShed)
        {
            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            if (petrolShed.AddFuel == true)
            {
                int x = Int32.Parse(ExistsingStudent.Fuel);
                int y = Int32.Parse(petrolShed.Fuel);
                int final = x + y;

                ExistsingStudent.Fuel = final.ToString();
                ExistsingStudent.AddFuel = false;

            }

            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }



        //Function To Update Refil Times
        [HttpPut("/api/PetrolShed/UpdateRefilldate/{id}")]
        public ActionResult UpdateRefilldate(string id, [FromBody] PetrolShed petrolShed)
        {
            var ExistsingStudent = petrolShjedService.Get(id);
            if (ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            if (petrolShed.IncommingRefilDate == true)
            {




                ExistsingStudent.NextRefill = petrolShed.NextRefill;

                ExistsingStudent.IncommingRefilDate = false;

            }

            petrolShjedService.Update(id, ExistsingStudent);
            return NoContent();
        }






        //Fucntion to Delete Fuel Station
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var student = petrolShjedService.Get(id);
            if(student == null)
            {
                return NotFound("Not Found");

            }
            petrolShjedService.Remove(student.Id);
            return Ok("Deleted");
        }
    }
}
