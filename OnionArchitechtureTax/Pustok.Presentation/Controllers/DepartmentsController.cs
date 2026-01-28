using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pustok.Business.DTOs;
using Pustok.Business.Services;

namespace Pustok.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDepartmentService _service;

    public DepartmentsController(IDepartmentService service)
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
    public async Task<IActionResult> Create([FromBody] DepartmentPostDTO dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] DepartmentPutDTO dto)
    {
        await _service.UpdateAsync(id, dto);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DepartmentPostDTO dto)
    {
        await _service.CreateAsync(dto);
        return Ok();
    }
}
