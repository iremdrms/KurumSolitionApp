using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Service;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdemelerController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Odeme> _service;

        public OdemelerController(IService<Odeme> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var odemeler = await _service.GetAllAsync();

            var odemelerDtos = _mapper.Map<List<OdemeDto>>(odemeler).ToList();
            //return Ok( CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));

            return CreateActionResult(CustomResponseDto<List<OdemeDto>>.Success(200, odemelerDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var odeme = await _service.GetByIdAsync(id);

            var odemelerDtos = _mapper.Map<OdemeDto>(odeme);
            return CreateActionResult(CustomResponseDto<OdemeDto>.Success(200, odemelerDtos));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OdemeDto odemeDto)
        {
            var odeme = await _service.AddAsync(_mapper.Map<Odeme>(odemeDto));

            var odemelerDtos = _mapper.Map<OdemeDto>(odeme);
            return CreateActionResult(CustomResponseDto<OdemeDto>.Success(201, odemelerDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(OdemeUpdateDto productDto)
        {
            await _service.UpdateAsync(_mapper.Map<Odeme>(productDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var odeme = await _service.GetByIdAsync(id);

            await _service.RemoveAsync(odeme);

            var odemelerDtos = _mapper.Map<OdemeDto>(odeme);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}

