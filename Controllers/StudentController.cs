using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
		//List<StudentModel> students;
		ApplicationDbContext dbContext;

		public StudentController(ApplicationDbContext applicationDb)
		{
			dbContext = applicationDb;	
		}
        public IActionResult Index()
        {
			////select * from Students
			List<StudentModel> students = new List<StudentModel>();

			var query = from student in dbContext.Students
						orderby student.Id
						select student;
			foreach(StudentModel student in query)
			{
				students.Add(student);
			}
			return View(students.ToArray());
		}
		//[HttpGet]
		//public IActionResult Create()
		//{

		//	//return Content
		//	return View();
		//}
		[HttpGet]
		public IActionResult Create()
		{
			StudentModel model = new StudentModel();
			return View(model);	//this way the ViewData.Model property is assigned to this model
			//also notice that using model directive in the view do the same thing as this.
		}
		[HttpPost]
		public IActionResult Create(StudentModel _student)
		{
			string msg = null;
			if (ModelState.IsValid)
			{

				msg = "New student created:\n" + _student.ToString();
			}
			else
			{
				msg = "Creation failed";
			}

			return Content(msg);
		}
	}
}