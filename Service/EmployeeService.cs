using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Domain;
using Domain.DTO;
using Repository;
using AutoMapper;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository _repository;
        
        public EmployeeService()
        {
            _repository = new EmployeeRepository();
        }

        public async Task<List<EmployeeDTO>> GetEmployees()
        {
            var employees = _repository.All<Employee>().ToList();
            var employeesDTO = AutoMapper.Mapper.Map<List<EmployeeDTO>>(employees);

            return employeesDTO;
        }
    }
}