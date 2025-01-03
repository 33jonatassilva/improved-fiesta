﻿using EasyManage.Models;

namespace EasyManage.Repositories.Interfaces;

public interface IEmployeeRepository
{
    void AddEmployee(Employee employee);
    List<Employee> GetAllEmployees();
    Employee GetEmployeeById(string cpf);
    void EmployeeUpdate(Employee employee);
    void Demiss(string cpf);
    void DeleteEmployee(string cpf);
    
    
}