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




        ////// EMPLOYEES
        
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

        public async Task<IActionResult>UpdateEmployee(int EmployeeId, EmployeeViewModel cvm)
        {
            try
            {
                var existingEmployee = await _crayonKidsRepository.GetEmployeeAsync(EmployeeId);
                if (existingEmployee == null) return NotFound("Could not find the employee:" + EmployeeId);
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

        public async Task<IActionResult>DeleteEmployee(int EmployeeId)
        {
            try
            {
                var existingEmployee = await _crayonKidsRepository.GetEmployeeAsync(EmployeeId);
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

        ////////////////// STUDENTS
        
        [HttpGet]
        [Route("GetAllStudents")]

        public async Task<IActionResult> GetAllStudentsAsync()
        {
            try
            {
                var results = await _crayonKidsRepository.GetAllStudentsAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");

            }
        }

        [HttpPost]
        [Route("AddStudent")]

        public async Task<IActionResult> AddStudent(StudentViewModel cvm)
        {

            var student = new Student { StudentId=cvm.StudentId, ParentGuardianId=cvm.ParentGuardianId, StudentGrade=cvm.StudentGrade, StudentName=cvm.StudentName, StudentSurname=cvm.StudentSurname};
            try
            {
                _crayonKidsRepository.Add(student);
                await _crayonKidsRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok("Record saved in the database");
        }


        [HttpPut]
        [Route("UpdateStudent")]

        public async Task<IActionResult> UpdateStudent(int StudentId, StudentViewModel cvm)
        {
            try
            {
                var existingStudent = await _crayonKidsRepository.GetStudentAsync(StudentId);
                if (existingStudent == null) return NotFound("Could not find the student:" + StudentId);
                existingStudent.StudentId = cvm.StudentId;
                existingStudent.ParentGuardianId = cvm.ParentGuardianId;
                existingStudent.StudentGrade = cvm.StudentGrade;
                existingStudent.StudentName = cvm.StudentName;
                existingStudent.StudentSurname = cvm.StudentSurname;
                
              

                if (await _crayonKidsRepository.SaveChangesAsync())
                {
                    return Ok(cvm);
                }
            }

            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }
            return Ok("Record saved in databaase");
        }

        [HttpDelete]
        [Route("DeleteStudent")]

        public async Task<IActionResult> DeleteStudent(int StudentId)
        {
            try
            {
                var existingStudent = await _crayonKidsRepository.GetStudentAsync(StudentId);
                if (existingStudent == null) return NotFound();

                _crayonKidsRepository.Delete(existingStudent);

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
        ///////////////////// SCHOOLS



        [HttpGet]
        [Route("GetAllSchools")]

        public async Task<IActionResult> GetAllSchoolsAsync()
        {
            try
            {
                var results = await _crayonKidsRepository.GetAllSchoolsAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");

            }
        }

        [HttpPost]
        [Route("AddSchool")]

        public async Task<IActionResult> AddSchool(SchoolViewModel cvm)
        {

            var school = new School {  SchoolId=cvm.SchoolId, SchoolInfoDetails=cvm.SchoolInfoDetails, SchoolLocation=cvm.SchoolLocation, SchoolName=cvm.SchoolName };
            try
            {
                _crayonKidsRepository.Add(school);
                await _crayonKidsRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok("Record saved in the database");
        }


        [HttpPut]
        [Route("UpdateSchool")]

        public async Task<IActionResult> UpdateSchool(int SchoolId, SchoolViewModel cvm)
        {
            try
            {
                var existingSchool = await _crayonKidsRepository.GetSchoolAsync(SchoolId);
                if (existingSchool == null) return NotFound("Could not find the school:" + SchoolId);
                existingSchool.SchoolId = cvm.SchoolId;
                existingSchool.SchoolInfoDetails = cvm.SchoolInfoDetails;
                existingSchool.SchoolLocation = cvm.SchoolLocation;
                existingSchool.SchoolName = cvm.SchoolName;
                



                if (await _crayonKidsRepository.SaveChangesAsync())
                {
                    return Ok(cvm);
                }
            }

            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }
            return Ok("Record saved in databaase");
        }

        [HttpDelete]
        [Route("DeleteSchool")]

        public async Task<IActionResult> DeleteSchool(int SchoolId)
        {
            try
            {
                var existingSchool = await _crayonKidsRepository.GetSchoolAsync(SchoolId);
                if (existingSchool == null) return NotFound();

                _crayonKidsRepository.Delete(existingSchool);

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
        ////////////////////// ASSESSMENT

        [HttpGet]
        [Route("GetAllAssessments")]

        public async Task<IActionResult> GetAllAssessmentsAsync()
        {
            try
            {
                var results = await _crayonKidsRepository.GetAllAssessmentsAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");

            }
        }

        [HttpPost]
        [Route("AddAssessment")]

        public async Task<IActionResult> AddAssessment(AssessmentViewModel cvm)
        {

            var assessment = new Assessment {  AssessmentId=cvm.AssessmentId, AssessmentDetails=cvm.AssessmentDetails, ReportCardTemplateId=cvm.ReportCardTemplateId };
            try
            {
                _crayonKidsRepository.Add(assessment);
                await _crayonKidsRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok("Record saved in the database");
        }


        [HttpPut]
        [Route("UpdateAssessment")]

        public async Task<IActionResult> UpdateAssessment(int AssessmentId, AssessmentViewModel cvm)
        {
            try
            {
                var existingAssessment = await _crayonKidsRepository.GetAssessmentAsync(AssessmentId);
                if (existingAssessment == null) return NotFound("Could not find the assessment:" + AssessmentId);
                existingAssessment.AssessmentId = cvm.AssessmentId;
                existingAssessment.AssessmentDetails = cvm.AssessmentDetails;
                existingAssessment.ReportCardTemplateId = cvm.ReportCardTemplateId;
               




                if (await _crayonKidsRepository.SaveChangesAsync())
                {
                    return Ok(cvm);
                }
            }

            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }
            return Ok("Record saved in databaase");
        }

        [HttpDelete]
        [Route("DeleteAssessment")]

        public async Task<IActionResult> DeleteAssessment(int AssessmentId)
        {
            try
            {
                var existingAssessment = await _crayonKidsRepository.GetAssessmentAsync(AssessmentId);
                if (existingAssessment == null) return NotFound();

                _crayonKidsRepository.Delete(existingAssessment);

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

        //////////////////// ALLERGY


        [HttpGet]
        [Route("GetAllAllergies")]

        public async Task<IActionResult> GetAllAllergiesAsync()
        {
            try
            {
                var results = await _crayonKidsRepository.GetAllAllergiesAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");

            }
        }

        [HttpPost]
        [Route("AddAllergy")]

        public async Task<IActionResult> AddAllergy(AllergyViewModel cvm)
        {

            var allergy= new Allergy { AllergyId=cvm.AllergyId, AllergyDetails=cvm.AllergyDetails, AllergyDate=cvm.AllergyDate };
            try
            {
                _crayonKidsRepository.Add(allergy);
                await _crayonKidsRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok("Record saved in the database");
        }


        [HttpPut]
        [Route("UpdateAllergy")]

        public async Task<IActionResult> UpdateAllergy(int AllergyId, AllergyViewModel cvm)
        {
            try
            {
                var existingAllergy = await _crayonKidsRepository.GetAllergyAsync(AllergyId);
                if (existingAllergy == null) return NotFound("Could not find the allergy:" + AllergyId);
                existingAllergy.AllergyId = cvm.AllergyId;
                existingAllergy.AllergyDetails = cvm.AllergyDetails;
                existingAllergy.AllergyDate = cvm.AllergyDate;





                if (await _crayonKidsRepository.SaveChangesAsync())
                {
                    return Ok(cvm);
                }
            }

            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }
            return Ok("Record saved in databaase");
        }

        [HttpDelete]
        [Route("DeleteAllergy")]

        public async Task<IActionResult> DeleteAllergy(int AllergyId)
        {
            try
            {
                var existingAllergy = await _crayonKidsRepository.GetAllergyAsync(AllergyId);
                if (existingAllergy == null) return NotFound();

                _crayonKidsRepository.Delete(existingAllergy);

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















}

