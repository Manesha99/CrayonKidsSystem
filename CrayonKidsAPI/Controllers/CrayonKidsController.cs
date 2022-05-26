using CrayonKidsAPI.Models;
using CrayonKidsAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrayonKidsController : ControllerBase
    {

        private readonly ICrayonKidsRepository _crayonKidsRepository;
        public  CrayonKidsController(ICrayonKidsRepository crayonKidsRepository)
        {

            _crayonKidsRepository = crayonKidsRepository;
        }





        [HttpGet]
        [Route("GetAllEmployees")]

        public async Task<IActionResult>GetAllEmployeesAsync()
        {
            try
            {
                var results = await _crayonKidsRepository.GetAllEmployeesAsync();
                return Ok(results);
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");

            }
        }

        [HttpPost]
        [Route("AddEmployee")]

        public  async Task<IActionResult>AddEmployee(EmployeeViewModel cvm)
        {

            var employee = new Employee { Address = cvm.Address, BirthDate = cvm.BirthDate, ContactNo = cvm.ContactNo, EmailAddress = cvm.EmailAddress, EmployeeTypeId = cvm.EmployeeTypeId, EmploymentStatusId = cvm.EmploymentStatusId, HireDate = cvm.HireDate, Name = cvm.Name, SchoolId = cvm.SchoolId, Surname = cvm.Surname, TitleId = cvm.TitleId, EmployeeId=cvm.EmployeeId };

            try
            {
                _crayonKidsRepository.Add(employee);
                await _crayonKidsRepository.SaveChangesAsync();
            }
            catch(Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok("Record saved in the database");
        }


        [HttpPut]
        [Route("UpdateEmployee")]

        public async Task<IActionResult>UpdateEmployee(string name, EmployeeViewModel cvm)
        {
            try
            {
                var existingEmployee = await _crayonKidsRepository.GetEmployeeAsync(name);
                if (existingEmployee == null) return NotFound("Could not find the employee:" + name);
                existingEmployee.Address = cvm.Address;
                existingEmployee.BirthDate = cvm.BirthDate;
                existingEmployee.ContactNo = cvm.ContactNo;
                existingEmployee.EmailAddress = cvm.EmailAddress;
                existingEmployee.EmployeeTypeId = cvm.EmployeeTypeId;
                existingEmployee.EmploymentStatusId = cvm.EmploymentStatusId;
                existingEmployee.HireDate = cvm.HireDate;
                existingEmployee.Name = cvm.Name;
                existingEmployee.Surname = cvm.Surname;
                existingEmployee.TitleId = cvm.TitleId;
                existingEmployee.SchoolId = cvm.SchoolId;

               if(await _crayonKidsRepository.SaveChangesAsync())
                {
                    return Ok(cvm);
                }
            }

            catch(Exception)
            {
                return BadRequest("Invalid transaction");
            }
            return Ok("Record saved in databaase");
        }

        [HttpDelete]
        [Route("DeleteEmployee")]

        public async Task<IActionResult>DeleteEmployee(string name)
        {
            try
            {
                var existingEmployee = await _crayonKidsRepository.GetEmployeeAsync(name);
                if (existingEmployee == null) return NotFound();

                _crayonKidsRepository.Delete(existingEmployee);

                if (await _crayonKidsRepository.SaveChangesAsync())
                {
                    return Ok();
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Noooooo!!!!");

            }
            return BadRequest();

                
            }
        }















        //[HttpGet]
        //[Route(" GetAllStudents")]

        //public async Task<IActionResult> GetAllStudentsAsync()
        //{
        //    try
        //    {
        //        var results = await _crayonKidsRepository.GetAllStudentsAsync();
        //        return Ok(results);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");

        //    }
        //}



    }

