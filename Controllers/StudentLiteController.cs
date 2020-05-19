using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentLiteController : Controller
    {
		private SmdbContext studentLiteDb;
		public StudentLiteController(SmdbContext context)
		{
			studentLiteDb = context;
		}
        public IActionResult Index()
        {
			
			
			StudentLiteViewModel viewmodel = new StudentLiteViewModel()
			{
				studentLites = students.ToArray()
			};
			return View(viewmodel);
        }
		private async Task<StudentLiteModel[]> FetchStudentLite()
		{
			StudentLiteModel[] returnable = await Foo();
			return returnable;
		}
		private Task<StudentLiteModel[]> Foo()
		{
			List<StudentLiteModel> students = new List<StudentLiteModel>();
			var query = from studentLite in studentLiteDb.Students
						orderby studentLite.Id
						select studentLite;

			foreach (var student in query)
				students.Add(new StudentLiteModel(student));
			return students.ToArray();
		}
    }
}