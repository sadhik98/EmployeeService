﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
namespace EmployeeService.Controllers
{

    [Authorize]
    public class EmployeesController : ApiController
    {
        
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}