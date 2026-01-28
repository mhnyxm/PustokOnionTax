using Microsoft.AspNetCore.Mvc;
using Pustok.Business.DTOs;
using Pustok.Business.Services;

namespace Pustok.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _service;

    public EmployeesController(IEmployeeService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var employees = await _service.GetAllAsync();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var employee = await _service.GetByIdAsync(id);
        return Ok(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] EmployeePostDTO dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id,[FromBody] EmployeePutDTO dto)
    {
        await _service.UpdateAsync(id,dto);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] EmployeePostDTO dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }
}
