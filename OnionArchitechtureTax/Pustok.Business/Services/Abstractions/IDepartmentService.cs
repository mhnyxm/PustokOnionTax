using Pustok.Business.DTOs;

namespace Pustok.Business.Services;

public interface IDepartmentService
{
    Task<List<DepartmentGetDTO>> GetAllAsync();
    Task<DepartmentGetDTO> GetByIdAsync(int id);

    Task CreateAsync(DepartmentPostDTO dto);
    Task UpdateAsync(int id, DepartmentPutDTO dto);

    Task DeleteAsync(int id);
}