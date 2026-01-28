namespace Pustok.Business.DTOs;

public class EmployeePutDTO
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public decimal Salary { get; set; }
    public bool IsActive { get; set; }

    public int DepartmentId { get; set; }
}