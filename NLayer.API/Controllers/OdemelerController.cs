using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Enums;
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
        public async Task<IActionResult> All(string tckn)
        {
            var odemeler = _service.Where(x => x.TcKimlikNo.Equals(tckn) && x.OdemeDurumu == OdemeDurumuEnum.Odenebilir).ToList();

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

        [HttpPost("OdemeYap")]
        public async Task<IActionResult> OdemeYap(string tckn, int odemeNo)
        {
            var odeme = await _service.Where(x => x.TcKimlikNo.Equals(tckn) && x.Id == odemeNo).SingleOrDefaultAsync();

            if (odeme == null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404, "Ödeme bulunamadı."));
            }

            if (odeme.OdemeDurumu != OdemeDurumuEnum.Odenebilir)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(400, "Bu ödeme zaten ödenmiş veya ödeme tarihi gelmemiş."));
            }

            // Ödeme tarihi kontrolü
            if (odeme.OdemeTarihi > DateTime.Now)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(400, "Ödeme tarihi henüz gelmemiştir."));
            }

            odeme.OdemeDurumu = OdemeDurumuEnum.Odendi;

            await _service.UpdateAsync(odeme);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }


        [HttpPut]
        
        
        public async Task<IActionResult> Update([FromBody] OdemeUpdateDto odemeDto)
        {
            await _service.UpdateAsync(_mapper.Map<Odeme>(odemeDto));

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

