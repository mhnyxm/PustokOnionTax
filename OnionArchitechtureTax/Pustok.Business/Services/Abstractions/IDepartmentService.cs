using Pustok.Business.DTOs;

namespace Pustok.Business.Services;

public interface IDepartmentService
{
    Task<List<DepartmentGetDTO>> GetAllAsync();
    Task<DepartmentGetDTO> GetByIdAsync(int id);

    Task<ResultDTO> CreateAsync(DepartmentPostDTO dto);
    Task<ResultDTO> UpdateAsync(int id, DepartmentPutDTO dto);

    Task<ResultDTO> DeleteAsync(int id);
}