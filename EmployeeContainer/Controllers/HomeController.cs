﻿using EmployeeContainer.Models;
using EmployeeContainer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeContainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }
        public ViewResult Details(int id)

        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id),
                PageTitle = "Employee Details"
            };
            
            return View(homeDetailsViewModel);
        }
        public ViewResult Create()
        {
            return View();
        }
    }
}
