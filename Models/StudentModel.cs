using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class StudentModel
	{
		public string Id { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string FamilyName { get; set; }
		public string Class { get; set; }
		public StudentModel() { }
		public StudentModel(string id, string lastname, string middlename, string familyName, string classname)
		{
			Id = id;
			LastName = lastname;
			MiddleName = middlename;
			FamilyName = familyName;
			Class = classname;
		}
		public override string ToString()
		{
			return $"{Id}|{FamilyName}|{LastName}|{MiddleName}|{Class}";
		}
	}
}
