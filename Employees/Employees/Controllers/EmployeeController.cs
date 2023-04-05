using Employees.Database;
using Employees.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EmployeeController : ControllerBase
	{
		private EmployeeContext _context;

		public EmployeeController(EmployeeContext context)
		{
			_context = context;
		}

		[HttpGet]
		public ActionResult<List<Employee>> GetEmployees()
		{
			var employees = _context.Employees.ToList();
			return Ok(employees);
		}

		[HttpGet("Positions")]
		public ActionResult<List<string>> GetEmployeesWithPositions()
		{
			List<string> positions = new List<string>();
			var employees = _context.Employees.ToList();
			foreach (var employee in employees)
			{
				var position = _context.EmployeePositions.Find(employee.EmpId);
				positions.Add(new string($"{employee.EmpFname} {employee.EmpLname} has position: {position.EmpPosition}"));
			}
			
			return Ok(positions);
		}
	}
}