using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using ApiApolo.Controllers;
using AutoMapper;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistencia.Entities;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace API.Controllers
{  
    public class CountryController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CountryController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CountryDto>>> Get()
    {
        var auditorias = await _unitOfWork.Countries.GetAllAsync();
        // return Ok(entity);
        return _mapper.Map<List<CountryDto>>(auditorias);
    }

    // [HttpGet("{id}")]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<CountryDto>> Get(int id)
    // {
    //     var auditoria = await _unitOfWork.Countries.GetById(id);
    //     if (auditoria == null)
    //         return NotFound();
    //     return _mapper.Map<CountryDto>(auditoria);
    // }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<City>> Post(int id, [FromBody] CityDto auditoriaDto)
    {
        var auditoria = _mapper.Map<City>(auditoriaDto);

        auditoriaDto.Id = auditoria.Id;
        return CreatedAtAction(nameof(Post), new { id = auditoria.Id }, auditoriaDto);
    }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // public ActionResult<CityDto> (int id, [FromBody] CityDto cityDto)
        // {
            // if (auditoriaDto == null)
            //     return NotFound();
            // if(auditoriaDto.Id == 0)
            // {
            //     auditoriaDto.Id = id;
            // }
            // if(auditoriaDto.Id != id)
            // {
            //     return BadRequest();
            // }
            // var auditoria = _mapper.Map<Auditoria>(auditoriaDto);

            // if (auditoriaDto.FechaCreacion == DateOnly.MinValue)
            // {
            //     auditoriaDto.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            //     auditoria.FechaCreacion = DateOnly.FromDateTime(DateTime.Now);
            // }
            // if (auditoriaDto.FechaModificacion == DateOnly.MinValue)
            // {
            //     auditoriaDto.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            //     auditoria.FechaModificacion = DateOnly.FromDateTime(DateTime.Now);
            // }

            // _unitOfWork.Auditorias.Update(auditoria);
            // await _unitOfWork.SaveAsync();
            // return auditoriaDto;
        // }
        [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var auditoria = await _unitOfWork.Cities.GetByIdAsync(id);

        if (auditoria == null)
            return BadRequest();

        _unitOfWork.Cities.Remove(auditoria);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}}