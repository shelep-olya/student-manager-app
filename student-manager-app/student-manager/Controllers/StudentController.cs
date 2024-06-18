using Microsoft.AspNetCore.Mvc;
using student_manager.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace student_manager.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentServices _studentServices;
        public StudentController(StudentServices studentServices) 
        { 
           _studentServices = studentServices;
        }
        // GET: api/student
        [HttpGet]
        public async Task<List<Models.Student>> Get() => await _studentServices.GetAsync();
     

        // GET api/student/667143da4918795d94cabae0
        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult <Models.Student>> Get(string id)
        {
            Models.Student student = await _studentServices.getAsync(id);
            if(student == null)
            {
                return NotFound();
            }
            return student;
        }

        // POST api/student
        [HttpPost]
        public async Task<ActionResult<Models.Student>> Post(Models.Student newStudent)
        {
            await _studentServices.CreateAsync(newStudent);
            return CreatedAtAction(nameof(Get),new { id = newStudent.Id }, newStudent);
        }
        

        // PUT api/student/667143da4918795d94cabae0
        [HttpPut("{id:length(24)}")]
        public async Task<ActionResult> Put(string id, Models.Student updatedStudent )
        {
            Models.Student student = await _studentServices.getAsync(id);
            if(student == null)
            {
                return NotFound("There is no student with this id");
            }
            updatedStudent.Id = student.Id;
            await _studentServices.UpdateAsync(id, updatedStudent);
            return Ok("Updated successfully");
        }

        // DELETE api/student/667143da4918795d94cabae0
        [HttpDelete("{id:length(24)}")]
        public async Task<ActionResult> Delete(string id)
        {
            Models.Student student = await _studentServices.getAsync(id);
            if (student == null)
            {
                return NotFound("There is no student with this id");
            }
            
            await _studentServices.RemoveAsync(id);
            return Ok("Deleted successfully");
        }
    }
}
