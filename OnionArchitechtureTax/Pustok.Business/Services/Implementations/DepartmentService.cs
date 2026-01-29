using AutoMapper;
using Pustok.Business.DTOs;
using Pustok.Business.Exceptions;
using Pustok.Core.Entities;
using Pustok.DataAccess.Repositories;

namespace Pustok.Business.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository _repository;
    private readonly IMapper _mapper;

    public DepartmentService(IDepartmentRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ResultDTO> CreateAsync(DepartmentPostDTO dto)
    {
        var department = _mapper.Map<Department>(dto);
        await _repository.AddAsync(department);
        await _repository.SaveAsync();
        return new("Department Created");
    }
    public async Task<List<DepartmentGetDTO>> GetAllAsync()
    {
        var departments = await _repository.GetAllAsync();
        var departmentDTOs = _mapper.Map<List<DepartmentGetDTO>>(departments);
        return departmentDTOs;
    }

    public async Task<DepartmentGetDTO> GetByIdAsync(int id)
    {
        var department = await _repository.GetByIdAsync(id);
        if (department is null)
            throw new NotFoundException();

        var departmentDTO = _mapper.Map<DepartmentGetDTO>(department);
        return departmentDTO;
    }

    public async Task<ResultDTO> UpdateAsync(int id, DepartmentPutDTO dto)
    {
        var department = await _repository.GetByIdAsync(id);
        if (department is null)
            throw new NotFoundException();

        _mapper.Map(dto, department);
        _repository.Update(department);
        await _repository.SaveAsync();
        return new("Department Updated");
    }

    public async Task<ResultDTO> DeleteAsync(int id)
    {
        var department = await _repository.GetByIdAsync(id);
        if (department is null)
            throw new NotFoundException();

         _repository.Delete(department);
        await _repository.SaveAsync();
        return new("Department Deleted");
    }

}