namespace Pustok.Business.DTOs;

public class EmployeeGetDTO
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public decimal Salary { get; set; }
    public bool IsActive { get; set; }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
}
