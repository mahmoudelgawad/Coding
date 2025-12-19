using AutoMapper;
using MagicVillaAPI.CustomLogging;
using MagicVillaAPI.Data;
using MagicVillaAPI.Models;
using MagicVillaAPI.Models.DTO;
using MagicVillaAPI.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace MagicVillaAPI.Controllers
{
    //#for binding first part name of controller 'VillaAPI' 
    //[Route("api/[controller]")]
    [Route("api/villaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        //#default MS Logger
        readonly private ILogger<VillaAPIController> _logger;

        //#SegriLog Logger
        // readonly private ILogger _logger;

        //#custom logging
        //readonly private ILogging _logger;

        readonly private IMapper _mapper;

        //#default MS Logger
        //public VillaAPIController(ILogger<VillaAPIController> logger)
        
        //for SeriLog or Custom Loggin
        //public VillaAPIController(ILogger logger)

        //readonly private ApplicationDBContext _db;
        readonly private IVillaRepository<Villa> _db;
        public VillaAPIController(
            ILogger<VillaAPIController> logger,
            //ApplicationDBContext dbcontext,
            IVillaRepository<Villa> dbVilla,
            IMapper mapper) 
        {
            _logger = logger;
            //_db = dbcontext;
            _db = dbVilla;
            _mapper = mapper;
        }

        /*
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas() 
        {
            return VillaStore.villas;
        }
  
        [HttpGet("{id:int}")]
        public VillaDTO? GetVilla(int id) 
        {
            return VillaStore.villas.FirstOrDefault(v => v.ID == id);
        }
        */

        //#using ActionResult:IActionResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        {
            _logger.LogInformation("Return All Villas");
            //return Ok(VillaStore.villas);
            return Ok(await _db.GetAllAsync());
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        //# attribute for swagger documentation
        //[ProducesResponseType(200,Type = typeof(VillaDTO))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDTO>> GetVilla(int id)
        {
            //#validation
            if (id == 0) 
            {
                _logger.LogError($"Wrong Villa ID = {id}");
                return BadRequest();
            }

            var villa = await _db.GetAsync(v => v.ID == id);

            if (villa == null) return NotFound();

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody] VillaCreatDTO villaDTO)
        {
            //#validations
            //#apply data annotation validation
            if (!ModelState.IsValid) return BadRequest(ModelState); //400 code
            if (villaDTO == null) return BadRequest(villaDTO);
            //#ignored , not exist in VillaCreatDTO
            //if (villaDTO.ID > 0) return StatusCode(StatusCodes.Status500InternalServerError);
            //#cusomt validation allready exist villa name
            if (await _db.GetAsync(v => v.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomValidation", "Villa Name Already Exist");
                return BadRequest(ModelState);
            }

            var newVilla = _mapper.Map<Villa>(villaDTO);
            //#ignored no need id will increment auto
            //newVilla.ID = (await _db.Villas.OrderByDescending(v => v.ID).FirstOrDefaultAsync()).ID + 1;           
            newVilla.CreatedDate = DateTime.Now;
            await _db.CreateAsync(newVilla);

            //#return 200 : OK
            //return Ok(villaDTO);

            //#return 201: created
            //#return genrate link of 'GetVilla' API end point with id parameter, and body with villaDTO
            /* RESPONSE
             content-type: application/json; charset=utf-8
             location: https://localhost:44326/api/villaAPI/3
             server: Microsoft-IIS/10.0
             x-powered-by: ASP.NET
             date: Fri, 31 Oct 2025 17:31:47 GMT
            */
            return CreatedAtRoute("GetVilla", new { id = newVilla.ID }, villaDTO);

        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<ActionResult> DeleteVilla(int id)
        {
            if (id == 0) return BadRequest();
            var villa =await _db.GetAsync(v => v.ID == id);
            if (villa == null) return NotFound();
            await _db.RemoveAsync(villa);
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}",Name ="UpdateVilla")]
        public async Task<ActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaDto) 
        {
            if (villaDto == null || id != villaDto.ID) return BadRequest();
            //#ignored will update direct
            //var villa = _db.Villas.FirstOrDefault(v => v.ID == id);
            //if (villa == null) return NotFound();
            var updatedVilla = _mapper.Map<Villa>(villaDto);

            //#automatic update
            await _db.UpdateAsync(updatedVilla);
            return NoContent();
        }


        [ProducesResponseType(StatusCodes.Status204NoContent)] 
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        public async Task<ActionResult> UpdatePartialVilla(int id,[FromBody]JsonPatchDocument<VillaUpdateDTO> patchVillaDto)
        {
            if (patchVillaDto == null || id == 0) return BadRequest();
            //var villa = _db.Villas.FirstOrDefault(v => v.ID == id);
            //# to fix 2 tracked error update in savechanges
            var villa =await _db.GetAsync(v => v.ID == id,true);
            if (villa == null) return BadRequest();
            var newVillaDTO = _mapper.Map<VillaUpdateDTO>(villa);
            patchVillaDto.ApplyTo(newVillaDTO,ModelState);
            //#will fail because 2 villa instance with same id tracked
            //#because 'new' with updatedVilla  so use 'AsNoTracking()'
            var updatedVilla = _mapper.Map<Villa>(newVillaDTO);
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _db.UpdateAsync(updatedVilla);           
            return NoContent();
        }

        
    }
}
