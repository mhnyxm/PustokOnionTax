using Pustok.Business.DTOs;

namespace Pustok.Business.Services;

public interface IEmployeeService
{
    Task<List<EmployeeGetDTO>> GetAllAsync();
    Task<EmployeeGetDTO> GetByIdAsync(int id);
    Task<ResultDTO> CreateAsync(EmployeePostDTO dto);
    Task<ResultDTO> UpdateAsync(int id, EmployeePutDTO dto);
    Task<ResultDTO> DeleteAsync(int id);
}
   