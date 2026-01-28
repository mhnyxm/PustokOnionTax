using Pustok.Business.DTOs;

namespace Pustok.Business.Services;

public interface IEmployeeService
{
    Task<List<EmployeeGetDTO>> GetAllAsync();
    Task<EmployeeGetDTO> GetByIdAsync(int id);
    Task CreateAsync(EmployeePostDTO dto);
    Task UpdateAsync(int id, EmployeePutDTO dto);
    Task DeleteAsync(int id);
}
   