using System.ComponentModel.DataAnnotations;

namespace Employees.Models
{
	public class EmployeePosition
	{
		public Guid Id { get; set; }
		public string EmpPosition { get; set; }
		public DateTime DateOfJoining { get; set; }
		public decimal Salary { get; set; }
	}
}
