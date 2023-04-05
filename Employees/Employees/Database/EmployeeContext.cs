using Employees.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees.Database
{
	public class EmployeeContext : DbContext
	{
		public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
		{
		}
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeePosition> EmployeePositions { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var employee1 = new Employee
			{
				EmpId = Guid.NewGuid(),
				EmpLname = "Ingram",
				EmpFname = "Matt",
				Address = "123 street",
				Department = "dept",
				DOB = DateTime.Now.ToUniversalTime(),
				Gender = "Male",
				ProjectId = Guid.NewGuid(),
			};
			var employee2 = new Employee
			{
				EmpId = Guid.NewGuid(),
				EmpLname = "Smith",
				EmpFname = "Bob",
				Address = "999 street",
				Department = "dept2",
				DOB = DateTime.Parse("01/01/2000").ToUniversalTime(),
				Gender = "Female",
				ProjectId = Guid.NewGuid(),
			};

			modelBuilder.Entity<Employee>().HasData(new List<Employee>
			{
				employee1, employee2
			});
			modelBuilder.Entity<EmployeePosition>().HasData(new List<EmployeePosition>
			{
				new EmployeePosition
				{
					Id = employee1.EmpId,
					DateOfJoining = DateTime.Parse("02/01/2022").ToUniversalTime(),
					EmpPosition = "Manager",
					Salary = 5m
				},
				new EmployeePosition
				{
					Id = employee2.EmpId,
					DateOfJoining = DateTime.Parse("03/01/2023").ToUniversalTime(),
					EmpPosition = "Consultant",
					Salary = 5000000m
				}
			});

			base.OnModelCreating(modelBuilder);
		}
	}
}
