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
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService studentService;
        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;

        }
        // Get All the Customers
        [HttpGet]
        public ActionResult<List<Student>>Get()
        {
            return studentService.Get();
        }

        // Get All the Customer By ID
        [HttpGet("{id}")]
        public ActionResult<Student> Get(string id)
        {
            var student = this.studentService.Get(id);
            if(student == null)
            {
                return NotFound("Not Found");
            }
            return student;
        }

        // Add Customer
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student student)
        {
            studentService.Create(student);
            return CreatedAtAction(nameof(Get), new { id = student.Id }, student);


        }

        // Update Customer Data
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Student student)
        {
            var ExistsingStudent= studentService.Get(id);
            if(ExistsingStudent == null)
            {
                return NotFound("Not Found");
            }
            studentService.Update(id, student);
            return NoContent();
        }

        // Delete CUstomer
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var student = studentService.Get(id);
            if(student == null)
            {
                return NotFound("Not Found");

            }
            studentService.Remove(student.Id);
            return Ok("Deleted");
        }
    }
}
