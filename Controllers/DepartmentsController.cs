using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationcore.netmultp.Models;

namespace WebApplicationcore.netmultp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List < Department > list = new List<Department>();
            list.Add(new Department {Id = 1,Name = "Fiscal" });
            list.Add(new Department { Id = 2, Name = "Juridico" });
            list.Add(new Department { Id = 3, Name = "Financeiro" });
            list.Add(new Department { Id = 4, Name = "Vendas" });
            return View(list);
        }
    }
}