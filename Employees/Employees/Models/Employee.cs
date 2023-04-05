using System.ComponentModel.DataAnnotations;

namespace Employees.Models
{
	public class Employee
	{
		[Key] public Guid EmpId { get; set; } = Guid.NewGuid();
		public string EmpFname { get; set; }
		public string EmpLname { get; set; }
		public string Department { get; set; }
		public Guid ProjectId { get; set; }
		public string Address { get; set; }
		public DateTime DOB { get; set; }
		public string Gender { get; set; }
	}
}
