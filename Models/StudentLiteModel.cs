using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class StudentLiteModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Class { get; set; }
		public StudentLiteModel() { }
		public StudentLiteModel(int id, string firstName, string middlename, string lastname, string classname)
		{
			Id = id;
			LastName = lastname;
			MiddleName = middlename;
			FirstName = firstName;
			Class = classname;
		}
		public StudentLiteModel(StudentLiteModel student)
		{
			this.Id = student.Id;
			this.FirstName = student.FirstName;
			this.MiddleName = student.MiddleName;
			this.LastName = student.LastName;
			this.Class = student.Class;
		}
		public override string ToString()
		{
			return $"{Id}|{FirstName}|{MiddleName}|{LastName}|{Class}";
		}
	}
}
