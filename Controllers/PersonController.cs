using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 


       [HttpGet]
        [Route("GetFields")]
        public IActionResult GetFields()
        {
            var repository = new PersonRepository();
            var persons = repository.GetFields();
            return Ok(persons);
        } 
















        [HttpGet]
        [Route("{GetJobs}")]
 public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 


        [HttpGet]
        [Route("GetDistincJobs")]
         public IActionResult GetDistincJobs(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetDistincJobs(job);
            return Ok(persons);
        } 









        [HttpGet]
        [Route("GetStartWith")]

         public IActionResult GetStartWith(string word)
        {
            var repository = new PersonRepository();
            var persons = repository.GetStartWith(word);
            return Ok(persons);
        } 

















         [HttpGet]
        [Route("GetRange")]
         public IActionResult GetRange(int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetRange(minAge, maxAge);
            return Ok(persons);
        } 





          [HttpGet]
        [Route("GetCount")]
         public IActionResult GetCount(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetCount(job);
            return Ok(persons);
        } 






        [HttpGet]
        [Route("GetExist")]
         public IActionResult GetExist(string firstName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetExist(firstName);
            return Ok(persons);
        } 





        [HttpGet]
        [Route("GetAny")]
         public IActionResult GetAny(string lastName)
        {
            var repository = new PersonRepository();
            var persons = repository.GetAny(lastName);
            return Ok(persons);
        } 














        [HttpGet]
        [Route("GetByid")]
         public IActionResult GetByid(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByid(job);
            return Ok(persons);
        } 














        [HttpGet]
        [Route("GetTake")]
         public IActionResult GetTake(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetTake(job);
            return Ok(persons);
        }







        [HttpGet]
        [Route("GetSkip")]
         public IActionResult GetSkip(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.GetSkip(job);
            return Ok(persons);
        } 









        






        
    }
}