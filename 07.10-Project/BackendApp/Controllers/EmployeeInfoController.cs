using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendApp.Models;
using BackendApp.Interfaces;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfoController : ControllerBase
    {
        private readonly IEmployeeInfoService _employeeInfoService;
        public EmployeeInfoController(IEmployeeInfoService employeeInfoService)
        {
            _employeeInfoService = employeeInfoService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/EmployeeInfo/EmployeeInfo")]
        public IEnumerable<EmployeeInfo> GetEmployeeInfo()
        {
            return _employeeInfoService.GetEmployeeInfo();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/EmployeeInfo/GetEmployeeInfoId")]
        public EmployeeInfo GetEmployeeInfoId(int id)
        {
            return _employeeInfoService.GetEmployeeInfoById(id);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/EmployeeInfo/AddEmployeeInfo")]
        public EmployeeInfo AddEmployeeInfo(EmployeeInfo employeeInfo)
        {
            return _employeeInfoService.AddEmployeeInfo(employeeInfo);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/EmployeeInfo/EditEmployeeInfo")]
        public EmployeeInfo EditEmployeeInfo(EmployeeInfo employeeInfo)
        {
            return _employeeInfoService.UpdateEmployeeInfo(employeeInfo);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/EmployeeInfo/DeleteEmployeeInfo")]
        public EmployeeInfo DeleteEmployeeInfo(int id)
        {
            return _employeeInfoService.DeleteEmployeeInfo(id);
        }

        /* 
         // GET: api/EmployeeInfoes
         [HttpGet]
         public async Task<ActionResult<IEnumerable<EmployeeInfo>>> GetEmployeeInfos()
         {
             return await _context.EmployeeInfos.ToListAsync();
         }

         // GET: api/EmployeeInfoes/5
         [HttpGet("{id}")]
         public async Task<ActionResult<EmployeeInfo>> GetEmployeeInfo(int id)
         {
             var employeeInfo = await _context.EmployeeInfos.FindAsync(id);

             if (employeeInfo == null)
             {
                 return NotFound();
             }

             return employeeInfo;
         }

         // PUT: api/EmployeeInfoes/5
         // To protect from overposting attacks, enable the specific properties you want to bind to, for
         // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
         [HttpPut("{id}")]
         public async Task<IActionResult> PutEmployeeInfo(int id, EmployeeInfo employeeInfo)
         {
             if (id != employeeInfo.Id)
             {
                 return BadRequest();
             }

             _context.Entry(employeeInfo).State = EntityState.Modified;

             try
             {
                 await _context.SaveChangesAsync();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!EmployeeInfoExists(id))
                 {
                     return NotFound();
                 }
                 else
                 {
                     throw;
                 }
             }

             return NoContent();
         }

         // POST: api/EmployeeInfoes
         // To protect from overposting attacks, enable the specific properties you want to bind to, for
         // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
         [HttpPost]
         public async Task<ActionResult<EmployeeInfo>> PostEmployeeInfo(EmployeeInfo employeeInfo)
         {
             _context.EmployeeInfos.Add(employeeInfo);
             await _context.SaveChangesAsync();

             //return CreatedAtAction("GetEmployeeInfo", new { id = employeeInfo.Id }, employeeInfo);
             return CreatedAtAction(nameof(GetEmployeeInfo), new { id = employeeInfo.Id }, employeeInfo);
         }

         // DELETE: api/EmployeeInfoes/5
         [HttpDelete("{id}")]
         public async Task<ActionResult<EmployeeInfo>> DeleteEmployeeInfo(int id)
         {
             var employeeInfo = await _context.EmployeeInfos.FindAsync(id);
             if (employeeInfo == null)
             {
                 return NotFound();
             }

             _context.EmployeeInfos.Remove(employeeInfo);
             await _context.SaveChangesAsync();

             return employeeInfo;
         }

         private bool EmployeeInfoExists(int id)
         {
             return _context.EmployeeInfos.Any(e => e.Id == id);
         }*/
    }
}
