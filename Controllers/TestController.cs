using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
		private ITestService myTestService;
		public TestController(ITestService service)
		{
			myTestService = service;
		}
        public IActionResult Index()
        {
			myTestService.DoTaskAsync();
			
            return View();
			
        }
    }
}