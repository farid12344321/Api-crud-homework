﻿using Domain.Models;
using Services.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto> GetByIdAsync(int? id);
        Task CreateAsync(EmployeeCreateDto employee);
        Task DeleteAsync(int? id);

        Task<IEnumerable<EmployeeDto>> SearchAsync(string name);
    }
}
