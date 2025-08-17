﻿namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDtocs
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public double Salary { get; set; }
    }
}
