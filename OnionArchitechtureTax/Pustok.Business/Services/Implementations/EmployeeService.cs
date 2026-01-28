using AutoMapper;
using Pustok.Business.DTOs;
using Pustok.Business.Exceptions;
using Pustok.Core.Entities;
using Pustok.DataAccess.Repositories;

namespace Pustok.Business.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;
    private readonly IMapper _mapper;

    public EmployeeService(IEmployeeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task CreateAsync(EmployeePostDTO dto)
    {
        var employee = _mapper.Map<Employee>(dto);
        await _repository.AddAsync(employee);
        await _repository.SaveAsync();

    }
    public async Task<List<EmployeeGetDTO>> GetAllAsync()
    {
        var employees = await _repository.GetAllAsync();
        var employeeDTOs = _mapper.Map<List<EmployeeGetDTO>>(employees);
        return employeeDTOs;
    }

    public async Task<EmployeeGetDTO> GetByIdAsync(int id)
    {
        var employee = await _repository.GetByIdAsync(id);
        if (employee is null)
            throw new NotFoundException();

        var employeeDTO = _mapper.Map<EmployeeGetDTO>(employee);
        return employeeDTO;
    }

    public async Task UpdateAsync(int id, EmployeePutDTO dto)
    {
        var employee = await _repository.GetByIdAsync(id);
        if (employee is null)
            throw new NotFoundException();

        _mapper.Map(dto, employee);
        _repository.Update(employee);
        await _repository.SaveAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var employee = await _repository.GetByIdAsync(id);
        if (employee is null)
            throw new NotFoundException();

        _repository.Delete(employee);
        await _repository.SaveAsync();
    }

}

